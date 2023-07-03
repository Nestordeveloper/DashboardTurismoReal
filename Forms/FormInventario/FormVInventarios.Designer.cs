namespace DashboardTurismoReal.FormInventario
{
    partial class FormVInventarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tituloVInv = new Label();
            dataGridViewInventarios = new DataGridView();
            btnCargarDatos = new Button();
            btnAgregarInventario = new Button();
            label1 = new Label();
            comboBoxCodDpto = new ComboBox();
            tituloAInv = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVInv
            // 
            tituloVInv.AutoSize = true;
            tituloVInv.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVInv.Location = new Point(491, 59);
            tituloVInv.Name = "tituloVInv";
            tituloVInv.Size = new Size(131, 20);
            tituloVInv.TabIndex = 2;
            tituloVInv.Text = "INVENTARIOS";
            tituloVInv.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewInventarios
            // 
            dataGridViewInventarios.AllowUserToAddRows = false;
            dataGridViewInventarios.AllowUserToDeleteRows = false;
            dataGridViewInventarios.AllowUserToOrderColumns = true;
            dataGridViewInventarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInventarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventarios.BackgroundColor = SystemColors.Control;
            dataGridViewInventarios.BorderStyle = BorderStyle.None;
            dataGridViewInventarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewInventarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInventarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventarios.GridColor = Color.DarkGoldenrod;
            dataGridViewInventarios.Location = new Point(82, 108);
            dataGridViewInventarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInventarios.Name = "dataGridViewInventarios";
            dataGridViewInventarios.RowHeadersVisible = false;
            dataGridViewInventarios.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewInventarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInventarios.RowTemplate.Height = 24;
            dataGridViewInventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventarios.Size = new Size(940, 244);
            dataGridViewInventarios.TabIndex = 3;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(907, 55);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(115, 29);
            btnCargarDatos.TabIndex = 4;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Location = new Point(216, 218);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(153, 29);
            btnAgregarInventario.TabIndex = 8;
            btnAgregarInventario.Text = "Añadir Inventario";
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 119);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 7;
            label1.Text = "Código de Departamento:";
            // 
            // comboBoxCodDpto
            // 
            comboBoxCodDpto.FormattingEnabled = true;
            comboBoxCodDpto.Location = new Point(285, 116);
            comboBoxCodDpto.Name = "comboBoxCodDpto";
            comboBoxCodDpto.Size = new Size(215, 28);
            comboBoxCodDpto.TabIndex = 6;
            comboBoxCodDpto.DropDown += comboBoxCodDpto_DropDown;
            // 
            // tituloAInv
            // 
            tituloAInv.AutoSize = true;
            tituloAInv.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloAInv.Location = new Point(180, 26);
            tituloAInv.Name = "tituloAInv";
            tituloAInv.Size = new Size(215, 20);
            tituloAInv.TabIndex = 5;
            tituloAInv.Text = "AGREGAR INVENTARIO";
            tituloAInv.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tituloAInv);
            panel1.Controls.Add(btnAgregarInventario);
            panel1.Controls.Add(comboBoxCodDpto);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(263, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 286);
            panel1.TabIndex = 9;
            // 
            // FormVInventarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 736);
            Controls.Add(panel1);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewInventarios);
            Controls.Add(tituloVInv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVInventarios";
            Text = "FormVInventario";
            Load += FormVInventarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVInv;
        private DataGridView dataGridViewInventarios;
        private Button btnCargarDatos;
        private Button btnAgregarInventario;
        private Label label1;
        private ComboBox comboBoxCodDpto;
        private Label tituloAInv;
        private Panel panel1;
    }
}