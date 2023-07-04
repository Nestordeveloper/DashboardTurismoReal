using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardTurismoReal.Models;

namespace DashboardTurismoReal
{
    public partial class FormLogin : Form
    {
        private AzureApiManager apiManager;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HT_CAPTION = 0x0002;

        public FormLogin()
        {
            InitializeComponent();
            BarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            Resize += FormLogin_Resize;
            labelEmail.Parent = pictureBoxWPLogin;
            labelPassword.Parent = pictureBoxWPLogin;
            labelEmail.BackColor = Color.Transparent;
            labelPassword.BackColor = Color.Transparent;

            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            // Ajustar el tamaño del PictureBox al tamaño de la ventana
            pictureBoxWPLogin.Width = this.Width;
            pictureBoxWPLogin.Height = this.Height;
        }

        private void btnMaximizarLog_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizarLog.Visible = false;
            btnRestaurarLog.Visible = true;
        }

        private void btnRestaurarLog_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurarLog.Visible = false;
            btnMaximizarLog.Visible = true;
        }

        private void btnCerrarLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarLog_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private string correoElectronicoPlaceholder = "Email";
        private string contrasenaPlaceholder = "Password";

        private void txtCorreoElectronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text == correoElectronicoPlaceholder)
            {
                txtCorreoElectronico.Text = string.Empty;
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreoElectronico.Text))
            {
                txtCorreoElectronico.Text = correoElectronicoPlaceholder;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == contrasenaPlaceholder)
            {
                txtContrasena.Text = string.Empty;
                txtContrasena.PasswordChar = '*'; // Opcional: para ocultar los caracteres de la contraseña
            }
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*'; // Mostrar caracteres de la contraseña
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string correoElectronico = txtCorreoElectronico.Text;
                string contrasena = txtContrasena.Text;

                // Verificar que se haya ingresado un correo y una contraseña
                if (string.IsNullOrWhiteSpace(correoElectronico) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Por favor, ingrese un correo y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un objeto de tipo Usuario para enviar como cuerpo de la solicitud
                Usuario usuario = new Usuario
                {
                    Email = correoElectronico,
                    idRol = 3,
                    Password = contrasena
                };

                // Realizar la solicitud POST a la API
                string endpoint = "api/Usuario/LoginAdmin";
                string jsonRequest = JsonConvert.SerializeObject(usuario);
                string responseData = await apiManager.PostApiResponse(endpoint, jsonRequest);

                // Analizar la respuesta JSON
                dynamic response = JsonConvert.DeserializeObject(responseData);

                // Verificar si se recibió un token válido
                if (response != null && response["token"] != null)
                {
                    string token = response["token"];

                    // Obtener el rol del usuario
                    string rol = await ObtenerRol(correoElectronico);

                    // Verificar si el rol es "Administrador"
                    if (rol == "Administrador")
                    {
                        // Inicio de sesión exitoso
                        MessageBox.Show("Inicio de sesión exitoso", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Por ejemplo, puedes pasar el token y el rol al formulario MainForm
                        IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();
                        MainForm mainForm = new MainForm(configuration, token, rol);
                        mainForm.Show();

                        // Cerrar el formulario de inicio de sesión
                        this.Hide();
                    }
                    else
                    {
                        // El usuario no tiene el rol de "Administrador"
                        MessageBox.Show("No tienes permisos suficientes para iniciar sesión como Administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // La respuesta JSON no contiene un token válido
                    MessageBox.Show("Credenciales inválidas. Inicio de sesión fallido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el inicio de sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async Task<string> ObtenerRol(string correoElectronico)
        {
            try
            {
                // Realizar la solicitud GET a la API para obtener el usuario por correo electrónico
                string endpoint = $"api/Usuario/LoginGetUsuario/{correoElectronico}";
                string responseData = await apiManager.GetApiResponse(endpoint);

                // Analizar la respuesta JSON
                dynamic response = JsonConvert.DeserializeObject(responseData);

                if (response != null && response["rol"] != null)
                {
                    string rol = response["rol"];
                    return rol;
                }
                else
                {
                    // No se pudo obtener el rol del usuario
                    throw new Exception("No se pudo obtener el rol del usuario.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error de solicitud o análisis de respuesta
                throw new Exception("Error al obtener el rol del usuario: " + ex.Message);
            }
        }



        /*
        private void btnMostrarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.PasswordChar = '\0'; // Mostrar caracteres de la contraseña
        }

        private void btnMostrarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.PasswordChar = '*'; // Ocultar caracteres de la contraseña
        }*/
    }
}
