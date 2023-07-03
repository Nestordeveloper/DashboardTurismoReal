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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tituloVReservas = new Label();
            dataGridViewReservas = new DataGridView();
            btnCargarDatos = new Button();
            panelStatusUpdate = new Panel();
            btnActualizarEstado = new Button();
            comboBoxEstadoReserva = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxReserva = new ComboBox();
            labelDptoUpdate = new Label();
            label11 = new Label();
            txtFiltroRUTReserva = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            panelStatusUpdate.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.GridColor = Color.DarkGoldenrod;
            dataGridViewReservas.Location = new Point(67, 112);
            dataGridViewReservas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.RowHeadersVisible = false;
            dataGridViewReservas.RowHeadersWidth = 51;
            dataGridViewReservas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            // panelStatusUpdate
            // 
            panelStatusUpdate.AutoSize = true;
            panelStatusUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelStatusUpdate.Controls.Add(btnActualizarEstado);
            panelStatusUpdate.Controls.Add(comboBoxEstadoReserva);
            panelStatusUpdate.Controls.Add(label2);
            panelStatusUpdate.Controls.Add(label1);
            panelStatusUpdate.Controls.Add(comboBoxReserva);
            panelStatusUpdate.Controls.Add(labelDptoUpdate);
            panelStatusUpdate.Location = new Point(67, 525);
            panelStatusUpdate.Name = "panelStatusUpdate";
            panelStatusUpdate.Size = new Size(693, 172);
            panelStatusUpdate.TabIndex = 10;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(532, 129);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(119, 29);
            btnActualizarEstado.TabIndex = 12;
            btnActualizarEstado.Text = "Actualizar";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // comboBoxEstadoReserva
            // 
            comboBoxEstadoReserva.Anchor = AnchorStyles.Left;
            comboBoxEstadoReserva.FormattingEnabled = true;
            comboBoxEstadoReserva.Location = new Point(297, 129);
            comboBoxEstadoReserva.Name = "comboBoxEstadoReserva";
            comboBoxEstadoReserva.Size = new Size(151, 28);
            comboBoxEstadoReserva.TabIndex = 11;
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
            // comboBoxReserva
            // 
            comboBoxReserva.Anchor = AnchorStyles.Left;
            comboBoxReserva.FormattingEnabled = true;
            comboBoxReserva.Location = new Point(297, 78);
            comboBoxReserva.Name = "comboBoxReserva";
            comboBoxReserva.Size = new Size(151, 28);
            comboBoxReserva.TabIndex = 8;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(67, 60);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 20;
            label11.Text = "Filtrar por RUT:";
            // 
            // txtFiltroRUTReserva
            // 
            txtFiltroRUTReserva.Location = new Point(67, 83);
            txtFiltroRUTReserva.Name = "txtFiltroRUTReserva";
            txtFiltroRUTReserva.Size = new Size(242, 27);
            txtFiltroRUTReserva.TabIndex = 19;
            txtFiltroRUTReserva.TextChanged += txtFiltroRUTReserva_TextChanged;
            // 
            // FormVReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 756);
            Controls.Add(label11);
            Controls.Add(txtFiltroRUTReserva);
            Controls.Add(panelStatusUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewReservas);
            Controls.Add(tituloVReservas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVReservas";
            Text = "FormVReserva";
            Load += FormVReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            panelStatusUpdate.ResumeLayout(false);
            panelStatusUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVReservas;
        private DataGridView dataGridViewReservas;
        private Button btnCargarDatos;
        private Panel panelStatusUpdate;
        private ComboBox comboBoxEstadoReserva;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxReserva;
        private Label labelDptoUpdate;
        private Button btnActualizarEstado;
        private Label label11;
        private TextBox txtFiltroRUTReserva;
    }
}