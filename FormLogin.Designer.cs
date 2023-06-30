namespace DashboardTurismoReal
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            BarraTitulo = new Panel();
            btnMaximizarLog = new Button();
            btnRestaurarLog = new Button();
            pictureBox9 = new PictureBox();
            btnMinimizarLog = new Button();
            btnCerrarLog = new Button();
            panelContenedor = new Panel();
            labelPassword = new Label();
            labelEmail = new Label();
            btnLogin = new Button();
            txtContrasena = new TextBox();
            txtCorreoElectronico = new TextBox();
            pictureBoxWPLogin = new PictureBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWPLogin).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = SystemColors.Desktop;
            BarraTitulo.Controls.Add(btnMaximizarLog);
            BarraTitulo.Controls.Add(btnRestaurarLog);
            BarraTitulo.Controls.Add(pictureBox9);
            BarraTitulo.Controls.Add(btnMinimizarLog);
            BarraTitulo.Controls.Add(btnCerrarLog);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(3, 2, 3, 2);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(895, 61);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            // 
            // btnMaximizarLog
            // 
            btnMaximizarLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizarLog.Enabled = false;
            btnMaximizarLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizarLog.FlatStyle = FlatStyle.Flat;
            btnMaximizarLog.Image = (Image)resources.GetObject("btnMaximizarLog.Image");
            btnMaximizarLog.Location = new Point(764, 0);
            btnMaximizarLog.Margin = new Padding(4, 5, 4, 5);
            btnMaximizarLog.Name = "btnMaximizarLog";
            btnMaximizarLog.Size = new Size(63, 61);
            btnMaximizarLog.TabIndex = 2;
            btnMaximizarLog.UseVisualStyleBackColor = true;
            btnMaximizarLog.Click += btnMaximizarLog_Click;
            // 
            // btnRestaurarLog
            // 
            btnRestaurarLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurarLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurarLog.FlatStyle = FlatStyle.Flat;
            btnRestaurarLog.Image = (Image)resources.GetObject("btnRestaurarLog.Image");
            btnRestaurarLog.Location = new Point(764, 0);
            btnRestaurarLog.Margin = new Padding(4, 5, 4, 5);
            btnRestaurarLog.Name = "btnRestaurarLog";
            btnRestaurarLog.Size = new Size(63, 58);
            btnRestaurarLog.TabIndex = 7;
            btnRestaurarLog.UseVisualStyleBackColor = true;
            btnRestaurarLog.Visible = false;
            btnRestaurarLog.Click += btnRestaurarLog_Click;
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
            // btnMinimizarLog
            // 
            btnMinimizarLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizarLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMinimizarLog.FlatStyle = FlatStyle.Flat;
            btnMinimizarLog.Image = (Image)resources.GetObject("btnMinimizarLog.Image");
            btnMinimizarLog.Location = new Point(693, 0);
            btnMinimizarLog.Margin = new Padding(4, 5, 4, 5);
            btnMinimizarLog.Name = "btnMinimizarLog";
            btnMinimizarLog.Size = new Size(63, 61);
            btnMinimizarLog.TabIndex = 5;
            btnMinimizarLog.UseVisualStyleBackColor = true;
            btnMinimizarLog.Click += btnMinimizarLog_Click;
            // 
            // btnCerrarLog
            // 
            btnCerrarLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarLog.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrarLog.FlatStyle = FlatStyle.Flat;
            btnCerrarLog.Image = (Image)resources.GetObject("btnCerrarLog.Image");
            btnCerrarLog.Location = new Point(834, 0);
            btnCerrarLog.Margin = new Padding(4, 5, 4, 5);
            btnCerrarLog.Name = "btnCerrarLog";
            btnCerrarLog.Size = new Size(63, 61);
            btnCerrarLog.TabIndex = 4;
            btnCerrarLog.UseVisualStyleBackColor = true;
            btnCerrarLog.Click += btnCerrarLog_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.Window;
            panelContenedor.Controls.Add(labelPassword);
            panelContenedor.Controls.Add(labelEmail);
            panelContenedor.Controls.Add(btnLogin);
            panelContenedor.Controls.Add(txtContrasena);
            panelContenedor.Controls.Add(txtCorreoElectronico);
            panelContenedor.Controls.Add(pictureBoxWPLogin);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 61);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(895, 487);
            panelContenedor.TabIndex = 6;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Transparent;
            labelPassword.Location = new Point(429, 288);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(88, 20);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Contraseña";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Transparent;
            labelEmail.Location = new Point(403, 220);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(137, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Correo Electrónico";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(406, 373);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasena.Location = new Point(368, 311);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(207, 27);
            txtContrasena.TabIndex = 2;
            txtContrasena.TextAlign = HorizontalAlignment.Center;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            txtContrasena.Enter += txtContrasena_Enter;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreoElectronico.Location = new Point(368, 243);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(207, 27);
            txtCorreoElectronico.TabIndex = 1;
            txtCorreoElectronico.TextAlign = HorizontalAlignment.Center;
            txtCorreoElectronico.Enter += txtCorreoElectronico_Enter;
            txtCorreoElectronico.Leave += txtCorreoElectronico_Leave;
            // 
            // pictureBoxWPLogin
            // 
            pictureBoxWPLogin.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxWPLogin.Dock = DockStyle.Fill;
            pictureBoxWPLogin.Image = (Image)resources.GetObject("pictureBoxWPLogin.Image");
            pictureBoxWPLogin.Location = new Point(0, 0);
            pictureBoxWPLogin.Name = "pictureBoxWPLogin";
            pictureBoxWPLogin.Size = new Size(895, 487);
            pictureBoxWPLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWPLogin.TabIndex = 0;
            pictureBoxWPLogin.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 548);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "FormLogin";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWPLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox pictureBox9;
        private Button btnRestaurarLog;
        private Button btnMinimizarLog;
        private Button btnCerrarLog;
        private Panel panelContenedor;
        private Button btnMaximizarLog;
        private PictureBox pictureBoxWPLogin;
        private TextBox txtContrasena;
        private TextBox txtCorreoElectronico;
        private Button btnLogin;
        private Label labelEmail;
        private Label labelPassword;
    }
}