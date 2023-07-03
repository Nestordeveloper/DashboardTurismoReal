namespace DashboardTurismoReal.Forms.FormMultas
{
    partial class FormGMultas
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
            tituloVServicios = new Label();
            dataGridViewMultas = new DataGridView();
            btnCargarDatos = new Button();
            panel1 = new Panel();
            btnEnviar = new Button();
            comboBoxInventario = new ComboBox();
            label12 = new Label();
            labelRutaFoto = new Label();
            labelSubFoto = new Label();
            btnGenerarMulta = new Button();
            btnSeleccionarFoto = new Button();
            label10 = new Label();
            txtValorMulta = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtMotivoMulta = new TextBox();
            comboBoxCheckOut = new ComboBox();
            label6 = new Label();
            comboBoxCodProducto = new ComboBox();
            label5 = new Label();
            comboBoxCodDpto = new ComboBox();
            comboBoxReserva = new ComboBox();
            comboBoxRut = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtFiltroRutMultas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMultas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tituloVServicios
            // 
            tituloVServicios.Anchor = AnchorStyles.Top;
            tituloVServicios.AutoSize = true;
            tituloVServicios.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tituloVServicios.Location = new Point(561, 43);
            tituloVServicios.Name = "tituloVServicios";
            tituloVServicios.Size = new Size(83, 20);
            tituloVServicios.TabIndex = 7;
            tituloVServicios.Text = "MULTAS";
            tituloVServicios.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewMultas
            // 
            dataGridViewMultas.AllowUserToAddRows = false;
            dataGridViewMultas.AllowUserToDeleteRows = false;
            dataGridViewMultas.AllowUserToOrderColumns = true;
            dataGridViewMultas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMultas.BackgroundColor = SystemColors.Control;
            dataGridViewMultas.BorderStyle = BorderStyle.None;
            dataGridViewMultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMultas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMultas.GridColor = Color.DarkGoldenrod;
            dataGridViewMultas.Location = new Point(37, 91);
            dataGridViewMultas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMultas.Name = "dataGridViewMultas";
            dataGridViewMultas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMultas.RowHeadersVisible = false;
            dataGridViewMultas.RowHeadersWidth = 51;
            dataGridViewMultas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewMultas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMultas.RowTemplate.Height = 24;
            dataGridViewMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMultas.Size = new Size(1092, 349);
            dataGridViewMultas.TabIndex = 8;
            dataGridViewMultas.CellFormatting += dataGridViewMultas_CellFormatting;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCargarDatos.Location = new Point(990, 39);
            btnCargarDatos.Margin = new Padding(3, 4, 3, 4);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(139, 29);
            btnCargarDatos.TabIndex = 9;
            btnCargarDatos.Text = "Actualizar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(comboBoxInventario);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(labelRutaFoto);
            panel1.Controls.Add(labelSubFoto);
            panel1.Controls.Add(btnGenerarMulta);
            panel1.Controls.Add(btnSeleccionarFoto);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtValorMulta);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMotivoMulta);
            panel1.Controls.Add(comboBoxCheckOut);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxCodProducto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxCodDpto);
            panel1.Controls.Add(comboBoxReserva);
            panel1.Controls.Add(comboBoxRut);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 399);
            panel1.TabIndex = 10;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(632, 354);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(159, 29);
            btnEnviar.TabIndex = 27;
            btnEnviar.Text = "Enviar Notificación";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Visible = false;
            //btnEnviar.Click += btnEnviar_Click;
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(881, 201);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(174, 28);
            comboBoxInventario.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(621, 202);
            label12.Name = "label12";
            label12.Size = new Size(176, 23);
            label12.TabIndex = 25;
            label12.Text = "Código de Inventario:";
            // 
            // labelRutaFoto
            // 
            labelRutaFoto.AutoSize = true;
            labelRutaFoto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRutaFoto.ForeColor = SystemColors.ControlDark;
            labelRutaFoto.Location = new Point(23, 372);
            labelRutaFoto.Name = "labelRutaFoto";
            labelRutaFoto.Size = new Size(104, 20);
            labelRutaFoto.TabIndex = 22;
            labelRutaFoto.Text = "labelRutaFoto";
            // 
            // labelSubFoto
            // 
            labelSubFoto.AutoSize = true;
            labelSubFoto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubFoto.ForeColor = SystemColors.ControlDark;
            labelSubFoto.Location = new Point(23, 345);
            labelSubFoto.Name = "labelSubFoto";
            labelSubFoto.Size = new Size(281, 20);
            labelSubFoto.TabIndex = 21;
            labelSubFoto.Text = "La ruta del archivo que seleccionaste es:";
            // 
            // btnGenerarMulta
            // 
            btnGenerarMulta.BackColor = Color.LightGreen;
            btnGenerarMulta.Location = new Point(881, 345);
            btnGenerarMulta.Name = "btnGenerarMulta";
            btnGenerarMulta.Size = new Size(174, 47);
            btnGenerarMulta.TabIndex = 20;
            btnGenerarMulta.Text = "Generar Multa";
            btnGenerarMulta.UseVisualStyleBackColor = false;
            btnGenerarMulta.Click += btnGenerarMulta_Click;
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.Location = new Point(328, 284);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(174, 29);
            btnSeleccionarFoto.TabIndex = 19;
            btnSeleccionarFoto.Text = "Seleccionar Imagen";
            btnSeleccionarFoto.UseVisualStyleBackColor = true;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(295, 224);
            label10.Name = "label10";
            label10.Size = new Size(27, 20);
            label10.TabIndex = 18;
            label10.Text = "($)";
            // 
            // txtValorMulta
            // 
            txtValorMulta.Location = new Point(328, 221);
            txtValorMulta.Name = "txtValorMulta";
            txtValorMulta.Size = new Size(174, 27);
            txtValorMulta.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(23, 286);
            label9.Name = "label9";
            label9.Size = new Size(148, 23);
            label9.TabIndex = 16;
            label9.Text = "Foto por la Multa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 221);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 15;
            label8.Text = "Valor de Multa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 136);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 14;
            label7.Text = "Motivo de Multa:";
            // 
            // txtMotivoMulta
            // 
            txtMotivoMulta.Anchor = AnchorStyles.Left;
            txtMotivoMulta.Location = new Point(197, 136);
            txtMotivoMulta.Multiline = true;
            txtMotivoMulta.Name = "txtMotivoMulta";
            txtMotivoMulta.ScrollBars = ScrollBars.Vertical;
            txtMotivoMulta.Size = new Size(305, 65);
            txtMotivoMulta.TabIndex = 13;
            // 
            // comboBoxCheckOut
            // 
            comboBoxCheckOut.FormattingEnabled = true;
            comboBoxCheckOut.Location = new Point(328, 74);
            comboBoxCheckOut.Name = "comboBoxCheckOut";
            comboBoxCheckOut.Size = new Size(174, 28);
            comboBoxCheckOut.TabIndex = 10;
            comboBoxCheckOut.DropDown += comboBoxCheckOut_DropDown;
            comboBoxCheckOut.SelectedIndexChanged += comboBoxCheckOut_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 75);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 9;
            label6.Text = "Código Check-Out:";
            // 
            // comboBoxCodProducto
            // 
            comboBoxCodProducto.FormattingEnabled = true;
            comboBoxCodProducto.Location = new Point(881, 266);
            comboBoxCodProducto.Name = "comboBoxCodProducto";
            comboBoxCodProducto.Size = new Size(174, 28);
            comboBoxCodProducto.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(619, 267);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 7;
            label5.Text = "Código del Producto:";
            // 
            // comboBoxCodDpto
            // 
            comboBoxCodDpto.FormattingEnabled = true;
            comboBoxCodDpto.Location = new Point(881, 136);
            comboBoxCodDpto.Name = "comboBoxCodDpto";
            comboBoxCodDpto.Size = new Size(174, 28);
            comboBoxCodDpto.TabIndex = 6;
            // 
            // comboBoxReserva
            // 
            comboBoxReserva.FormattingEnabled = true;
            comboBoxReserva.Location = new Point(881, 74);
            comboBoxReserva.Name = "comboBoxReserva";
            comboBoxReserva.Size = new Size(174, 28);
            comboBoxReserva.TabIndex = 5;
            // 
            // comboBoxRut
            // 
            comboBoxRut.FormattingEnabled = true;
            comboBoxRut.Location = new Point(881, 19);
            comboBoxRut.Name = "comboBoxRut";
            comboBoxRut.Size = new Size(174, 28);
            comboBoxRut.TabIndex = 4;
            comboBoxRut.SelectedIndexChanged += comboBoxRut_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(621, 136);
            label4.Name = "label4";
            label4.Size = new Size(209, 23);
            label4.TabIndex = 3;
            label4.Text = "Código de Departamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(619, 75);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 2;
            label3.Text = "Código de Reserva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(621, 20);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "RUT del Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "GENERAR MULTA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(37, 39);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 14;
            label11.Text = "Filtrar por RUT:";
            // 
            // txtFiltroRutMultas
            // 
            txtFiltroRutMultas.Location = new Point(37, 62);
            txtFiltroRutMultas.Name = "txtFiltroRutMultas";
            txtFiltroRutMultas.Size = new Size(171, 27);
            txtFiltroRutMultas.TabIndex = 13;
            txtFiltroRutMultas.TextChanged += txtFiltroRutMultas_TextChanged;
            // 
            // FormGMultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 875);
            Controls.Add(label11);
            Controls.Add(txtFiltroRutMultas);
            Controls.Add(panel1);
            Controls.Add(btnCargarDatos);
            Controls.Add(dataGridViewMultas);
            Controls.Add(tituloVServicios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGMultas";
            Text = "FormGMultas";
            Load += FormGMultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMultas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloVServicios;
        private DataGridView dataGridViewMultas;
        private Button btnCargarDatos;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxCodProducto;
        private Label label5;
        private ComboBox comboBoxCodDpto;
        private ComboBox comboBoxReserva;
        private ComboBox comboBoxRut;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxCheckOut;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtMotivoMulta;
        private Label label10;
        private TextBox txtValorMulta;
        private Button btnGenerarMulta;
        private Button btnSeleccionarFoto;
        private Label labelSubFoto;
        private Label labelRutaFoto;
        private ComboBox comboBoxInventario;
        private Label label12;
        private Label label11;
        private TextBox txtFiltroRutMultas;
        private Button btnEnviar;
    }
}