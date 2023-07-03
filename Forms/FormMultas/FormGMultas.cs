using DashboardTurismoReal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendGrid;
using SendGrid.Helpers.Mail;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;

namespace DashboardTurismoReal.Forms.FormMultas
{
    public partial class FormGMultas : Form
    {
        private AzureApiManager apiManager;
        private CheckOut selectedCheckout;

        public FormGMultas()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
            labelSubFoto.Visible = false; // Ocultar el Label al iniciar el formulario
            labelRutaFoto.Visible = false; // Ocultar el Label al iniciar el formulario
        }

        private async void FormGMultas_Load(object sender, EventArgs e)
        {
            await CargarMultas();
        }
        private async Task CargarMultas()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/multa");
                List<Multa> multas = JsonConvert.DeserializeObject<List<Multa>>(responseData);

                // Asignar los datos al DataGridView
                dataGridViewMultas.DataSource = multas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las multas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewMultas.Columns[e.ColumnIndex].Name == "Reason")
            {
                dataGridViewMultas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                dataGridViewMultas.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
        private void txtFiltroRutMultas_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox de filtro
            string filtroRut = txtFiltroRutMultas.Text;

            // Obtén el origen de datos actual del DataGridView (lista de multas)
            List<Multa> multas = dataGridViewMultas.DataSource as List<Multa>;

            // Filtra la lista de multas por el campo "Rut"
            List<Multa> multasFiltradas = multas.Where(m => m.Rut.Contains(filtroRut)).ToList();

            // Asigna los datos filtrados al DataGridView
            dataGridViewMultas.DataSource = multasFiltradas;
        }



        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/multa");
                List<Multa> multas = JsonConvert.DeserializeObject<List<Multa>>(responseData);

                // Asignar los datos al DataGridView
                dataGridViewMultas.DataSource = multas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las multas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void comboBoxCheckOut_DropDown(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de los checkouts
                string responseData = await apiManager.GetApiResponse("api/checkout");
                List<CheckOut> checkouts = JsonConvert.DeserializeObject<List<CheckOut>>(responseData);

                // Rellenar el ComboBox con los datos de los checkouts
                comboBoxCheckOut.DataSource = checkouts;
                comboBoxCheckOut.DisplayMember = "CheckOutId";
                comboBoxCheckOut.ValueMember = "CheckOutId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los checkouts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarProductosPorInventario(string inventarioId)
        {
            string url = $"api/Producto/GetProductobyDepartment/{inventarioId}";
            string responseData = await apiManager.GetApiResponse(url);
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(responseData);

            // Asignar los productos al ComboBox
            comboBoxCodProducto.DataSource = productos;
            comboBoxCodProducto.DisplayMember = "ProductName";
            comboBoxCodProducto.ValueMember = "ProductId";
        }

        private async Task<string> ObtenerEmailUsuario(string rut)
        {
            try
            {
                string url = $"/api/Usuario/GetUsuario/{rut}";

                // Obtener la respuesta de la API para obtener los datos del usuario
                string responseData = await apiManager.GetApiResponse(url);

                // Deserializar la respuesta JSON en un objeto Usuario
                Usuario usuario = JsonConvert.DeserializeObject<Usuario>(responseData);

                // Retornar el correo electrónico del usuario
                return usuario.Email;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos del usuario
                MessageBox.Show("Error al obtener el correo electrónico del usuario: " + ex.Message);
                return null;
            }
        }


        private async void comboBoxCheckOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCheckOut.SelectedItem != null)
            {
                selectedCheckout = (CheckOut)comboBoxCheckOut.SelectedItem;
                int selectedCheckoutId = Convert.ToInt32(selectedCheckout.CheckOutId);
                string checkoutDataResponse = string.Empty;
                int selectedBooking = Convert.ToInt32(selectedCheckout.BookingId);
                string selectedDpto = selectedCheckout.DepartmentCode;

                try
                {
                    // Obtener la información del checkout seleccionado
                    checkoutDataResponse = await apiManager.GetApiResponse($"api/checkout/{selectedCheckoutId}");
                    CheckOut checkout = JsonConvert.DeserializeObject<CheckOut>(checkoutDataResponse);

                    // Rellenar los campos con la información obtenida
                    comboBoxRut.Text = checkout.Rut;
                    comboBoxReserva.Text = checkout.BookingId.ToString(); // Agregar el operador de anulabilidad '?' para evitar errores si BookingId es nulo
                    comboBoxCodDpto.Text = checkout.DepartmentCode;
                    comboBoxInventario.Text = checkout.InventoryId;

                    // Obtener el correo electrónico del usuario
                    string userEmail = await ObtenerEmailUsuario(checkout.Rut);

                    // Cargar los productos por inventario en el ComboBox comboBoxCodProducto
                    await CargarProductosPorInventario(checkout.InventoryId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la información del checkout: " + ex.Message + "\n\nRespuesta de la API: " + checkoutDataResponse + "\n\nError", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Seleccionar foto de la multa";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                // Asignar la ruta del archivo al control Label
                labelRutaFoto.Text = rutaArchivo;
                labelRutaFoto.Visible = true; // Mostrar el Label con la ruta del archivo
                labelSubFoto.Visible = true;
            }
        }

        private async Task GenerarPDFAsync(Multa multa, string ubicacionArchivo)
        {
            try
            {
                // Crear el archivo PDF en la ubicación especificada
                using (Document document = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(ubicacionArchivo, FileMode.Create));
                    document.Open();

                    // Definir estilos de fuente
                    iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
                    iTextSharp.text.Font subtitleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 12);
                    iTextSharp.text.Font normalFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 10);

                    // Agregar título
                    Paragraph title = new Paragraph("Multa - Turismo Real", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    document.Add(Chunk.NEWLINE);

                    // Agregar datos de la multa
                    document.Add(new Paragraph("Rut: " + multa.Rut, subtitleFont));
                    document.Add(new Paragraph("Código de departamento: " + multa.DepartmentCode, subtitleFont));
                    document.Add(new Paragraph("Código de producto: " + multa.ProductId, subtitleFont));
                    document.Add(new Paragraph("Motivo: " + multa.Reason, subtitleFont));
                    document.Add(new Paragraph("Valor de la multa: " + multa.MultaValue, subtitleFont));

                    document.Add(Chunk.NEWLINE);

                    // Agregar foto
                    if (multa.MultaPhoto != null)
                    {
                        iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(multa.MultaPhoto);
                        foto.Alignment = Element.ALIGN_CENTER;
                        foto.ScaleToFit(200, 200);
                        document.Add(foto);
                    }

                    MessageBox.Show("Multa generada con éxito.");
                    LimpiarCampos();
                }
            }
            catch (DocumentException ex)
            {
                MessageBox.Show("Error al generar el documento PDF: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de archivo al generar el PDF: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al generar el PDF: " + ex.Message);
            }
        }


        private async void btnGenerarMulta_Click(object sender, EventArgs e)
        {
            if (selectedCheckout == null)
            {
                MessageBox.Show("Seleccione un checkout antes de generar la multa.", "Checkout no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCheckoutId = Convert.ToInt32(selectedCheckout.CheckOutId);

            if (ValidarCampos())
            {
                // Verificar si ya existe una multa registrada para el ID del checkout actual
                bool multaExistente = await VerificarMultaExistente(selectedCheckoutId);

                if (multaExistente)
                {
                    MessageBox.Show("Ya se ha generado una multa para este checkout. No se puede generar una multa duplicada.", "Multa existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Multa multa = new Multa
                {
                    Rut = comboBoxRut.Text,
                    DepartmentCode = selectedCheckout.DepartmentCode,
                    ProductId = Convert.ToInt32(comboBoxCodProducto.SelectedValue),
                    Reason = txtMotivoMulta.Text,
                    MultaValue = decimal.Parse(txtValorMulta.Text),
                    MultaPhoto = ObtenerBytesFoto(),
                    CheckoutId = selectedCheckoutId,
                    BookingId = selectedCheckout.BookingId
                };

                try
                {
                    string checkoutDataResponse = await apiManager.GetApiResponse($"api/Checkout/{selectedCheckoutId}");
                    CheckOut checkout = JsonConvert.DeserializeObject<CheckOut>(checkoutDataResponse);

                    // Obtener el código del departamento y la reserva asociada
                    string codigoDepartamento = checkout.DepartmentCode;
                    int reservaId = checkout.BookingId;

                    string multaJson = JsonConvert.SerializeObject(multa);

                    string response = await apiManager.PostApiResponse("api/multa", multaJson);

                    if (response != null)
                    {
                        // Obtener la estampa de tiempo actual
                        string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HHmmss");

                        string proyectoDirectorio = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        string ubicacionArchivo = $"C:\\PDF\\PDFMULTA\\Multa{timestamp}.pdf";

                        // Generar el archivo PDF
                        await GenerarPDFAsync(multa, ubicacionArchivo);

                        // Mostrar el MessageBox para confirmar el envío de la notificación
                        DialogResult result = MessageBox.Show("¿Desea enviar la notificación por correo electrónico?", "Confirmar envío", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Obtener el correo electrónico del usuario
                            string userEmail = await ObtenerEmailUsuario(multa.Rut);

                            // Enviar la notificación al correo electrónico obtenido junto con el archivo adjunto
                            await EnviarNotificacion(userEmail, ubicacionArchivo);
                        }
                        else
                        {
                            MessageBox.Show("La notificación no ha sido enviada.", "Envío cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar la multa. Por favor, inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private async Task<bool> VerificarMultaExistente(int checkoutId)
        {
            try
            {
                string responseData = await apiManager.GetApiResponse($"api/multa");
                List<Multa> multas = JsonConvert.DeserializeObject<List<Multa>>(responseData);

                return multas.Any(multa => multa.CheckoutId == checkoutId); // Retorna true si hay una multa con el mismo ID del checkout, false si no existe
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia de multas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // En caso de error, asumimos que no hay multas registradas
            }
        }



        private byte[] ObtenerBytesFoto()
        {
            byte[] fotoBytes = null;
            string rutaFoto = labelRutaFoto.Text;

            if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
            {
                try
                {
                    using (FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            fotoBytes = br.ReadBytes((int)fs.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los bytes de la foto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return fotoBytes;
        }



        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(comboBoxRut.Text) ||
                string.IsNullOrEmpty(comboBoxCodProducto.Text) ||
                string.IsNullOrEmpty(txtMotivoMulta.Text) ||
                string.IsNullOrEmpty(txtValorMulta.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        // ENVIO DE CORREOS - SG
        private async Task EnviarNotificacion(string userEmail, string archivoAdjunto)
        {
            try
            {
                var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("contacto.turismorealchile@gmail.com", "Turismo Real Chile");
                var subject = "Turismo Real Chile - Multa";
                var to = new EmailAddress(userEmail);
                var plainTextContent = "Adjunto se encuentra el documento PDF de la multa generada.";
                var htmlContent = "<strong>Adjunto se encuentra el documento PDF de la multa generada.</strong>";

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

                // Adjuntar el archivo PDF
                byte[] attachmentBytes = File.ReadAllBytes(archivoAdjunto);
                string attachmentBase64 = Convert.ToBase64String(attachmentBytes);
                msg.AddAttachment("Multa.pdf", attachmentBase64);

                var response = await client.SendEmailAsync(msg);

                Console.WriteLine(response.StatusCode);
                Console.WriteLine(response.Headers.ToString());
                Console.WriteLine("\nPresiona Enter para salir.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la notificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRut.SelectedItem != null)
            {
                Usuario selectedUser = (Usuario)comboBoxRut.SelectedItem;
            }
        }

        private void LimpiarCampos()
        {
            comboBoxRut.Text = string.Empty;
            comboBoxCodDpto.SelectedIndex = -1;
            comboBoxCodProducto.DataSource = null;
            txtMotivoMulta.Text = string.Empty;
            txtValorMulta.Text = string.Empty;
            labelRutaFoto.Text = string.Empty;
            labelRutaFoto.Visible = false;
            labelSubFoto.Visible = false;
        }
    }
}
