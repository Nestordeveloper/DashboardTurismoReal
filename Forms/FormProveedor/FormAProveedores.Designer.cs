namespace DashboardTurismoReal.FormProveedor
{
    partial class FormAProveedores
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
            tituloAProveedor = new Label();
            txtRutEmpresa = new TextBox();
            txtNombreEmpresa = new TextBox();
            txtDireccionEmpresa = new TextBox();
            comboBoxComuna = new ComboBox();
            labelRutEmpresa = new Label();
            labelNombreEmpresa = new Label();
            labelDireccionEmpresa = new Label();
            labelCboxComuna = new Label();
            btnCrearProveedor = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tituloAProveedor
            // 
            tituloAProveedor.AutoSize = true;
            tituloAProveedor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAProveedor.Location = new Point(371, 63);
            tituloAProveedor.Name = "tituloAProveedor";
            tituloAProveedor.Size = new Size(221, 20);
            tituloAProveedor.TabIndex = 4;
            tituloAProveedor.Text = "AGREGAR PROVEEDOR";
            tituloAProveedor.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtRutEmpresa
            // 
            txtRutEmpresa.Location = new Point(371, 160);
            txtRutEmpresa.Name = "txtRutEmpresa";
            txtRutEmpresa.Size = new Size(221, 27);
            txtRutEmpresa.TabIndex = 5;
            txtRutEmpresa.KeyDown += txtRutEmpresa_KeyDown;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(371, 241);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(221, 27);
            txtNombreEmpresa.TabIndex = 6;
            // 
            // txtDireccionEmpresa
            // 
            txtDireccionEmpresa.Location = new Point(371, 322);
            txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            txtDireccionEmpresa.Size = new Size(221, 27);
            txtDireccionEmpresa.TabIndex = 7;
            // 
            // comboBoxComuna
            // 
            comboBoxComuna.FormattingEnabled = true;
            comboBoxComuna.Location = new Point(371, 402);
            comboBoxComuna.Name = "comboBoxComuna";
            comboBoxComuna.Size = new Size(221, 28);
            comboBoxComuna.TabIndex = 8;
            comboBoxComuna.DropDown += comboBoxComuna_DropDown;
            // 
            // labelRutEmpresa
            // 
            labelRutEmpresa.AutoSize = true;
            labelRutEmpresa.Location = new Point(211, 163);
            labelRutEmpresa.Name = "labelRutEmpresa";
            labelRutEmpresa.Size = new Size(92, 20);
            labelRutEmpresa.TabIndex = 9;
            labelRutEmpresa.Text = "Rut Empresa";
            // 
            // labelNombreEmpresa
            // 
            labelNombreEmpresa.AutoSize = true;
            labelNombreEmpresa.Location = new Point(211, 244);
            labelNombreEmpresa.Name = "labelNombreEmpresa";
            labelNombreEmpresa.Size = new Size(125, 20);
            labelNombreEmpresa.TabIndex = 10;
            labelNombreEmpresa.Text = "Nombre Empresa";
            // 
            // labelDireccionEmpresa
            // 
            labelDireccionEmpresa.AutoSize = true;
            labelDireccionEmpresa.Location = new Point(211, 325);
            labelDireccionEmpresa.Name = "labelDireccionEmpresa";
            labelDireccionEmpresa.Size = new Size(133, 20);
            labelDireccionEmpresa.TabIndex = 11;
            labelDireccionEmpresa.Text = "Dirección Empresa";
            // 
            // labelCboxComuna
            // 
            labelCboxComuna.AutoSize = true;
            labelCboxComuna.Location = new Point(211, 405);
            labelCboxComuna.Name = "labelCboxComuna";
            labelCboxComuna.Size = new Size(125, 20);
            labelCboxComuna.TabIndex = 12;
            labelCboxComuna.Text = "Comuna Empresa";
            // 
            // btnCrearProveedor
            // 
            btnCrearProveedor.Location = new Point(402, 488);
            btnCrearProveedor.Name = "btnCrearProveedor";
            btnCrearProveedor.Size = new Size(160, 29);
            btnCrearProveedor.TabIndex = 13;
            btnCrearProveedor.Text = "Crear Proveedor";
            btnCrearProveedor.UseVisualStyleBackColor = true;
            btnCrearProveedor.Click += btnCrearProveedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(598, 166);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 14;
            label1.Text = "(ej: 12345678-9)";
            // 
            // FormAProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 627);
            Controls.Add(label1);
            Controls.Add(btnCrearProveedor);
            Controls.Add(labelCboxComuna);
            Controls.Add(labelDireccionEmpresa);
            Controls.Add(labelNombreEmpresa);
            Controls.Add(labelRutEmpresa);
            Controls.Add(comboBoxComuna);
            Controls.Add(txtDireccionEmpresa);
            Controls.Add(txtNombreEmpresa);
            Controls.Add(txtRutEmpresa);
            Controls.Add(tituloAProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAProveedores";
            Text = "FormAProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloAProveedor;
        private TextBox txtRutEmpresa;
        private TextBox txtNombreEmpresa;
        private TextBox txtDireccionEmpresa;
        private ComboBox comboBoxComuna;
        private Label labelRutEmpresa;
        private Label labelNombreEmpresa;
        private Label labelDireccionEmpresa;
        private Label labelCboxComuna;
        private Button btnCrearProveedor;
        private Label label1;
    }
}