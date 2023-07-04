namespace DashboardTurismoReal.Forms.FormChecks
{
    partial class FormVCheckOut
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
            dataGridViewCheckOut = new DataGridView();
            btnCargarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckOut).BeginInit();
            SuspendLayout();
            // 
            // tituloVDpto
            // 
            tituloVDpto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tituloVDpto.AutoSize = true;
            tituloVDpto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVDpto.Location = new Point(497, 53);
            tituloVDpto.Name = "tituloVDpto";
            tituloVDpto.Size = new Size(118, 20);
            tituloVDpto.TabIndex = 3;
            tituloVDpto.Text = "CHECK-OUT";
            tituloVDpto.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewCheckOut
            // 
            dataGridViewCheckOut.AllowUserToAddRows = false;
            dataGridViewCheckOut.AllowUserToDeleteRows = false;
            dataGridViewCheckOut.AllowUserToOrderColumns = true;
            dataGridViewCheckOut.AllowUserToResizeRows = false;
            dataGridViewCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCheckOut.BackgroundColor = SystemColors.Control;
            dataGridViewCheckOut.BorderStyle = BorderStyle.None;
            dataGridViewCheckOut.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCheckOut.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCheckOut.GridColor = Color.DarkGoldenrod;
            dataGridViewCheckOut.Location = new Point(51, 116);
            dataGridViewCheckOut.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            dataGridViewCheckOut.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCheckOut.RowHeadersVisible = false;
            dataGridViewCheckOut.RowHeadersWidth = 51;
            dataGridViewCheckOut.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCheckOut.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCheckOut.RowTemplate.Height = 24;
            dataGridViewCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCheckOut.Size = new Size(949, 447);
            dataGridViewCheckOut.TabIndex = 4;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(861, 49);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(139, 29);
            btnCargarDatos.TabIndex = 5;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // FormVCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 611);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewCheckOut);
            Controls.Add(tituloVDpto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVCheckOut";
            Text = "FormVCheckOut";
            Load += FormVCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVDpto;
        private DataGridView dataGridViewCheckOut;
        private Button btnCargarDatos;
    }
}