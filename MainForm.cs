using System;
using System.Drawing;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using DashboardTurismoReal.FormReserva;
using DashboardTurismoReal.FormUsuario;
using DashboardTurismoReal.FormProducto;
using DashboardTurismoReal.FormServicio;
using DashboardTurismoReal.FormProveedor;
using DashboardTurismoReal.FormInventario;
using DashboardTurismoReal.Forms.FormChecks;
using DashboardTurismoReal.Forms.FormMultas;
using DashboardTurismoReal.Forms.FormDepartamento;

namespace DashboardTurismoReal
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HT_CAPTION = 0x0002;

        private IConfiguration _configuration;
        private bool _subMenuVisible = false;
        private string token;
        private string rol;
        public MainForm(IConfiguration configuration, string token, string rol)
        {
            InitializeComponent();
            BarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            _configuration = configuration;
            this.token = token;
            this.rol = rol;

            // Suscribir el formulario principal al evento MouseDown
            this.MouseDown += MainForm_MouseDown;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.TopLevel = false;
            formInicio.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formInicio);
            this.panelContenedor.Tag = formInicio;
            formInicio.Show();
        }

        private void OpenChildForm(object childForm)
        {
            try
            {
                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);

                Form cf = childForm as Form;
                cf.TopLevel = false;
                cf.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(cf);
                this.panelContenedor.Tag = cf;
                cf.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el formulario hijo: " + ex.Message);
            }
        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInicio());
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuDepartamentos.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuDepartamentos.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnVerDepartamento_Click(object sender, EventArgs e)
        {
            subMenuDepartamentos.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVDepartamentos());
            Console.WriteLine("Hola Mundo");
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            subMenuDepartamentos.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormADepartamentos());
        }
        private void btnFotosDpto_Click(object sender, EventArgs e)
        {
            subMenuDepartamentos.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormFDepartamentos());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuReservas.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuReservas.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            subMenuInventario.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVReservas());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuUsuarios.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuUsuarios.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnChecks_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuChecks.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuChecks.Visible = true;
                _subMenuVisible = true;
            }
        }
        private void btnVerCheckIn_Click(object sender, EventArgs e)
        {
            subMenuChecks.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVCheckIn());
        }
        private void btnVerCheckOut_Click(object sender, EventArgs e)
        {
            subMenuChecks.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVCheckOut());
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVUsuarios());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuProductos.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuProductos.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            subMenuProductos.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVProductos());
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            subMenuProductos.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormAProductos());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuServicios.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuServicios.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnVerServicios_Click(object sender, EventArgs e)
        {
            subMenuServicios.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVServicios());
        }

        private void btnAgregarServicios_Click(object sender, EventArgs e)
        {
            subMenuServicios.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormAServicios());
        }


        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuProveedores.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuProveedores.Visible = true;
                _subMenuVisible = true;
            }
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            subMenuProveedores.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVProveedores());
        }

        private void btnAgregarProveedores_Click(object sender, EventArgs e)
        {
            subMenuProveedores.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormAProveedores());
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuInventario.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuInventario.Visible = true;
                _subMenuVisible = true;
            }
        }
        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            subMenuInventario.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormVInventarios());
        }

        private void btnAddInventario_Click(object sender, EventArgs e)
        {
            subMenuInventario.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormAInventarios());
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            if (_subMenuVisible)
            {
                subMenuMultas.Visible = false;
                _subMenuVisible = false;
            }
            else
            {
                subMenuMultas.Visible = true;
                _subMenuVisible = true;
            }
        }
        private void btnGestionarMultas_Click(object sender, EventArgs e)
        {
            subMenuInventario.Visible = false;
            _subMenuVisible = false;
            OpenChildForm(new FormGMultas());
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar si el clic ocurrió fuera del submenú de inventario
            if (!_subMenuVisible)
            {
                // Ocultar el submenú
                subMenuInventario.Visible = false;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de inicio de sesión
            FormLogin formLogin = new FormLogin();

            // Mostrar el formulario de inicio de sesión y cerrar el formulario actual
            formLogin.Show();
            this.Close();
        }

    }
}
