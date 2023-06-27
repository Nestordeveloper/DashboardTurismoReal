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
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventarios).BeginInit();
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
            dataGridViewInventarios.Size = new Size(940, 594);
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
            // FormVInventarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 736);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewInventarios);
            Controls.Add(tituloVInv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVInventarios";
            Text = "FormVInventario";
            Load += FormVInventarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVInv;
        private DataGridView dataGridViewInventarios;
        private Button btnCargarDatos;
    }
}