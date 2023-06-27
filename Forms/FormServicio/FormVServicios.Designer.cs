namespace DashboardTurismoReal.FormServicio
{
    partial class FormVServicios
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
            tituloVServicios = new Label();
            dataGridViewServicios = new DataGridView();
            btnCargarDatos = new Button();
            panelDptoUpdate = new Panel();
            btnEliminarServicio = new Button();
            label1 = new Label();
            comboBoxServicio = new ComboBox();
            labelServicioDelete = new Label();
            panel1 = new Panel();
            comboBoxDptoServicio = new ComboBox();
            label4 = new Label();
            btnAsignarServicio = new Button();
            label2 = new Label();
            comboBoxDpto = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).BeginInit();
            panelDptoUpdate.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVServicios
            // 
            tituloVServicios.AutoSize = true;
            tituloVServicios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVServicios.Location = new Point(484, 60);
            tituloVServicios.Name = "tituloVServicios";
            tituloVServicios.Size = new Size(107, 20);
            tituloVServicios.TabIndex = 6;
            tituloVServicios.Text = "SERVICIOS";
            tituloVServicios.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewServicios
            // 
            dataGridViewServicios.AllowUserToAddRows = false;
            dataGridViewServicios.AllowUserToDeleteRows = false;
            dataGridViewServicios.AllowUserToOrderColumns = true;
            dataGridViewServicios.AllowUserToResizeRows = false;
            dataGridViewServicios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicios.BackgroundColor = SystemColors.Control;
            dataGridViewServicios.BorderStyle = BorderStyle.None;
            dataGridViewServicios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicios.GridColor = Color.DarkGoldenrod;
            dataGridViewServicios.Location = new Point(68, 124);
            dataGridViewServicios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServicios.Name = "dataGridViewServicios";
            dataGridViewServicios.RowHeadersVisible = false;
            dataGridViewServicios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewServicios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewServicios.RowTemplate.Height = 24;
            dataGridViewServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServicios.Size = new Size(946, 356);
            dataGridViewServicios.TabIndex = 7;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(907, 56);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(107, 29);
            btnCargarDatos.TabIndex = 8;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // panelDptoUpdate
            // 
            panelDptoUpdate.AutoSize = true;
            panelDptoUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelDptoUpdate.Controls.Add(btnEliminarServicio);
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(comboBoxServicio);
            panelDptoUpdate.Controls.Add(labelServicioDelete);
            panelDptoUpdate.Location = new Point(68, 505);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(474, 200);
            panelDptoUpdate.TabIndex = 9;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.Location = new Point(178, 153);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(139, 29);
            btnEliminarServicio.TabIndex = 11;
            btnEliminarServicio.Text = "Eliminar Servicio";
            btnEliminarServicio.UseVisualStyleBackColor = true;
            btnEliminarServicio.Click += btnEliminarServicio_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 9;
            label1.Text = "Eliminar Servicio";
            // 
            // comboBoxServicio
            // 
            comboBoxServicio.Anchor = AnchorStyles.Left;
            comboBoxServicio.FormattingEnabled = true;
            comboBoxServicio.Location = new Point(270, 89);
            comboBoxServicio.Name = "comboBoxServicio";
            comboBoxServicio.Size = new Size(151, 28);
            comboBoxServicio.TabIndex = 8;
            comboBoxServicio.DropDown += comboBoxServicio_DropDown;
            // 
            // labelServicioDelete
            // 
            labelServicioDelete.Anchor = AnchorStyles.Left;
            labelServicioDelete.AutoSize = true;
            labelServicioDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelServicioDelete.Location = new Point(73, 92);
            labelServicioDelete.Name = "labelServicioDelete";
            labelServicioDelete.Size = new Size(150, 20);
            labelServicioDelete.TabIndex = 7;
            labelServicioDelete.Text = "Seleccionar Servicio:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBoxDptoServicio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAsignarServicio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxDpto);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(561, 505);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 260);
            panel1.TabIndex = 10;
            // 
            // comboBoxDptoServicio
            // 
            comboBoxDptoServicio.Anchor = AnchorStyles.Left;
            comboBoxDptoServicio.FormattingEnabled = true;
            comboBoxDptoServicio.Location = new Point(246, 154);
            comboBoxDptoServicio.Name = "comboBoxDptoServicio";
            comboBoxDptoServicio.Size = new Size(177, 28);
            comboBoxDptoServicio.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 157);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 11;
            label4.Text = "Seleccionar Servicio:";
            // 
            // btnAsignarServicio
            // 
            btnAsignarServicio.Location = new Point(168, 211);
            btnAsignarServicio.Name = "btnAsignarServicio";
            btnAsignarServicio.Size = new Size(139, 29);
            btnAsignarServicio.TabIndex = 10;
            btnAsignarServicio.Text = "Asignar Servicio";
            btnAsignarServicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(375, 32);
            label2.TabIndex = 9;
            label2.Text = "Asignar Servicio a Departamento";
            // 
            // comboBoxDpto
            // 
            comboBoxDpto.Anchor = AnchorStyles.Left;
            comboBoxDpto.FormattingEnabled = true;
            comboBoxDpto.Location = new Point(246, 85);
            comboBoxDpto.Name = "comboBoxDpto";
            comboBoxDpto.Size = new Size(177, 28);
            comboBoxDpto.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 88);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 7;
            label3.Text = "Seleccionar Departamento:";
            // 
            // FormVServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 801);
            Controls.Add(panel1);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewServicios);
            Controls.Add(tituloVServicios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVServicios";
            Text = "FormVServicios";
            Load += FormVServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicios).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVServicios;
        private DataGridView dataGridViewServicios;
        private Button btnCargarDatos;
        private Panel panelDptoUpdate;
        private Label label1;
        private ComboBox comboBoxServicio;
        private Label labelServicioDelete;
        private Button btnEliminarServicio;
        private Panel panel1;
        private ComboBox comboBoxDptoServicio;
        private Label label4;
        private Button btnAsignarServicio;
        private Label label2;
        private ComboBox comboBoxDpto;
        private Label label3;
    }
}