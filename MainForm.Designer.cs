namespace DashboardTurismoReal
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BarraTitulo = new Panel();
            pictureBox9 = new PictureBox();
            btnRestaurar = new Button();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            MenuVertical = new Panel();
            subMenuProveedores = new FlowLayoutPanel();
            btnVerProveedores = new Button();
            btnAgregarProveedores = new Button();
            btnMultas = new Button();
            subMenuMultas = new FlowLayoutPanel();
            btnGestionarMultas = new Button();
            pictureBox11 = new PictureBox();
            subMenuServicios = new FlowLayoutPanel();
            btnVerServicios = new Button();
            btnAgregarServicios = new Button();
            btnLogOut = new PictureBox();
            subMenuChecks = new FlowLayoutPanel();
            btnVerCheckIn = new Button();
            btnVerCheckOut = new Button();
            btnChecks = new Button();
            pictureBox10 = new PictureBox();
            subMenuDepartamentos = new FlowLayoutPanel();
            btnVerDepartamento = new Button();
            btnAgregarDepartamento = new Button();
            subMenuInventario = new FlowLayoutPanel();
            btnVerInventario = new Button();
            btnAddInventario = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            subMenuUsuarios = new FlowLayoutPanel();
            btnVerUsuarios = new Button();
            subMenuProductos = new FlowLayoutPanel();
            btnVerProductos = new Button();
            btnAgregarProductos = new Button();
            subMenuReservas = new FlowLayoutPanel();
            btnVerReservas = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnProductos = new Button();
            btnServicios = new Button();
            btnInventarios = new Button();
            btnProveedores = new Button();
            btnReservas = new Button();
            btnUsuarios = new Button();
            pictureBox2 = new PictureBox();
            btnDepartamentos = new Button();
            logoTurismoReal = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            MenuVertical.SuspendLayout();
            subMenuProveedores.SuspendLayout();
            subMenuMultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            subMenuServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            subMenuChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            subMenuDepartamentos.SuspendLayout();
            subMenuInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            subMenuUsuarios.SuspendLayout();
            subMenuProductos.SuspendLayout();
            subMenuReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoTurismoReal).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = SystemColors.Desktop;
            BarraTitulo.Controls.Add(pictureBox9);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(3, 2, 3, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 61);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(4, -14);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(76, 91);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1167, 5);
            btnRestaurar.Margin = new Padding(4, 5, 4, 5);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(63, 58);
            btnRestaurar.TabIndex = 3;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1096, 0);
            btnMinimizar.Margin = new Padding(4, 5, 4, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(63, 61);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1167, 0);
            btnMaximizar.Margin = new Padding(4, 5, 4, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(63, 61);
            btnMaximizar.TabIndex = 10;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1237, 0);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(63, 61);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = SystemColors.Desktop;
            MenuVertical.Controls.Add(subMenuChecks);
            MenuVertical.Controls.Add(subMenuProveedores);
            MenuVertical.Controls.Add(btnMultas);
            MenuVertical.Controls.Add(subMenuMultas);
            MenuVertical.Controls.Add(pictureBox11);
            MenuVertical.Controls.Add(subMenuServicios);
            MenuVertical.Controls.Add(btnLogOut);
            MenuVertical.Controls.Add(btnChecks);
            MenuVertical.Controls.Add(pictureBox10);
            MenuVertical.Controls.Add(subMenuDepartamentos);
            MenuVertical.Controls.Add(subMenuInventario);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(btnInicio);
            MenuVertical.Controls.Add(subMenuUsuarios);
            MenuVertical.Controls.Add(subMenuProductos);
            MenuVertical.Controls.Add(subMenuReservas);
            MenuVertical.Controls.Add(pictureBox8);
            MenuVertical.Controls.Add(pictureBox7);
            MenuVertical.Controls.Add(pictureBox6);
            MenuVertical.Controls.Add(pictureBox5);
            MenuVertical.Controls.Add(pictureBox4);
            MenuVertical.Controls.Add(pictureBox3);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(btnServicios);
            MenuVertical.Controls.Add(btnInventarios);
            MenuVertical.Controls.Add(btnProveedores);
            MenuVertical.Controls.Add(btnReservas);
            MenuVertical.Controls.Add(btnUsuarios);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(btnDepartamentos);
            MenuVertical.Controls.Add(logoTurismoReal);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 61);
            MenuVertical.Margin = new Padding(3, 2, 3, 2);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(269, 1065);
            MenuVertical.TabIndex = 1;
            // 
            // subMenuProveedores
            // 
            subMenuProveedores.Controls.Add(btnVerProveedores);
            subMenuProveedores.Controls.Add(btnAgregarProveedores);
            subMenuProveedores.Location = new Point(60, 711);
            subMenuProveedores.Margin = new Padding(3, 4, 3, 4);
            subMenuProveedores.Name = "subMenuProveedores";
            subMenuProveedores.Size = new Size(200, 124);
            subMenuProveedores.TabIndex = 21;
            subMenuProveedores.Visible = false;
            // 
            // btnVerProveedores
            // 
            btnVerProveedores.BackColor = SystemColors.Desktop;
            btnVerProveedores.Cursor = Cursors.Hand;
            btnVerProveedores.FlatAppearance.BorderSize = 0;
            btnVerProveedores.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerProveedores.FlatStyle = FlatStyle.Flat;
            btnVerProveedores.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerProveedores.ForeColor = Color.White;
            btnVerProveedores.Location = new Point(4, 5);
            btnVerProveedores.Margin = new Padding(4, 5, 4, 5);
            btnVerProveedores.Name = "btnVerProveedores";
            btnVerProveedores.Size = new Size(197, 52);
            btnVerProveedores.TabIndex = 19;
            btnVerProveedores.Text = "Ver Proveedores";
            btnVerProveedores.UseVisualStyleBackColor = false;
            btnVerProveedores.Click += btnVerProveedores_Click;
            // 
            // btnAgregarProveedores
            // 
            btnAgregarProveedores.BackColor = SystemColors.Desktop;
            btnAgregarProveedores.Cursor = Cursors.Hand;
            btnAgregarProveedores.FlatAppearance.BorderSize = 0;
            btnAgregarProveedores.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnAgregarProveedores.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedores.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProveedores.ForeColor = Color.White;
            btnAgregarProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProveedores.Location = new Point(4, 67);
            btnAgregarProveedores.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProveedores.Name = "btnAgregarProveedores";
            btnAgregarProveedores.RightToLeft = RightToLeft.No;
            btnAgregarProveedores.Size = new Size(197, 52);
            btnAgregarProveedores.TabIndex = 18;
            btnAgregarProveedores.Text = "Agregar Proveedores";
            btnAgregarProveedores.UseVisualStyleBackColor = false;
            btnAgregarProveedores.Click += btnAgregarProveedores_Click;
            // 
            // btnMultas
            // 
            btnMultas.BackColor = SystemColors.Desktop;
            btnMultas.Cursor = Cursors.Hand;
            btnMultas.FlatAppearance.BorderSize = 0;
            btnMultas.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnMultas.FlatStyle = FlatStyle.Flat;
            btnMultas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultas.ForeColor = Color.White;
            btnMultas.Location = new Point(60, 786);
            btnMultas.Margin = new Padding(4, 5, 4, 5);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(201, 52);
            btnMultas.TabIndex = 20;
            btnMultas.Text = "Multas";
            btnMultas.TextAlign = ContentAlignment.MiddleLeft;
            btnMultas.UseVisualStyleBackColor = false;
            btnMultas.Click += btnMultas_Click;
            // 
            // subMenuMultas
            // 
            subMenuMultas.Controls.Add(btnGestionarMultas);
            subMenuMultas.Location = new Point(60, 839);
            subMenuMultas.Margin = new Padding(3, 4, 3, 4);
            subMenuMultas.Name = "subMenuMultas";
            subMenuMultas.Size = new Size(200, 56);
            subMenuMultas.TabIndex = 21;
            subMenuMultas.Visible = false;
            // 
            // btnGestionarMultas
            // 
            btnGestionarMultas.BackColor = SystemColors.Desktop;
            btnGestionarMultas.Cursor = Cursors.Hand;
            btnGestionarMultas.FlatAppearance.BorderSize = 0;
            btnGestionarMultas.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnGestionarMultas.FlatStyle = FlatStyle.Flat;
            btnGestionarMultas.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionarMultas.ForeColor = Color.White;
            btnGestionarMultas.Location = new Point(4, 5);
            btnGestionarMultas.Margin = new Padding(4, 5, 4, 5);
            btnGestionarMultas.Name = "btnGestionarMultas";
            btnGestionarMultas.Size = new Size(197, 52);
            btnGestionarMultas.TabIndex = 19;
            btnGestionarMultas.Text = "Gestionar Multas";
            btnGestionarMultas.UseVisualStyleBackColor = false;
            btnGestionarMultas.Click += btnGestionarMultas_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(16, 786);
            pictureBox11.Margin = new Padding(4, 5, 4, 5);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(45, 52);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 26;
            pictureBox11.TabStop = false;
            // 
            // subMenuServicios
            // 
            subMenuServicios.Controls.Add(btnVerServicios);
            subMenuServicios.Controls.Add(btnAgregarServicios);
            subMenuServicios.Location = new Point(60, 652);
            subMenuServicios.Margin = new Padding(3, 4, 3, 4);
            subMenuServicios.Name = "subMenuServicios";
            subMenuServicios.Size = new Size(200, 124);
            subMenuServicios.TabIndex = 20;
            subMenuServicios.Visible = false;
            // 
            // btnVerServicios
            // 
            btnVerServicios.BackColor = SystemColors.Desktop;
            btnVerServicios.Cursor = Cursors.Hand;
            btnVerServicios.FlatAppearance.BorderSize = 0;
            btnVerServicios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerServicios.FlatStyle = FlatStyle.Flat;
            btnVerServicios.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerServicios.ForeColor = Color.White;
            btnVerServicios.Location = new Point(4, 5);
            btnVerServicios.Margin = new Padding(4, 5, 4, 5);
            btnVerServicios.Name = "btnVerServicios";
            btnVerServicios.Size = new Size(197, 52);
            btnVerServicios.TabIndex = 19;
            btnVerServicios.Text = "Ver Servicios";
            btnVerServicios.UseVisualStyleBackColor = false;
            btnVerServicios.Click += btnVerServicios_Click;
            // 
            // btnAgregarServicios
            // 
            btnAgregarServicios.BackColor = SystemColors.Desktop;
            btnAgregarServicios.Cursor = Cursors.Hand;
            btnAgregarServicios.FlatAppearance.BorderSize = 0;
            btnAgregarServicios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnAgregarServicios.FlatStyle = FlatStyle.Flat;
            btnAgregarServicios.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarServicios.ForeColor = Color.White;
            btnAgregarServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarServicios.Location = new Point(4, 67);
            btnAgregarServicios.Margin = new Padding(4, 5, 4, 5);
            btnAgregarServicios.Name = "btnAgregarServicios";
            btnAgregarServicios.RightToLeft = RightToLeft.No;
            btnAgregarServicios.Size = new Size(197, 52);
            btnAgregarServicios.TabIndex = 18;
            btnAgregarServicios.Text = "Agregar Servicios";
            btnAgregarServicios.UseVisualStyleBackColor = false;
            btnAgregarServicios.Click += btnAgregarServicios_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(16, 983);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(45, 52);
            btnLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogOut.TabIndex = 25;
            btnLogOut.TabStop = false;
            // 
            // subMenuChecks
            // 
            subMenuChecks.Controls.Add(btnVerCheckIn);
            subMenuChecks.Controls.Add(btnVerCheckOut);
            subMenuChecks.Location = new Point(60, 777);
            subMenuChecks.Margin = new Padding(3, 4, 3, 4);
            subMenuChecks.Name = "subMenuChecks";
            subMenuChecks.Size = new Size(200, 123);
            subMenuChecks.TabIndex = 24;
            subMenuChecks.Visible = false;
            // 
            // btnVerCheckIn
            // 
            btnVerCheckIn.BackColor = SystemColors.Desktop;
            btnVerCheckIn.Cursor = Cursors.Hand;
            btnVerCheckIn.FlatAppearance.BorderSize = 0;
            btnVerCheckIn.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerCheckIn.FlatStyle = FlatStyle.Flat;
            btnVerCheckIn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerCheckIn.ForeColor = Color.White;
            btnVerCheckIn.Location = new Point(4, 5);
            btnVerCheckIn.Margin = new Padding(4, 5, 4, 5);
            btnVerCheckIn.Name = "btnVerCheckIn";
            btnVerCheckIn.Size = new Size(197, 52);
            btnVerCheckIn.TabIndex = 19;
            btnVerCheckIn.Text = "Ver Check-In";
            btnVerCheckIn.UseVisualStyleBackColor = false;
            btnVerCheckIn.Click += btnVerCheckIn_Click;
            // 
            // btnVerCheckOut
            // 
            btnVerCheckOut.BackColor = SystemColors.Desktop;
            btnVerCheckOut.Cursor = Cursors.Hand;
            btnVerCheckOut.FlatAppearance.BorderSize = 0;
            btnVerCheckOut.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerCheckOut.FlatStyle = FlatStyle.Flat;
            btnVerCheckOut.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerCheckOut.ForeColor = Color.White;
            btnVerCheckOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCheckOut.Location = new Point(4, 67);
            btnVerCheckOut.Margin = new Padding(4, 5, 4, 5);
            btnVerCheckOut.Name = "btnVerCheckOut";
            btnVerCheckOut.RightToLeft = RightToLeft.No;
            btnVerCheckOut.Size = new Size(197, 52);
            btnVerCheckOut.TabIndex = 18;
            btnVerCheckOut.Text = "Ver Check-Out";
            btnVerCheckOut.UseVisualStyleBackColor = false;
            btnVerCheckOut.Click += btnVerCheckOut_Click;
            // 
            // btnChecks
            // 
            btnChecks.BackColor = SystemColors.Desktop;
            btnChecks.Cursor = Cursors.Hand;
            btnChecks.FlatAppearance.BorderSize = 0;
            btnChecks.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnChecks.FlatStyle = FlatStyle.Flat;
            btnChecks.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChecks.ForeColor = Color.White;
            btnChecks.Location = new Point(61, 724);
            btnChecks.Margin = new Padding(4, 5, 4, 5);
            btnChecks.Name = "btnChecks";
            btnChecks.Size = new Size(201, 52);
            btnChecks.TabIndex = 23;
            btnChecks.Text = "Checks";
            btnChecks.TextAlign = ContentAlignment.MiddleLeft;
            btnChecks.UseVisualStyleBackColor = false;
            btnChecks.Click += btnChecks_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(16, 723);
            pictureBox10.Margin = new Padding(4, 5, 4, 5);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(45, 52);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 22;
            pictureBox10.TabStop = false;
            // 
            // subMenuDepartamentos
            // 
            subMenuDepartamentos.Controls.Add(btnVerDepartamento);
            subMenuDepartamentos.Controls.Add(btnAgregarDepartamento);
            subMenuDepartamentos.Location = new Point(60, 342);
            subMenuDepartamentos.Margin = new Padding(3, 4, 3, 4);
            subMenuDepartamentos.Name = "subMenuDepartamentos";
            subMenuDepartamentos.Size = new Size(200, 123);
            subMenuDepartamentos.TabIndex = 20;
            subMenuDepartamentos.Visible = false;
            // 
            // btnVerDepartamento
            // 
            btnVerDepartamento.BackColor = SystemColors.Desktop;
            btnVerDepartamento.Cursor = Cursors.Hand;
            btnVerDepartamento.FlatAppearance.BorderSize = 0;
            btnVerDepartamento.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerDepartamento.FlatStyle = FlatStyle.Flat;
            btnVerDepartamento.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerDepartamento.ForeColor = Color.White;
            btnVerDepartamento.Location = new Point(4, 5);
            btnVerDepartamento.Margin = new Padding(4, 5, 4, 5);
            btnVerDepartamento.Name = "btnVerDepartamento";
            btnVerDepartamento.Size = new Size(197, 52);
            btnVerDepartamento.TabIndex = 19;
            btnVerDepartamento.Text = "Ver Departamentos";
            btnVerDepartamento.UseVisualStyleBackColor = false;
            btnVerDepartamento.Click += btnVerDepartamento_Click;
            // 
            // btnAgregarDepartamento
            // 
            btnAgregarDepartamento.BackColor = SystemColors.Desktop;
            btnAgregarDepartamento.Cursor = Cursors.Hand;
            btnAgregarDepartamento.FlatAppearance.BorderSize = 0;
            btnAgregarDepartamento.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnAgregarDepartamento.FlatStyle = FlatStyle.Flat;
            btnAgregarDepartamento.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarDepartamento.ForeColor = Color.White;
            btnAgregarDepartamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarDepartamento.Location = new Point(4, 67);
            btnAgregarDepartamento.Margin = new Padding(4, 5, 4, 5);
            btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            btnAgregarDepartamento.RightToLeft = RightToLeft.No;
            btnAgregarDepartamento.Size = new Size(197, 52);
            btnAgregarDepartamento.TabIndex = 18;
            btnAgregarDepartamento.Text = "Agregar Departamento";
            btnAgregarDepartamento.UseVisualStyleBackColor = false;
            btnAgregarDepartamento.Click += btnAgregarDepartamento_Click;
            // 
            // subMenuInventario
            // 
            subMenuInventario.Controls.Add(btnVerInventario);
            subMenuInventario.Controls.Add(btnAddInventario);
            subMenuInventario.Location = new Point(60, 532);
            subMenuInventario.Margin = new Padding(3, 4, 3, 4);
            subMenuInventario.Name = "subMenuInventario";
            subMenuInventario.Size = new Size(200, 120);
            subMenuInventario.TabIndex = 16;
            subMenuInventario.Visible = false;
            // 
            // btnVerInventario
            // 
            btnVerInventario.BackColor = SystemColors.Desktop;
            btnVerInventario.Cursor = Cursors.Hand;
            btnVerInventario.FlatAppearance.BorderSize = 0;
            btnVerInventario.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerInventario.FlatStyle = FlatStyle.Flat;
            btnVerInventario.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerInventario.ForeColor = Color.White;
            btnVerInventario.Location = new Point(4, 5);
            btnVerInventario.Margin = new Padding(4, 5, 4, 5);
            btnVerInventario.Name = "btnVerInventario";
            btnVerInventario.Size = new Size(197, 52);
            btnVerInventario.TabIndex = 19;
            btnVerInventario.Text = "Ver Inventario";
            btnVerInventario.UseVisualStyleBackColor = false;
            btnVerInventario.Click += btnVerInventario_Click;
            // 
            // btnAddInventario
            // 
            btnAddInventario.BackColor = SystemColors.Desktop;
            btnAddInventario.Cursor = Cursors.Hand;
            btnAddInventario.FlatAppearance.BorderSize = 0;
            btnAddInventario.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnAddInventario.FlatStyle = FlatStyle.Flat;
            btnAddInventario.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddInventario.ForeColor = Color.White;
            btnAddInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInventario.Location = new Point(4, 67);
            btnAddInventario.Margin = new Padding(4, 5, 4, 5);
            btnAddInventario.Name = "btnAddInventario";
            btnAddInventario.RightToLeft = RightToLeft.No;
            btnAddInventario.Size = new Size(197, 52);
            btnAddInventario.TabIndex = 18;
            btnAddInventario.Text = "Agregar Inventario";
            btnAddInventario.UseVisualStyleBackColor = false;
            btnAddInventario.Click += btnAddInventario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 231);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.Desktop;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(60, 231);
            btnInicio.Margin = new Padding(4, 5, 4, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(201, 52);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // subMenuUsuarios
            // 
            subMenuUsuarios.Controls.Add(btnVerUsuarios);
            subMenuUsuarios.Location = new Point(60, 466);
            subMenuUsuarios.Margin = new Padding(3, 4, 3, 4);
            subMenuUsuarios.Name = "subMenuUsuarios";
            subMenuUsuarios.Size = new Size(200, 59);
            subMenuUsuarios.TabIndex = 21;
            subMenuUsuarios.Visible = false;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.BackColor = SystemColors.Desktop;
            btnVerUsuarios.Cursor = Cursors.Hand;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerUsuarios.ForeColor = Color.White;
            btnVerUsuarios.Location = new Point(4, 5);
            btnVerUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(197, 52);
            btnVerUsuarios.TabIndex = 19;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = false;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // subMenuProductos
            // 
            subMenuProductos.Controls.Add(btnVerProductos);
            subMenuProductos.Controls.Add(btnAgregarProductos);
            subMenuProductos.Location = new Point(60, 593);
            subMenuProductos.Margin = new Padding(3, 4, 3, 4);
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Size = new Size(200, 120);
            subMenuProductos.TabIndex = 20;
            subMenuProductos.Visible = false;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = SystemColors.Desktop;
            btnVerProductos.Cursor = Cursors.Hand;
            btnVerProductos.FlatAppearance.BorderSize = 0;
            btnVerProductos.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerProductos.ForeColor = Color.White;
            btnVerProductos.Location = new Point(4, 5);
            btnVerProductos.Margin = new Padding(4, 5, 4, 5);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(197, 52);
            btnVerProductos.TabIndex = 19;
            btnVerProductos.Text = "Ver Productos";
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.BackColor = SystemColors.Desktop;
            btnAgregarProductos.Cursor = Cursors.Hand;
            btnAgregarProductos.FlatAppearance.BorderSize = 0;
            btnAgregarProductos.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnAgregarProductos.FlatStyle = FlatStyle.Flat;
            btnAgregarProductos.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProductos.ForeColor = Color.White;
            btnAgregarProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProductos.Location = new Point(4, 67);
            btnAgregarProductos.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.RightToLeft = RightToLeft.No;
            btnAgregarProductos.Size = new Size(197, 52);
            btnAgregarProductos.TabIndex = 18;
            btnAgregarProductos.Text = "Agregar Productos";
            btnAgregarProductos.UseVisualStyleBackColor = false;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // subMenuReservas
            // 
            subMenuReservas.Controls.Add(btnVerReservas);
            subMenuReservas.Location = new Point(61, 406);
            subMenuReservas.Margin = new Padding(3, 4, 3, 4);
            subMenuReservas.Name = "subMenuReservas";
            subMenuReservas.Size = new Size(200, 59);
            subMenuReservas.TabIndex = 20;
            subMenuReservas.Visible = false;
            // 
            // btnVerReservas
            // 
            btnVerReservas.BackColor = SystemColors.Desktop;
            btnVerReservas.Cursor = Cursors.Hand;
            btnVerReservas.FlatAppearance.BorderSize = 0;
            btnVerReservas.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnVerReservas.FlatStyle = FlatStyle.Flat;
            btnVerReservas.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerReservas.ForeColor = Color.White;
            btnVerReservas.Location = new Point(4, 5);
            btnVerReservas.Margin = new Padding(4, 5, 4, 5);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(197, 52);
            btnVerReservas.TabIndex = 19;
            btnVerReservas.Text = "Ver Reservas";
            btnVerReservas.UseVisualStyleBackColor = false;
            btnVerReservas.Click += btnVerReservas_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(16, 661);
            pictureBox8.Margin = new Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 52);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(16, 600);
            pictureBox7.Margin = new Padding(4, 5, 4, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 52);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 539);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(16, 478);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 415);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 354);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.Desktop;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(60, 539);
            btnProductos.Margin = new Padding(4, 5, 4, 5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(201, 52);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = SystemColors.Desktop;
            btnServicios.Cursor = Cursors.Hand;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnServicios.ForeColor = Color.White;
            btnServicios.Location = new Point(60, 600);
            btnServicios.Margin = new Padding(4, 5, 4, 5);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(201, 52);
            btnServicios.TabIndex = 7;
            btnServicios.Text = "Servicios";
            btnServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnServicios.UseVisualStyleBackColor = false;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnInventarios
            // 
            btnInventarios.BackColor = SystemColors.Desktop;
            btnInventarios.Cursor = Cursors.Hand;
            btnInventarios.FlatAppearance.BorderSize = 0;
            btnInventarios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnInventarios.FlatStyle = FlatStyle.Flat;
            btnInventarios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventarios.ForeColor = Color.White;
            btnInventarios.Location = new Point(60, 478);
            btnInventarios.Margin = new Padding(4, 5, 4, 5);
            btnInventarios.Name = "btnInventarios";
            btnInventarios.Size = new Size(201, 52);
            btnInventarios.TabIndex = 5;
            btnInventarios.Text = "Inventarios";
            btnInventarios.TextAlign = ContentAlignment.MiddleLeft;
            btnInventarios.UseVisualStyleBackColor = false;
            btnInventarios.Click += btnInventarios_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = SystemColors.Desktop;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(60, 661);
            btnProveedores.Margin = new Padding(4, 5, 4, 5);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(201, 52);
            btnProveedores.TabIndex = 8;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = SystemColors.Desktop;
            btnReservas.Cursor = Cursors.Hand;
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservas.ForeColor = Color.White;
            btnReservas.Location = new Point(60, 354);
            btnReservas.Margin = new Padding(4, 5, 4, 5);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(201, 52);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "Reservas";
            btnReservas.TextAlign = ContentAlignment.MiddleLeft;
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.Desktop;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(60, 415);
            btnUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(201, 52);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 292);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.BackColor = SystemColors.Desktop;
            btnDepartamentos.Cursor = Cursors.Hand;
            btnDepartamentos.FlatAppearance.BorderSize = 0;
            btnDepartamentos.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnDepartamentos.FlatStyle = FlatStyle.Flat;
            btnDepartamentos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartamentos.ForeColor = Color.White;
            btnDepartamentos.Location = new Point(60, 292);
            btnDepartamentos.Margin = new Padding(4, 5, 4, 5);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(201, 52);
            btnDepartamentos.TabIndex = 2;
            btnDepartamentos.Text = "Departamentos";
            btnDepartamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartamentos.UseVisualStyleBackColor = false;
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // logoTurismoReal
            // 
            logoTurismoReal.Image = (Image)resources.GetObject("logoTurismoReal.Image");
            logoTurismoReal.Location = new Point(0, 0);
            logoTurismoReal.Margin = new Padding(4, 5, 4, 5);
            logoTurismoReal.Name = "logoTurismoReal";
            logoTurismoReal.Size = new Size(269, 220);
            logoTurismoReal.SizeMode = PictureBoxSizeMode.Zoom;
            logoTurismoReal.TabIndex = 0;
            logoTurismoReal.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Window;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(269, 61);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1031, 1065);
            panelContenedor.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 1126);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            MenuVertical.ResumeLayout(false);
            subMenuProveedores.ResumeLayout(false);
            subMenuMultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            subMenuServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            subMenuChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            subMenuDepartamentos.ResumeLayout(false);
            subMenuInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            subMenuUsuarios.ResumeLayout(false);
            subMenuProductos.ResumeLayout(false);
            subMenuReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoTurismoReal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox logoTurismoReal;
        private Button btnDepartamentos;
        private Button btnUsuarios;
        private Button btnReservas;
        private Button btnProveedores;
        private Button btnServicios;
        private Button btnInventarios;
        private Button btnProductos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Button btnCerrar;
        private Button btnRestaurar;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private PictureBox pictureBox9;
        private FlowLayoutPanel subMenuInventario;
        private Button btnAddInventario;
        private Button btnVerInventario;
        private FlowLayoutPanel subMenuReservas;
        private Button btnVerReservas;
        private FlowLayoutPanel subMenuProductos;
        private Button btnVerProductos;
        private Button btnAgregarProductos;
        private FlowLayoutPanel subMenuServicios;
        private Button btnVerServicios;
        private Button btnAgregarServicios;
        private FlowLayoutPanel subMenuDepartamentos;
        private Button btnVerDepartamento;
        private Button btnAgregarDepartamento;
        private FlowLayoutPanel subMenuUsuarios;
        private Button btnVerUsuarios;
        private FlowLayoutPanel subMenuProveedores;
        private Button btnVerProveedores;
        private Button btnAgregarProveedores;
        private PictureBox pictureBox10;
        private Button btnChecks;
        private FlowLayoutPanel subMenuChecks;
        private Button btnVerCheckIn;
        private Button btnVerCheckOut;
        private PictureBox btnLogOut;
        private PictureBox pictureBox11;
        private FlowLayoutPanel subMenuMultas;
        private Button btnGestionarMultas;
        private Button btnMultas;
    }
}