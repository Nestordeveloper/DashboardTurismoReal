namespace DashboardTurismoReal.FormInventario
{
    partial class FormAInventarios
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
            tituloAInv = new Label();
            comboBoxCodDpto = new ComboBox();
            label1 = new Label();
            btnAgregarInventario = new Button();
            SuspendLayout();
            // 
            // tituloAInv
            // 
            tituloAInv.AutoSize = true;
            tituloAInv.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAInv.Location = new Point(294, 60);
            tituloAInv.Name = "tituloAInv";
            tituloAInv.Size = new Size(215, 20);
            tituloAInv.TabIndex = 1;
            tituloAInv.Text = "AGREGAR INVENTARIO";
            tituloAInv.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxCodDpto
            // 
            comboBoxCodDpto.FormattingEnabled = true;
            comboBoxCodDpto.Location = new Point(294, 135);
            comboBoxCodDpto.Name = "comboBoxCodDpto";
            comboBoxCodDpto.Size = new Size(215, 28);
            comboBoxCodDpto.TabIndex = 2;
            comboBoxCodDpto.DropDown += comboBoxCodDpto_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 138);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 3;
            label1.Text = "Código de Departamento";
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Location = new Point(326, 240);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(153, 29);
            btnAgregarInventario.TabIndex = 4;
            btnAgregarInventario.Text = "Añadir Inventario";
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // FormAInventarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnAgregarInventario);
            Controls.Add(label1);
            Controls.Add(comboBoxCodDpto);
            Controls.Add(tituloAInv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAInventarios";
            Text = "FormAInventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloAInv;
        private ComboBox comboBoxCodDpto;
        private Label label1;
        private Button btnAgregarInventario;
    }
}