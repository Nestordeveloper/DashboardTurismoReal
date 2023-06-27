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
