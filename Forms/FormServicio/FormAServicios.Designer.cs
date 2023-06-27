namespace DashboardTurismoReal.FormServicio
{
    partial class FormAServicios
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
            tituloAServicios = new Label();
            txtNombreServicio = new TextBox();
            comboBoxTipoServicio = new ComboBox();
            comboBoxProveedor = new ComboBox();
            txtValorServicio = new TextBox();
            comboBoxComuna = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCrearServicio = new Button();
            label6 = new Label();
            label7 = new Label();
            comboBoxRegion = new ComboBox();
            comboBoxProvincia = new ComboBox();
            SuspendLayout();
            // 
            // tituloAServicios
            // 
            tituloAServicios.AutoSize = true;
            tituloAServicios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAServicios.Location = new Point(427, 62);
            tituloAServicios.Name = "tituloAServicios";
            tituloAServicios.Size = new Size(203, 20);
            tituloAServicios.TabIndex = 5;
            tituloAServicios.Text = "AGREGAR SERVICIOS";
            tituloAServicios.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(427, 134);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(203, 27);
            txtNombreServicio.TabIndex = 6;
            // 
            // comboBoxTipoServicio
            // 
            comboBoxTipoServicio.FormattingEnabled = true;
            comboBoxTipoServicio.Location = new Point(427, 200);
            comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            comboBoxTipoServicio.Size = new Size(203, 28);
            comboBoxTipoServicio.TabIndex = 7;
            comboBoxTipoServicio.DropDown += comboBoxTipoServicio_DropDown;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(427, 271);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(203, 28);
            comboBoxProveedor.TabIndex = 8;
            comboBoxProveedor.DropDown += comboBoxProveedor_DropDown;
            // 
            // txtValorServicio
            // 
            txtValorServicio.Location = new Point(427, 343);
            txtValorServicio.Name = "txtValorServicio";
            txtValorServicio.Size = new Size(203, 27);
            txtValorServicio.TabIndex = 9;
            // 
            // comboBoxComuna
            // 
            comboBoxComuna.FormattingEnabled = true;
            comboBoxComuna.Location = new Point(427, 585);
            comboBoxComuna.Name = "comboBoxComuna";
            comboBoxComuna.Size = new Size(203, 28);
            comboBoxComuna.TabIndex = 10;
            comboBoxComuna.DropDown += comboBoxComuna_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 137);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 11;
            label1.Text = "Nombre del Servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 203);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 12;
            label2.Text = "Tipo de Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 13;
            label3.Text = "Rut de Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 346);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 14;
            label4.Text = "Valor del Servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 588);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 15;
            label5.Text = "Comuna del Servicio";
            // 
            // btnCrearServicio
            // 
            btnCrearServicio.Location = new Point(441, 642);
            btnCrearServicio.Name = "btnCrearServicio";
            btnCrearServicio.Size = new Size(170, 29);
            btnCrearServicio.TabIndex = 16;
            btnCrearServicio.Text = "Crear Servicio";
            btnCrearServicio.UseVisualStyleBackColor = true;
            btnCrearServicio.Click += btnCrearServicio_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 424);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 17;
            label6.Text = "Región del Servicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 503);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 18;
            label7.Text = "Provincia del Servicio";
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(427, 421);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(203, 28);
            comboBoxRegion.TabIndex = 19;
            comboBoxRegion.DropDown += comboBoxRegion_DropDown;
            comboBoxRegion.SelectedIndexChanged += comboBoxRegion_SelectedIndexChanged;
            // 
            // comboBoxProvincia
            // 
            comboBoxProvincia.FormattingEnabled = true;
            comboBoxProvincia.Location = new Point(427, 500);
            comboBoxProvincia.Name = "comboBoxProvincia";
            comboBoxProvincia.Size = new Size(203, 28);
            comboBoxProvincia.TabIndex = 20;
            comboBoxProvincia.DropDown += comboBoxProvincia_DropDown;
            comboBoxProvincia.SelectedIndexChanged += comboBoxProvincia_SelectedIndexChanged;
            // 
            // FormAServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 718);
            Controls.Add(comboBoxProvincia);
            Controls.Add(comboBoxRegion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCrearServicio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxComuna);
            Controls.Add(txtValorServicio);
            Controls.Add(comboBoxProveedor);
            Controls.Add(comboBoxTipoServicio);
            Controls.Add(txtNombreServicio);
            Controls.Add(tituloAServicios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAServicios";
            Text = "FormAServicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloAServicios;
        private TextBox txtNombreServicio;
        private ComboBox comboBoxTipoServicio;
        private ComboBox comboBoxProveedor;
        private TextBox txtValorServicio;
        private ComboBox comboBoxComuna;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCrearServicio;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxRegion;
        private ComboBox comboBoxProvincia;
    }
}