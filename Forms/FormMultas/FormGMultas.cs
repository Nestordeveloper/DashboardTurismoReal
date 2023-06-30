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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DashboardTurismoReal.Forms.FormMultas
{
    public partial class FormGMultas : Form
    {
        private AzureApiManager apiManager;
        private string pdfFilePath; // Variable para almacenar la ruta del archivo PDF
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

        private async Task<string> SeleccionarRutaAsync()
        {
            // Mostrar un cuadro de diálogo personalizado o utilizar una caja de texto para que el usuario ingrese la ubicación del archivo
            // y devuelve la ubicación como resultado de la tarea.

            // Por ejemplo:
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleccionar la carpeta donde guardar el archivo PDF";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return null;
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
                    document.Add(new Paragraph("Datos de la multa"));
                    document.Add(Chunk.NEWLINE);
                    document.Add(new Paragraph("Rut: " + multa.Rut));
                    document.Add(new Paragraph("Código de departamento: " + multa.DepartmentCode));
                    document.Add(new Paragraph("Código de producto: " + multa.ProductId));
                    document.Add(new Paragraph("Motivo: " + multa.Reason));
                    document.Add(new Paragraph("Valor de la multa: " + multa.MultaValue));

                    if (multa.MultaPhoto != null)
                    {
                        iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(multa.MultaPhoto);
                        document.Add(foto);
                    }
                }

                MessageBox.Show("Multa generada con éxito.");
                LimpiarCampos();
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
                    MessageBox.Show("Contenido de la solicitud:\n" + multaJson);

                    string response = await apiManager.PostApiResponse("api/multa", multaJson);

                    if (response != null)
                    {
                        // Solicitar al usuario la ubicación donde guardar el PDF
                        string ubicacionArchivo = await SeleccionarRutaAsync();

                        if (!string.IsNullOrEmpty(ubicacionArchivo))
                        {
                            // Generar el PDF en la ubicación especificada
                            await GenerarPDFAsync(multa, ubicacionArchivo);
                        }
                        else
                        {
                            MessageBox.Show("No se seleccionó una ubicación válida para guardar el PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(comboBoxRut.Text) || string.IsNullOrEmpty(comboBoxCodDpto.Text) || string.IsNullOrEmpty(comboBoxCodProducto.Text) || string.IsNullOrEmpty(txtMotivoMulta.Text) || string.IsNullOrEmpty(txtValorMulta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar la multa.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(labelRutaFoto.Text))
            {
                MessageBox.Show("Por favor, seleccione una foto de la multa antes de generarla.", "Foto de la multa no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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
