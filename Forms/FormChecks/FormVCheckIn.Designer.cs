namespace DashboardTurismoReal.Forms.FormChecks
{
    partial class FormVCheckIn
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
            tituloVDpto = new Label();
            dataGridViewCheckIn = new DataGridView();
            btnCargarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckIn).BeginInit();
            SuspendLayout();
            // 
            // tituloVDpto
            // 
            tituloVDpto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tituloVDpto.AutoSize = true;
            tituloVDpto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVDpto.Location = new Point(515, 42);
            tituloVDpto.Name = "tituloVDpto";
            tituloVDpto.Size = new Size(98, 20);
            tituloVDpto.TabIndex = 2;
            tituloVDpto.Text = "CHECK-IN";
            tituloVDpto.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewCheckIn
            // 
            dataGridViewCheckIn.AllowUserToAddRows = false;
            dataGridViewCheckIn.AllowUserToDeleteRows = false;
            dataGridViewCheckIn.AllowUserToOrderColumns = true;
            dataGridViewCheckIn.AllowUserToResizeRows = false;
            dataGridViewCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCheckIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCheckIn.BackgroundColor = SystemColors.Control;
            dataGridViewCheckIn.BorderStyle = BorderStyle.None;
            dataGridViewCheckIn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCheckIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCheckIn.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCheckIn.GridColor = Color.DarkGoldenrod;
            dataGridViewCheckIn.Location = new Point(30, 89);
            dataGridViewCheckIn.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCheckIn.Name = "dataGridViewCheckIn";
            dataGridViewCheckIn.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCheckIn.RowHeadersVisible = false;
            dataGridViewCheckIn.RowHeadersWidth = 51;
            dataGridViewCheckIn.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCheckIn.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCheckIn.RowTemplate.Height = 24;
            dataGridViewCheckIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCheckIn.Size = new Size(1041, 466);
            dataGridViewCheckIn.TabIndex = 3;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(932, 38);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(139, 29);
            btnCargarDatos.TabIndex = 4;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // FormVCheckIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 597);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewCheckIn);
            Controls.Add(tituloVDpto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVCheckIn";
            Text = "FormVCheckIn";
            Load += FormVCheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVDpto;
        private DataGridView dataGridViewCheckIn;
        private Button btnCargarDatos;
    }
}