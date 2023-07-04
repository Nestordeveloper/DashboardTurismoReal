using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardTurismoReal.Models;
using Newtonsoft.Json;

namespace DashboardTurismoReal.Forms.FormDepartamento
{
    public partial class FormFDepartamentos : Form
    {
        private AzureApiManager apiManager;
        public FormFDepartamentos()
        {
            InitializeComponent();
            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

            // Deshabilitar los botones de las fotos 2, 3 y 4
            btnSeleccionarFoto2.Enabled = false;
            btnSeleccionarFoto3.Enabled = false;
            btnSeleccionarFoto4.Enabled = false;
        }

        private async void FormFDepartamentos_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarFotosDepartamentos();
                await CargarDepartamentos();
                await CargarDepartamentosUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private async Task CargarFotosDepartamentos()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllFotoDepartaments");

                List<FotosDepartamento> fotosDepartamentos = JsonConvert.DeserializeObject<List<FotosDepartamento>>(responseData);

                dataGridViewFotosDpto.DataSource = fotosDepartamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de FotosDepartamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarDepartamentos()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");

                List<Departamento> departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

                comboBoxADDepartamento.DataSource = departamentos;
                comboBoxADDepartamento.DisplayMember = "DepartmentCod";
                comboBoxADDepartamento.ValueMember = "DepartmentCod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de Departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarDepartamentosUpdate()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");

                List<Departamento> departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

                comboBoxDptoUpdate.DataSource = departamentos;
                comboBoxDptoUpdate.DisplayMember = "DepartmentCod";
                comboBoxDptoUpdate.ValueMember = "DepartmentCod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de Departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] fotoRutas = new string[4]; // Arreglo para almacenar las rutas de las fotos seleccionadas

