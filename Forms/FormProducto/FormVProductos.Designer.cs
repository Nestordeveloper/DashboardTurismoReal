namespace DashboardTurismoReal.FormProducto
{
    partial class FormVProductos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tituloVProd = new Label();
            dataGridViewProductos = new DataGridView();
            btnCargarDatos = new Button();
            panelDptoUpdate = new Panel();
            btnEliminarProducto = new Button();
            label1 = new Label();
            comboBoxProducto = new ComboBox();
            labelProductoDelete = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            panelDptoUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVProd
            // 
            tituloVProd.AutoSize = true;
            tituloVProd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVProd.Location = new Point(461, 58);
            tituloVProd.Name = "tituloVProd";
            tituloVProd.Size = new Size(125, 20);
            tituloVProd.TabIndex = 4;
            tituloVProd.Text = "PRODUCTOS";
            tituloVProd.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToOrderColumns = true;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.BackgroundColor = SystemColors.Control;
            dataGridViewProductos.BorderStyle = BorderStyle.None;
            dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.GridColor = Color.DarkGoldenrod;
            dataGridViewProductos.Location = new Point(61, 119);
            dataGridViewProductos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProductos.RowTemplate.Height = 24;
            dataGridViewProductos.Size = new Size(897, 349);
            dataGridViewProductos.TabIndex = 5;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(854, 54);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(104, 29);
            btnCargarDatos.TabIndex = 6;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // panelDptoUpdate
            // 
            panelDptoUpdate.AutoSize = true;
            panelDptoUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelDptoUpdate.Controls.Add(btnEliminarProducto);
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(comboBoxProducto);
            panelDptoUpdate.Controls.Add(labelProductoDelete);
            panelDptoUpdate.Location = new Point(61, 491);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(427, 203);
            panelDptoUpdate.TabIndex = 7;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(156, 155);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(139, 29);
            btnEliminarProducto.TabIndex = 10;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 9;
            label1.Text = "Eliminar Producto";
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.Anchor = AnchorStyles.Left;
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(221, 102);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(177, 28);
            comboBoxProducto.TabIndex = 8;
            comboBoxProducto.DropDown += comboBoxProducto_DropDown;
            // 
            // labelProductoDelete
            // 
            labelProductoDelete.Anchor = AnchorStyles.Left;
            labelProductoDelete.AutoSize = true;
            labelProductoDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductoDelete.Location = new Point(44, 105);
            labelProductoDelete.Name = "labelProductoDelete";
            labelProductoDelete.Size = new Size(158, 20);
            labelProductoDelete.TabIndex = 7;
            labelProductoDelete.Text = "Seleccionar Producto:";
            // 
            // FormVProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 823);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewProductos);
            Controls.Add(tituloVProd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVProductos";
            Text = "FormVProductos";
            Load += FormVProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVProd;
        private DataGridView dataGridViewProductos;
        private Button btnCargarDatos;
        private Panel panelDptoUpdate;
        private Label label1;
        private ComboBox comboBoxProducto;
        private Label labelProductoDelete;
        private Button btnEliminarProducto;
    }
}