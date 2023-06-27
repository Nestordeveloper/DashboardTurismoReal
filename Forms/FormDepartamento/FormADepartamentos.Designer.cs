namespace DashboardTurismoReal
{
    partial class FormADepartamentos
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
            tituloADpto = new Label();
            comboBoxComuna = new ComboBox();
            comboBoxRegion = new ComboBox();
            txtNombreDepartamento = new TextBox();
            txtDescripcion = new TextBox();
            txtValorDiario = new TextBox();
            btnCrearDepartamento = new Button();
            labelNameDpto = new Label();
            labelDescDpto = new Label();
            labelValueDpto = new Label();
            labelCommuneDpto = new Label();
            labelRegionDpto = new Label();
            label1 = new Label();
            comboBoxProvincia = new ComboBox();
            SuspendLayout();
            // 
            // tituloADpto
            // 
            tituloADpto.AutoSize = true;
            tituloADpto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloADpto.Location = new Point(386, 61);
            tituloADpto.Name = "tituloADpto";
            tituloADpto.Size = new Size(256, 20);
            tituloADpto.TabIndex = 0;
            tituloADpto.Text = "AGREGAR DEPARTAMENTO";
            tituloADpto.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxComuna
            // 
            comboBoxComuna.FormattingEnabled = true;
            comboBoxComuna.Location = new Point(397, 581);
            comboBoxComuna.Margin = new Padding(3, 4, 3, 4);
            comboBoxComuna.Name = "comboBoxComuna";
            comboBoxComuna.Size = new Size(241, 28);
            comboBoxComuna.TabIndex = 1;
            comboBoxComuna.DropDown += comboBoxComuna_DropDown;
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(397, 413);
            comboBoxRegion.Margin = new Padding(3, 4, 3, 4);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(242, 28);
            comboBoxRegion.TabIndex = 2;
            comboBoxRegion.DropDown += comboBoxRegion_DropDown;
            comboBoxRegion.SelectedIndexChanged += comboBoxRegion_SelectedIndexChanged;
            // 
            // txtNombreDepartamento
            // 
            txtNombreDepartamento.Location = new Point(397, 180);
            txtNombreDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtNombreDepartamento.Name = "txtNombreDepartamento";
            txtNombreDepartamento.Size = new Size(241, 27);
            txtNombreDepartamento.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(397, 255);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // txtValorDiario
            // 
            txtValorDiario.Location = new Point(397, 332);
            txtValorDiario.Margin = new Padding(3, 4, 3, 4);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.Size = new Size(241, 27);
            txtValorDiario.TabIndex = 5;
            txtValorDiario.KeyDown += txtValorDiario_KeyDown;
            // 
            // btnCrearDepartamento
            // 
            btnCrearDepartamento.Location = new Point(429, 680);
            btnCrearDepartamento.Margin = new Padding(3, 4, 3, 4);
            btnCrearDepartamento.Name = "btnCrearDepartamento";
            btnCrearDepartamento.Size = new Size(182, 29);
            btnCrearDepartamento.TabIndex = 6;
            btnCrearDepartamento.Text = "Crear Departamento";
            btnCrearDepartamento.UseVisualStyleBackColor = true;
            btnCrearDepartamento.Click += btnCrearDepartamento_Click;
            // 
            // labelNameDpto
            // 
            labelNameDpto.AutoSize = true;
            labelNameDpto.Location = new Point(157, 183);
            labelNameDpto.Name = "labelNameDpto";
            labelNameDpto.Size = new Size(168, 20);
            labelNameDpto.TabIndex = 7;
            labelNameDpto.Text = "Nombre Departamento:";
            // 
            // labelDescDpto
            // 
            labelDescDpto.AutoSize = true;
            labelDescDpto.Location = new Point(157, 258);
            labelDescDpto.Name = "labelDescDpto";
            labelDescDpto.Size = new Size(191, 20);
            labelDescDpto.TabIndex = 8;
            labelDescDpto.Text = "Descripcion Departamento:";
            // 
            // labelValueDpto
            // 
            labelValueDpto.AutoSize = true;
            labelValueDpto.Location = new Point(157, 335);
            labelValueDpto.Name = "labelValueDpto";
            labelValueDpto.Size = new Size(217, 20);
            labelValueDpto.TabIndex = 9;
            labelValueDpto.Text = "Valor Diario del Departamento:";
            // 
            // labelCommuneDpto
            // 
            labelCommuneDpto.AutoSize = true;
            labelCommuneDpto.Location = new Point(157, 584);
            labelCommuneDpto.Name = "labelCommuneDpto";
            labelCommuneDpto.Size = new Size(190, 20);
            labelCommuneDpto.TabIndex = 10;
            labelCommuneDpto.Text = "Comuna del Departamento";
            // 
            // labelRegionDpto
            // 
            labelRegionDpto.AutoSize = true;
            labelRegionDpto.Location = new Point(157, 416);
            labelRegionDpto.Name = "labelRegionDpto";
            labelRegionDpto.Size = new Size(182, 20);
            labelRegionDpto.TabIndex = 11;
            labelRegionDpto.Text = "Región del Departamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 498);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 12;
            label1.Text = "Provincia del Departamento";
            // 
            // comboBoxProvincia
            // 
            comboBoxProvincia.FormattingEnabled = true;
            comboBoxProvincia.Location = new Point(397, 495);
            comboBoxProvincia.Name = "comboBoxProvincia";
            comboBoxProvincia.Size = new Size(241, 28);
            comboBoxProvincia.TabIndex = 13;
            comboBoxProvincia.DropDown += comboBoxProvincia_DropDown;
            comboBoxProvincia.SelectedIndexChanged += comboBoxProvincia_SelectedIndexChanged;
            // 
            // FormADepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 752);
            Controls.Add(comboBoxProvincia);
            Controls.Add(label1);
            Controls.Add(labelRegionDpto);
            Controls.Add(labelCommuneDpto);
            Controls.Add(labelValueDpto);
            Controls.Add(labelDescDpto);
            Controls.Add(labelNameDpto);
            Controls.Add(btnCrearDepartamento);
            Controls.Add(txtValorDiario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreDepartamento);
            Controls.Add(comboBoxRegion);
            Controls.Add(comboBoxComuna);
            Controls.Add(tituloADpto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormADepartamentos";
            Text = "FormADepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloADpto;
        private ComboBox comboBoxComuna;
        private ComboBox comboBoxRegion;
        private TextBox txtNombreDepartamento;
        private TextBox txtDescripcion;
        private TextBox txtValorDiario;
        private Button btnCrearDepartamento;
        private Label labelNameDpto;
        private Label labelDescDpto;
        private Label labelValueDpto;
        private Label labelCommuneDpto;
        private Label labelRegionDpto;
        private Label label1;
        private ComboBox comboBoxProvincia;
    }
}