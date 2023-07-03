namespace DashboardTurismoReal.FormProveedor
{
    partial class FormVProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tituloVProveedor = new Label();
            dataGridViewProveedores = new DataGridView();
            btnCargarDatos = new Button();
            panelDptoUpdate = new Panel();
            btnEliminarProveedor = new Button();
            label1 = new Label();
            comboBoxProveedor = new ComboBox();
            labelProveedorDelete = new Label();
            label11 = new Label();
            txtFiltroProveedorRUT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            panelDptoUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVProveedor
            // 
            tituloVProveedor.AutoSize = true;
            tituloVProveedor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVProveedor.Location = new Point(463, 62);
            tituloVProveedor.Name = "tituloVProveedor";
            tituloVProveedor.Size = new Size(149, 20);
            tituloVProveedor.TabIndex = 5;
            tituloVProveedor.Text = "PROVEEDORES";
            tituloVProveedor.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AllowUserToAddRows = false;
            dataGridViewProveedores.AllowUserToDeleteRows = false;
            dataGridViewProveedores.AllowUserToOrderColumns = true;
            dataGridViewProveedores.AllowUserToResizeRows = false;
            dataGridViewProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProveedores.BackgroundColor = SystemColors.Control;
            dataGridViewProveedores.BorderStyle = BorderStyle.None;
            dataGridViewProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.GridColor = Color.DarkGoldenrod;
            dataGridViewProveedores.Location = new Point(55, 106);
            dataGridViewProveedores.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProveedores.RowHeadersVisible = false;
            dataGridViewProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewProveedores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProveedores.RowTemplate.Height = 24;
            dataGridViewProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProveedores.Size = new Size(989, 413);
            dataGridViewProveedores.TabIndex = 6;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(933, 58);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(111, 29);
            btnCargarDatos.TabIndex = 7;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // panelDptoUpdate
            // 
            panelDptoUpdate.AutoSize = true;
            panelDptoUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelDptoUpdate.Controls.Add(btnEliminarProveedor);
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(comboBoxProveedor);
            panelDptoUpdate.Controls.Add(labelProveedorDelete);
            panelDptoUpdate.Location = new Point(55, 547);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(627, 133);
            panelDptoUpdate.TabIndex = 8;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(433, 82);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(159, 29);
            btnEliminarProveedor.TabIndex = 11;
            btnEliminarProveedor.Text = "Eliminar Proveedor";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 14);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 9;
            label1.Text = "Eliminar Proveedor";
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.Anchor = AnchorStyles.Left;
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(203, 83);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(151, 28);
            comboBoxProveedor.TabIndex = 8;
            comboBoxProveedor.DropDown += comboBoxProveedor_DropDown;
            // 
            // labelProveedorDelete
            // 
            labelProveedorDelete.Anchor = AnchorStyles.Left;
            labelProveedorDelete.AutoSize = true;
            labelProveedorDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProveedorDelete.Location = new Point(29, 86);
            labelProveedorDelete.Name = "labelProveedorDelete";
            labelProveedorDelete.Size = new Size(168, 20);
            labelProveedorDelete.TabIndex = 7;
            labelProveedorDelete.Text = "Seleccionar Proveedor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(55, 47);
            label11.Name = "label11";
            label11.Size = new Size(194, 20);
            label11.TabIndex = 18;
            label11.Text = "Filtrar por RUT Proveedor:";
            // 
            // txtFiltroProveedorRUT
            // 
            txtFiltroProveedorRUT.Location = new Point(55, 70);
            txtFiltroProveedorRUT.Name = "txtFiltroProveedorRUT";
            txtFiltroProveedorRUT.Size = new Size(242, 27);
            txtFiltroProveedorRUT.TabIndex = 17;
            txtFiltroProveedorRUT.TextChanged += txtFiltroProveedorRUT_TextChanged;
            // 
            // FormVProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 726);
            Controls.Add(label11);
            Controls.Add(txtFiltroProveedorRUT);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(tituloVProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVProveedores";
            Text = "FormVProveedores";
            Load += FormVProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVProveedor;
        private DataGridView dataGridViewProveedores;
        private Button btnCargarDatos;
        private Panel panelDptoUpdate;
        private Label label1;
        private ComboBox comboBoxProveedor;
        private Label labelProveedorDelete;
        private Button btnEliminarProveedor;
        private Label label11;
        private TextBox txtFiltroProveedorRUT;
    }
}