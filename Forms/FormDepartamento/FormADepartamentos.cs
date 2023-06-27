using DashboardTurismoReal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardTurismoReal
{
    public partial class FormADepartamentos : Form
    {
        private AzureApiManager apiManager;

        public FormADepartamentos()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async Task CargarComunas(int provinceId)
        {
            try
            {
                string endpoint = $"api/comunas/{provinceId}";
                string responseData = await apiManager.GetApiResponse(endpoint);

                List<Comuna> comunas = JsonConvert.DeserializeObject<List<Comuna>>(responseData);

                comboBoxComuna.DataSource = comunas;
                comboBoxComuna.DisplayMember = "ComunneName";
                comboBoxComuna.ValueMember = "ComunneId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las comunas: " + ex.Message);
            }
        }


        private async Task CargarProvincias(int regionId)
        {
            try
            {
                string endpoint = $"api/Provincia/GetProvincia/{regionId}";
                string responseData = await apiManager.GetApiResponse(endpoint);

                List<Provincia> provincias = JsonConvert.DeserializeObject<List<Provincia>>(responseData);

                comboBoxProvincia.DataSource = provincias;
                comboBoxProvincia.DisplayMember = "ProvinceName";
                comboBoxProvincia.ValueMember = "ProvinceId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las provincias: " + ex.Message);
            }
        }


        private async Task CargarRegiones()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Region/GetAllRegions"
                string responseData = await apiManager.GetApiResponse("api/Region/GetAllRegions");

                // Deserializar la respuesta JSON en una lista de Region
                List<Models.Region> regiones = JsonConvert.DeserializeObject<List<Models.Region>>(responseData);

                // Asignar las regiones al ComboBox
                comboBoxRegion.DataSource = regiones;
                comboBoxRegion.DisplayMember = "RegionName";
                comboBoxRegion.ValueMember = "RegionId";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener las regiones: " + ex.Message);
            }
        }

        private async void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegion.SelectedItem != null)
            {
                Models.Region regionSeleccionada = (Models.Region)comboBoxRegion.SelectedItem;
                await CargarProvincias(regionSeleccionada.RegionId);
            }
        }
        private async void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedItem != null)
            {
                Provincia provinciaSeleccionada = (Provincia)comboBoxProvincia.SelectedItem;
                await CargarComunas(provinciaSeleccionada.ProvinceId);
            }
        }



        private async void FormADepartamentos_Load(object sender, EventArgs e)
        {

        }

        private async void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si los campos obligatorios están vacíos
                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtValorDiario.Text) ||
                    comboBoxComuna.SelectedItem == null ||
                    comboBoxRegion.SelectedItem == null)
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.");
                    return;
                }

                // Obtener los valores seleccionados de los ComboBox
                Comuna comunaSeleccionada = (Comuna)comboBoxComuna.SelectedItem;
                Models.Region regionSeleccionada = (Models.Region)comboBoxRegion.SelectedItem;

                // Crear el objeto Departamento con los valores seleccionados
                Departamento departamento = new Departamento
                {
                    DepartmentCod = null,
                    DepartmentName = txtNombreDepartamento.Text,
                    DepartmentDesc = txtDescripcion.Text,
                    DepartmentInventory = null,
                    DepartmentDailyValue = Convert.ToInt32(txtValorDiario.Text),
                    DepartmentStatus = null,
                    DepartmentValueBooking = null,
                    DepartmentCommune = null,
                    DepartmentRegion = null,
                    DepartmentIdStatus = null,
                    DepartmentCommuneName = comunaSeleccionada.ComunneName,
                    DepartmentRegionName = regionSeleccionada.RegionName
                };

                try
                {
                    // Serializar el objeto Departamento a JSON
                    string departamentoJson = JsonConvert.SerializeObject(departamento);

                    // Llamar a la API para crear el departamento
                    string responseData = await apiManager.PostApiResponse("api/Departamento/CreateDepartamento", departamentoJson);

                    // Verificar si la llamada fue exitosa
                    MessageBox.Show("Departamento creado correctamente.", "Crear Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra al llamar a la API
                    MessageBox.Show("Error al crear el departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error
                MessageBox.Show("Error al crear el departamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorDiario_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó una tecla numérica o la tecla Backspace
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                || e.KeyCode == Keys.Back)
            {
                // Obtener el texto actual del TextBox
                string currentText = txtValorDiario.Text;

                // Verificar si se presionó la tecla Backspace y la longitud actual del texto es igual a 7
                if (e.KeyCode == Keys.Back && currentText.Length == 8)
                {
                    e.SuppressKeyPress = true; // Ignorar la tecla Backspace
                }
                else
                {
                    // Verificar si el texto resultante excederá la longitud máxima de 7 cifras
                    if ((currentText + e.KeyValue.ToString()).Length > 8)
                    {
                        e.SuppressKeyPress = true; // Ignorar la tecla presionada
                    }
                }
            }
            else
            {
                e.SuppressKeyPress = true; // Ignorar cualquier otra tecla no permitida
            }
        }
        private async void comboBoxProvincia_DropDown(object sender, EventArgs e)
        {
            if (comboBoxRegion.SelectedItem != null)
            {
                Models.Region regionSeleccionada = (Models.Region)comboBoxRegion.SelectedItem;
                await CargarProvincias(regionSeleccionada.RegionId);
            }
        }

        private async void comboBoxComuna_DropDown(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedItem != null)
            {
                Provincia provinciaSeleccionada = (Provincia)comboBoxProvincia.SelectedItem;
                await CargarComunas(provinciaSeleccionada.ProvinceId);
            }
        }

        private async void comboBoxRegion_DropDown(object sender, EventArgs e)
        {
            await CargarRegiones();
        }
    }
}
