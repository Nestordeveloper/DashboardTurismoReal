namespace DashboardTurismoReal.FormReserva
{
    partial class FormVReservas
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tituloVReservas = new Label();
            dataGridViewReservas = new DataGridView();
            btnCargarDatos = new Button();
            panelDptoUpdate = new Panel();
            comboBoxRol = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxRut = new ComboBox();
            labelDptoUpdate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            panelDptoUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVReservas
            // 
            tituloVReservas.AutoSize = true;
            tituloVReservas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVReservas.Location = new Point(476, 64);
            tituloVReservas.Name = "tituloVReservas";
            tituloVReservas.Size = new Size(107, 20);
            tituloVReservas.TabIndex = 5;
            tituloVReservas.Text = "RESERVAS";
            tituloVReservas.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.AllowUserToDeleteRows = false;
            dataGridViewReservas.AllowUserToOrderColumns = true;
            dataGridViewReservas.AllowUserToResizeRows = false;
            dataGridViewReservas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservas.BackgroundColor = SystemColors.Control;
            dataGridViewReservas.BorderStyle = BorderStyle.None;
            dataGridViewReservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.GridColor = Color.DarkGoldenrod;
            dataGridViewReservas.Location = new Point(67, 112);
            dataGridViewReservas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.RowHeadersVisible = false;
            dataGridViewReservas.RowHeadersWidth = 51;
            dataGridViewReservas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewReservas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewReservas.RowTemplate.Height = 24;
            dataGridViewReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservas.Size = new Size(969, 385);
            dataGridViewReservas.TabIndex = 6;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(925, 60);
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
            panelDptoUpdate.Controls.Add(comboBoxRol);
            panelDptoUpdate.Controls.Add(label2);
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(comboBoxRut);
            panelDptoUpdate.Controls.Add(labelDptoUpdate);
            panelDptoUpdate.Location = new Point(67, 525);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(693, 172);
            panelDptoUpdate.TabIndex = 10;
            // 
            // comboBoxRol
            // 
            comboBoxRol.Anchor = AnchorStyles.Left;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(297, 129);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 129);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 10;
            label2.Text = "Seleccionar Estado Reserva:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 17);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 9;
            label1.Text = "Actualizar Estado Reserva";
            // 
            // comboBoxRut
            // 
            comboBoxRut.Anchor = AnchorStyles.Left;
            comboBoxRut.FormattingEnabled = true;
            comboBoxRut.Location = new Point(297, 78);
            comboBoxRut.Name = "comboBoxRut";
            comboBoxRut.Size = new Size(151, 28);
            comboBoxRut.TabIndex = 8;
            // 
            // labelDptoUpdate
            // 
            labelDptoUpdate.Anchor = AnchorStyles.Left;
            labelDptoUpdate.AutoSize = true;
            labelDptoUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDptoUpdate.Location = new Point(80, 81);
            labelDptoUpdate.Name = "labelDptoUpdate";
            labelDptoUpdate.Size = new Size(149, 20);
            labelDptoUpdate.TabIndex = 7;
            labelDptoUpdate.Text = "Seleccionar Reserva:";
            // 
            // FormVReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 756);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewReservas);
            Controls.Add(tituloVReservas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVReservas";
            Text = "FormVReserva";
            Load += FormVReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVReservas;
        private DataGridView dataGridViewReservas;
        private Button btnCargarDatos;
        private Panel panelDptoUpdate;
        private ComboBox comboBoxRol;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRut;
        private Label labelDptoUpdate;
    }
}