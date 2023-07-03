namespace DashboardTurismoReal.FormUsuario
{
    partial class FormVUsuarios
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
            tituloVUsuarios = new Label();
            dataGridViewUsuarios = new DataGridView();
            btnCargarDatos = new Button();
            panelDptoUpdate = new Panel();
            btnActualizarRol = new Button();
            comboBoxRol = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxRut = new ComboBox();
            labelDptoUpdate = new Label();
            panel1 = new Panel();
            btnEliminarUsuario = new Button();
            label4 = new Label();
            comboBoxRutDelete = new ComboBox();
            label5 = new Label();
            txtFiltroRut = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelDptoUpdate.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVUsuarios
            // 
            tituloVUsuarios.AutoSize = true;
            tituloVUsuarios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVUsuarios.Location = new Point(503, 66);
            tituloVUsuarios.Name = "tituloVUsuarios";
            tituloVUsuarios.Size = new Size(103, 20);
            tituloVUsuarios.TabIndex = 6;
            tituloVUsuarios.Text = "USUARIOS";
            tituloVUsuarios.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToOrderColumns = true;
            dataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuarios.BackgroundColor = SystemColors.Control;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.GridColor = Color.DarkGoldenrod;
            dataGridViewUsuarios.Location = new Point(82, 116);
            dataGridViewUsuarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewUsuarios.RowTemplate.Height = 24;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(914, 337);
            dataGridViewUsuarios.TabIndex = 7;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(884, 62);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(112, 29);
            btnCargarDatos.TabIndex = 8;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // panelDptoUpdate
            // 
            panelDptoUpdate.Anchor = AnchorStyles.Left;
            panelDptoUpdate.BorderStyle = BorderStyle.Fixed3D;
            panelDptoUpdate.Controls.Add(btnActualizarRol);
            panelDptoUpdate.Controls.Add(comboBoxRol);
            panelDptoUpdate.Controls.Add(label2);
            panelDptoUpdate.Controls.Add(label1);
            panelDptoUpdate.Controls.Add(comboBoxRut);
            panelDptoUpdate.Controls.Add(labelDptoUpdate);
            panelDptoUpdate.Location = new Point(82, 469);
            panelDptoUpdate.Name = "panelDptoUpdate";
            panelDptoUpdate.Size = new Size(645, 208);
            panelDptoUpdate.TabIndex = 9;
            // 
            // btnActualizarRol
            // 
            btnActualizarRol.Location = new Point(475, 152);
            btnActualizarRol.Name = "btnActualizarRol";
            btnActualizarRol.Size = new Size(139, 29);
            btnActualizarRol.TabIndex = 12;
            btnActualizarRol.Text = "Actualizar Rol";
            btnActualizarRol.UseVisualStyleBackColor = true;
            btnActualizarRol.Click += btnActualizarRol_Click;
            // 
            // comboBoxRol
            // 
            comboBoxRol.Anchor = AnchorStyles.Left;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(251, 153);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 11;
            comboBoxRol.DropDown += comboBoxRol_DropDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 161);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 10;
            label2.Text = "Seleccionar Rol:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 36);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 9;
            label1.Text = "Actualizar Rol Usuario";
            // 
            // comboBoxRut
            // 
            comboBoxRut.Anchor = AnchorStyles.Left;
            comboBoxRut.FormattingEnabled = true;
            comboBoxRut.Location = new Point(251, 102);
            comboBoxRut.Name = "comboBoxRut";
            comboBoxRut.Size = new Size(151, 28);
            comboBoxRut.TabIndex = 8;
            // 
            // labelDptoUpdate
            // 
            labelDptoUpdate.Anchor = AnchorStyles.Left;
            labelDptoUpdate.AutoSize = true;
            labelDptoUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDptoUpdate.Location = new Point(34, 105);
            labelDptoUpdate.Name = "labelDptoUpdate";
            labelDptoUpdate.Size = new Size(180, 20);
            labelDptoUpdate.TabIndex = 7;
            labelDptoUpdate.Text = "Seleccionar RUT Usuario:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxRutDelete);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(82, 715);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 166);
            panel1.TabIndex = 10;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(475, 86);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(139, 29);
            btnEliminarUsuario.TabIndex = 12;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(251, 20);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 9;
            label4.Text = "Eliminar Usuario";
            // 
            // comboBoxRutDelete
            // 
            comboBoxRutDelete.Anchor = AnchorStyles.Left;
            comboBoxRutDelete.FormattingEnabled = true;
            comboBoxRutDelete.Location = new Point(251, 86);
            comboBoxRutDelete.Name = "comboBoxRutDelete";
            comboBoxRutDelete.Size = new Size(151, 28);
            comboBoxRutDelete.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 89);
            label5.Name = "label5";
            label5.Size = new Size(180, 20);
            label5.TabIndex = 7;
            label5.Text = "Seleccionar RUT Usuario:";
            // 
            // txtFiltroRut
            // 
            txtFiltroRut.Location = new Point(82, 82);
            txtFiltroRut.Name = "txtFiltroRut";
            txtFiltroRut.Size = new Size(171, 27);
            txtFiltroRut.TabIndex = 11;
            txtFiltroRut.TextChanged += txtFiltroRut_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 59);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 12;
            label3.Text = "Filtrar por RUT:";
            // 
            // FormVUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 904);
            Controls.Add(label3);
            Controls.Add(txtFiltroRut);
            Controls.Add(panel1);
            Controls.Add(panelDptoUpdate);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(tituloVUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVUsuarios";
            Text = "FormVUsuarios";
            Load += FormVUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelDptoUpdate.ResumeLayout(false);
            panelDptoUpdate.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVUsuarios;
        private DataGridView dataGridViewUsuarios;
        private Button btnCargarDatos;
        private Panel panelDptoUpdate;
        private ComboBox comboBoxRut;
        private Label labelDptoUpdate;
        private Label label1;
        private ComboBox comboBoxRol;
        private Label label2;
        private Button btnActualizarRol;
        private Panel panel1;
        private Button btnEliminarUsuario;
        private Label label4;
        private ComboBox comboBoxRutDelete;
        private Label label5;
        private TextBox txtFiltroRut;
        private Label label3;
    }
}