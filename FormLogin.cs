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

                // Crear un objeto anónimo para enviar como cuerpo de la solicitud
                var requestData = new
                {
                    Email = correoElectronico,
                    Password = contrasena
                };

                // Convertir el objeto en formato JSON
                string jsonRequest = JsonConvert.SerializeObject(requestData);

                // Realizar la solicitud POST a la API
                string endpoint = "/api/Usuario/LoginAdmin";
                string responseData = await apiManager.PostApiResponse(endpoint, jsonRequest);

                // Analizar la respuesta JSON
                dynamic response = JsonConvert.DeserializeObject(responseData);

                if (response != null && response.resultado != null && response.mensaje != null)
                {
                    bool resultado = response.resultado;
                    string mensaje = response.mensaje;

                    if (resultado)
                    {
                        // Inicio de sesión exitoso como administrador
                        MessageBox.Show(mensaje, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Redirigir al formulario MainForm
                        IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();
                        MainForm mainForm = new MainForm(configuration);
                        mainForm.Show();

                        // Cerrar el formulario de inicio de sesión
                        this.Hide();
                    }
                    else
                    {
                        // Inicio de sesión fallido
                        MessageBox.Show(mensaje, "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // La respuesta JSON no contiene las propiedades esperadas
                    MessageBox.Show("Respuesta inválida del servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el inicio de sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