        private void btnSeleccionarFoto1_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(0);
        }

        private void btnSeleccionarFoto2_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(1);
        }

        private void btnSeleccionarFoto3_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(2);
        }

        private void btnSeleccionarFoto4_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(3);
        }

        private void SeleccionarFoto(int fotoIndex)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = $"Seleccionar {GetFotoNumberText(fotoIndex + 1)} foto del departamento";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                // Asignar la ruta del archivo al arreglo de rutas de fotos
                fotoRutas[fotoIndex] = rutaArchivo;

                // Actualizar el label correspondiente a la ruta de la foto
                Label labelRutaFoto = GetLabelRutaFoto(fotoIndex + 1);
                labelRutaFoto.Text = rutaArchivo;
                labelRutaFoto.Visible = true; // Mostrar el Label con la ruta del archivo

                // Habilitar el siguiente botón de foto si aún no se ha seleccionado
                if (fotoIndex < 3)
                {
                    Button nextButton = GetButtonSeleccionarFoto(fotoIndex + 2);
                    nextButton.Enabled = true;
                }
            }
        }

        private Label GetLabelRutaFoto(int fotoIndex)
        {
            // Obtener el control Label correspondiente al índice de la foto
            string labelName = $"labelRutaFoto{fotoIndex}";
            Control[] controls = this.Controls.Find(labelName, true);

            if (controls.Length > 0 && controls[0] is Label)
            {
                return (Label)controls[0];
            }

            throw new Exception($"No se encontró el control Label {labelName}");
        }

        private Button GetButtonSeleccionarFoto(int fotoIndex)
        {
            // Obtener el control Button correspondiente al índice de la foto
            string buttonName = $"btnSeleccionarFoto{fotoIndex}";
            Control[] controls = this.Controls.Find(buttonName, true);

            if (controls.Length > 0 && controls[0] is Button)
            {
                return (Button)controls[0];
            }

            throw new Exception($"No se encontró el control Button {buttonName}");
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            await CargarFotosDepartamentos(); // Cargar el historial de cambios al hacer clic en el botón

            // Deshabilitar los botones de las fotos que no han sido seleccionadas
            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(fotoRutas[i]))
                {
                    Button button = GetButtonSeleccionarFoto(i + 1);
                    button.Enabled = false;
                }
            }
        }

        private string GetFotoNumberText(int fotoIndex)
        {
            // Obtener el texto del número de foto según el índice
            switch (fotoIndex)
            {
                case 1:
                    return "Primera";
                case 2:
                    return "Segunda";
                case 3:
                    return "Tercera";
                case 4:
                    return "Cuarta";
                default:
                    throw new ArgumentOutOfRangeException("fotoIndex", "Índice de foto inválido");
            }
        }

        private async void btnAddFotos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código del departamento seleccionado
                Departamento departamento = (Departamento)comboBoxADDepartamento.SelectedItem;
                string departmentCod = departamento.DepartmentCod;

                // Obtener los bytes de las fotos seleccionadas
                byte[] photo1Bytes = GetPhotoBytes(fotoRutas[0]);
                byte[] photo2Bytes = GetPhotoBytes(fotoRutas[1]);
                byte[] photo3Bytes = GetPhotoBytes(fotoRutas[2]);
                byte[] photo4Bytes = GetPhotoBytes(fotoRutas[3]);

                // Crear el objeto FotosDepartamento con los datos del departamento y las fotos
                FotosDepartamento fotosDepartamento = new FotosDepartamento
                {
                    DepartmentCod = departmentCod,
                    Photo1 = photo1Bytes,
                    Photo2 = photo2Bytes,
                    Photo3 = photo3Bytes,
                    Photo4 = photo4Bytes
                };

                // Serializar el objeto FotosDepartamento a JSON
                string jsonData = JsonConvert.SerializeObject(fotosDepartamento);

                // Enviar la solicitud POST a la API para agregar las fotos al departamento
                string responseData = await apiManager.PostApiResponse("api/Departamento/AñadirFotoDepartamento", jsonData);

                // Mostrar mensaje de éxito
                MessageBox.Show("Las fotos se han agregado al departamento correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar las fotos al departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ACTUALIZAR FOTO DEPARTAMENTO

        private async void btnUpdateFoto_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código del departamento seleccionado
                Departamento departamento = (Departamento)comboBoxDptoUpdate.SelectedItem;
                string departmentCod = departamento.DepartmentCod;

                // Obtener los bytes de las fotos seleccionadas
                byte[] photo1Bytes = GetPhotoBytes(fotoRutas[0]);
                byte[] photo2Bytes = GetPhotoBytes(fotoRutas[1]);
                byte[] photo3Bytes = GetPhotoBytes(fotoRutas[2]);
                byte[] photo4Bytes = GetPhotoBytes(fotoRutas[3]);

                // Crear el objeto FotosDepartamento con los datos del departamento y las fotos
                FotosDepartamento fotosDepartamento = new FotosDepartamento
                {
                    DepartmentCod = departmentCod,
                    Photo1 = photo1Bytes,
                    Photo2 = photo2Bytes,
                    Photo3 = photo3Bytes,
                    Photo4 = photo4Bytes
                };

                // Serializar el objeto FotosDepartamento a JSON
                string jsonData = JsonConvert.SerializeObject(fotosDepartamento);

                // Enviar la solicitud PUT a la API para actualizar las fotos del departamento
                string responseData = await apiManager.PutApiResponse($"api/Departamento/UpdateFotoDepartamento/{departmentCod}", jsonData);

                // Mostrar mensaje de éxito
                MessageBox.Show("Las fotos se han actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las fotos del departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateF1_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(0);
        }

        private void btnUpdateF2_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(1);
        }

        private void btnUpdateF3_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(2);
        }

        private void btnUpdateF4_Click(object sender, EventArgs e)
        {
            SeleccionarFoto(3);
        }


        private byte[] GetPhotoBytes(string rutaFoto)
        {
            if (string.IsNullOrEmpty(rutaFoto))
            {
                return null; // Si la ruta de la foto está vacía, retornar null
            }

            return File.ReadAllBytes(rutaFoto);
        }
    }
}
