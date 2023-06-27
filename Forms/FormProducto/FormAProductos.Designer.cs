namespace DashboardTurismoReal.FormProducto
{
    partial class FormAProductos
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
            tituloAProd = new Label();
            comboBoxInventario = new ComboBox();
            comboBoxCategoria = new ComboBox();
            labelCodInventario = new Label();
            label2 = new Label();
            labelProductName = new Label();
            txtNombreProducto = new TextBox();
            btnCrearProducto = new Button();
            SuspendLayout();
            // 
            // tituloAProd
            // 
            tituloAProd.AutoSize = true;
            tituloAProd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAProd.Location = new Point(382, 66);
            tituloAProd.Name = "tituloAProd";
            tituloAProd.Size = new Size(209, 20);
            tituloAProd.TabIndex = 3;
            tituloAProd.Text = "AGREGAR PRODUCTO";
            tituloAProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(382, 167);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(209, 28);
            comboBoxInventario.TabIndex = 4;
            comboBoxInventario.DropDown += comboBoxInventario_DropDown;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(382, 251);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(209, 28);
            comboBoxCategoria.TabIndex = 5;
            comboBoxCategoria.DropDown += comboBoxCategoria_DropDown;
            // 
            // labelCodInventario
            // 
            labelCodInventario.AutoSize = true;
            labelCodInventario.Location = new Point(199, 170);
            labelCodInventario.Name = "labelCodInventario";
            labelCodInventario.Size = new Size(149, 20);
            labelCodInventario.TabIndex = 6;
            labelCodInventario.Text = "Código de Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 254);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 7;
            label2.Text = "Categoría del Producto";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(199, 335);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(153, 20);
            labelProductName.TabIndex = 8;
            labelProductName.Text = "Nombre del Producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(382, 332);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(209, 27);
            txtNombreProducto.TabIndex = 9;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(408, 437);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(149, 29);
            btnCrearProducto.TabIndex = 10;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // FormAProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 627);
            Controls.Add(btnCrearProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(labelProductName);
            Controls.Add(label2);
            Controls.Add(labelCodInventario);
            Controls.Add(comboBoxCategoria);
            Controls.Add(comboBoxInventario);
            Controls.Add(tituloAProd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAProductos";
            Text = "FormAProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloAProd;
        private ComboBox comboBoxInventario;
        private ComboBox comboBoxCategoria;
        private Label labelCodInventario;
        private Label label2;
        private Label labelProductName;
        private TextBox txtNombreProducto;
        private Button btnCrearProducto;
    }
}