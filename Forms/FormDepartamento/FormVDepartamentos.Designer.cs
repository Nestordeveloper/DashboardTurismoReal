namespace DashboardTurismoReal
{
    partial class FormVDepartamentos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tituloVDpto = new Label();
            dataGridViewDepartamentos = new DataGridView();
            btnCargarDatos = new Button();
            labelStateUpdate = new Label();
            labelValueUpdate = new Label();
            panelDptoUpdate = new Panel();
            label1 = new Label();
            btnModificarDpto = new Button();
            txtValorDiario = new TextBox();
            txtDescripcion = new TextBox();
            comboBoxEstado = new ComboBox();
            comboBoxDpto = new ComboBox();
            labelDptoUpdate = new Label();
            labelDescUpdate = new Label();
            dataGridViewHistorial = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartamentos).BeginInit();
            panelDptoUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            SuspendLayout();
            // 
            // tituloVDpto
            // 
            tituloVDpto.Anchor = AnchorStyles.Top;
            tituloVDpto.AutoSize = true;
            tituloVDpto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVDpto.Location = new Point(547, 68);
            tituloVDpto.Name = "tituloVDpto";
            tituloVDpto.Size = new Size(172, 20);
            tituloVDpto.TabIndex = 1;
            tituloVDpto.Text = "DEPARTAMENTOS";
            tituloVDpto.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewDepartamentos
            // 
            dataGridViewDepartamentos.AllowUserToAddRows = false;
            dataGridViewDepartamentos.AllowUserToDeleteRows = false;
            dataGridViewDepartamentos.AllowUserToOrderColumns = true;
            dataGridViewDepartamentos.AllowUserToResizeRows = false;
            dataGridViewDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDepartamentos.BackgroundColor = SystemColors.Control;
            dataGridViewDepartamentos.BorderStyle = BorderStyle.None;
            dataGridViewDepartamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDepartamentos.GridColor = Color.DarkGoldenrod;
            dataGridViewDepartamentos.Location = new Point(49, 110);
            dataGridViewDepartamentos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            dataGridViewDepartamentos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDepartamentos.RowHeadersVisible = false;
            dataGridViewDepartamentos.RowHeadersWidth = 51;
            dataGridViewDepartamentos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewDepartamentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDepartamentos.RowTemplate.Height = 24;
            dataGridViewDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDepartamentos.Size = new Size(1137, 411);
            dataGridViewDepartamentos.TabIndex = 2;
            dataGridViewDepartamentos.CellFormatting += dataGridViewDepartamentos_CellFormatting;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(1047, 64);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(139, 29);
            btnCargarDatos.TabIndex = 3;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // labelStateUpdate
            // 
            labelStateUpdate.Anchor = AnchorStyles.Left;
            labelStateUpdate.AutoSize = true;
            labelStateUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStateUpdate.Location = new Point(14, 195);
            labelStateUpdate.Name = "labelStateUpdate";
            labelStateUpdate.Size = new Size(119, 20);
            labelStateUpdate.TabIndex = 4;
            labelStateUpdate.Text = "Cambiar Estado:";
            // 
            // labelValueUpdate
            // 
            labelValueUpdate.Anchor = AnchorStyles.Left;
            labelValueUpdate.AutoSize = true;
            labelValueUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValueUpdate.Location = new Point(14, 267);
            labelValueUpdate.Name = "labelValueUpdate";
            labelValueUpdate.Size = new Size(156, 20);
            labelValueUpdate.TabIndex = 5;
            labelValueUpdate.Text = "Cambiar Valor Diario:";
            // 
            // panelDptoUpdate
            // 
            panelDptoUpdate.Anchor = AnchorStyles.Left;
            panelDptoUpdate.AutoSize = true;
            panelDptoUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(btnModificarDpto);
            panelDptoUpdate.Controls.Add(txtValorDiario);
            panelDptoUpdate.Controls.Add(txtDescripcion);
            panelDptoUpdate.Controls.Add(comboBoxEstado);
            panelDptoUpdate.Controls.Add(comboBoxDpto);
            panelDptoUpdate.Controls.Add(labelDptoUpdate);
            panelDptoUpdate.Controls.Add(labelDescUpdate);
            panelDptoUpdate.Controls.Add(labelStateUpdate);
            panelDptoUpdate.Controls.Add(labelValueUpdate);
            panelDptoUpdate.Location = new Point(49, 591);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(768, 331);
            panelDptoUpdate.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 26);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 14;
            label1.Text = "Actualizar Departamento";
            // 
            // btnModificarDpto
            // 
            btnModificarDpto.Anchor = AnchorStyles.Left;
            btnModificarDpto.Location = new Point(541, 267);
            btnModificarDpto.Name = "btnModificarDpto";
            btnModificarDpto.Size = new Size(192, 49);
            btnModificarDpto.TabIndex = 13;
            btnModificarDpto.Text = "Modificar";
            btnModificarDpto.UseVisualStyleBackColor = true;
            btnModificarDpto.Click += btnModificarDpto_Click;
            // 
            // txtValorDiario
            // 
            txtValorDiario.Anchor = AnchorStyles.Left;
            txtValorDiario.Location = new Point(214, 264);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.Size = new Size(125, 27);
            txtValorDiario.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Left;
            txtDescripcion.Location = new Point(531, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(217, 109);
            txtDescripcion.TabIndex = 11;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Left;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(214, 192);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(151, 28);
            comboBoxEstado.TabIndex = 9;
            comboBoxEstado.DropDown += comboBoxEstado_DropDown;
            // 
            // comboBoxDpto
            // 
            comboBoxDpto.Anchor = AnchorStyles.Left;
            comboBoxDpto.FormattingEnabled = true;
            comboBoxDpto.Location = new Point(214, 111);
            comboBoxDpto.Name = "comboBoxDpto";
            comboBoxDpto.Size = new Size(151, 28);
            comboBoxDpto.TabIndex = 8;
            comboBoxDpto.DropDown += comboBoxDpto_DropDown;
            comboBoxDpto.SelectedIndexChanged += comboBoxDpto_SelectedIndexChanged;
            // 
            // labelDptoUpdate
            // 
            labelDptoUpdate.Anchor = AnchorStyles.Left;
            labelDptoUpdate.AutoSize = true;
            labelDptoUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDptoUpdate.Location = new Point(14, 114);
            labelDptoUpdate.Name = "labelDptoUpdate";
            labelDptoUpdate.Size = new Size(194, 20);
            labelDptoUpdate.TabIndex = 7;
            labelDptoUpdate.Text = "Seleccionar Departamento:";
            // 
            // labelDescUpdate
            // 
            labelDescUpdate.Anchor = AnchorStyles.Left;
            labelDescUpdate.AutoSize = true;
            labelDescUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescUpdate.Location = new Point(371, 114);
            labelDescUpdate.Name = "labelDescUpdate";
            labelDescUpdate.Size = new Size(154, 20);
            labelDescUpdate.TabIndex = 6;
            labelDescUpdate.Text = "Cambiar Descripción:";
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.AllowUserToAddRows = false;
            dataGridViewHistorial.AllowUserToDeleteRows = false;
            dataGridViewHistorial.AllowUserToOrderColumns = true;
            dataGridViewHistorial.AllowUserToResizeRows = false;
            dataGridViewHistorial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorial.BackgroundColor = SystemColors.Control;
            dataGridViewHistorial.BorderStyle = BorderStyle.None;
            dataGridViewHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewHistorial.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewHistorial.GridColor = Color.DarkGoldenrod;
            dataGridViewHistorial.Location = new Point(836, 591);
            dataGridViewHistorial.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHistorial.RowHeadersVisible = false;
            dataGridViewHistorial.RowHeadersWidth = 51;
            dataGridViewHistorial.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewHistorial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewHistorial.RowTemplate.Height = 24;
            dataGridViewHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistorial.Size = new Size(350, 331);
            dataGridViewHistorial.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(836, 567);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 8;
            label2.Text = "LOG DEPARTAMENTOS:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormVDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 946);
            Controls.Add(label2);
            Controls.Add(dataGridViewHistorial);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewDepartamentos);
            Controls.Add(tituloVDpto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVDepartamentos";
            Text = "FormVDepartamentos";
            Load += FormVDepartamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartamentos).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVDpto;
        private DataGridView dataGridViewDepartamentos;
        private Button btnCargarDatos;
        private Label labelStateUpdate;
        private Label labelValueUpdate;
        private Panel panelDptoUpdate;
        private TextBox txtDescripcion;
        private ComboBox comboBoxEstado;
        private ComboBox comboBoxDpto;
        private Label labelDptoUpdate;
        private Label labelDescUpdate;
        private Button btnModificarDpto;
        private TextBox txtValorDiario;
        private Label label1;
        private DataGridView dataGridViewHistorial;
        private Label label2;
    }
}