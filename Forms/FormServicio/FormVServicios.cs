using DashboardTurismoReal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardTurismoReal.FormServicio
{
    public partial class FormVServicios : Form
    {
        private AzureApiManager apiManager;
        private List<Servicio> servicios;
        private List<Departamento> departamentos;

        public FormVServicios()
        {
            InitializeComponent();
            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

            // Configurar el modo de autocompletado del ComboBox
            comboBoxServicio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxServicio.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void FormVServicios_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarServiciosDpto();
                await CargarServicios();
                await CargarDepartamentos();
                await CargarServicioDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private async Task CargarDepartamentos()
        {
            // Obtener la respuesta de la API para el endpoint "api/Departamento/GetAllDepartamentos"
            string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");
            // Imprimir la respuesta JSON en la consola
            Console.WriteLine(responseData);

            // Deserializar la respuesta JSON en una lista de Departamento
            departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

            // Obtener los códigos de los departamentos y agregarlos al ComboBox
            comboBoxDpto.DataSource = departamentos.Select(d => d.DepartmentCod).ToList();
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                await CargarServicios();
                await CargarDepartamentos();
                await CargarServicioDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }

        private async Task CargarServicios()
        {
            // Obtener la respuesta de la API para el endpoint "api/Servicio"
            string responseData = await apiManager.GetApiResponse("api/Servicio");
            // Imprimir la respuesta JSON en la consola
            Console.WriteLine(responseData);

            // Deserializar la respuesta JSON en una lista de Servicio
            servicios = JsonConvert.DeserializeObject<List<Servicio>>(responseData);

            // Obtener los ID de los servicios y agregarlos al ComboBox
            comboBoxServicio.DataSource = servicios.Select(s => s.ServiceId).ToList();

            // Agregar los servicios al DataGridView
            dataGridViewServicios.DataSource = servicios;
        }

        private void txtFiltroServicioNombre_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox de filtro
            string filtroServicioNombre = txtFiltroServicioNombre.Text;

            // Obtén el origen de datos actual del DataGridView (lista de servicios)
            List<Servicio> servicios = dataGridViewServicios.DataSource as List<Servicio>;

            // Filtra la lista de servicios por el campo "ServiceName"
            List<Servicio> serviciosFiltrados = servicios.Where(s => s.ServiceName.Contains(filtroServicioNombre)).ToList();

            // Asigna los datos filtrados al DataGridView
            dataGridViewServicios.DataSource = serviciosFiltrados;
        }

        private async Task CargarServicioDepartamentos()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/ServicioDepartamento");

                List<ServicioDepartamento> servicioDepartamentos = JsonConvert.DeserializeObject<List<ServicioDepartamento>>(responseData);

                dataGridViewServicioDepartamentos.DataSource = servicioDepartamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de ServicioDepartamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                string servicioIdString = comboBoxServicio.Text;
                if (!int.TryParse(servicioIdString, out int servicioId))
                {
                    MessageBox.Show("ID de servicio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Servicio servicio = servicios.FirstOrDefault(s => s.ServiceId == servicioId);
                if (servicio == null)
                {
                    MessageBox.Show("El servicio con ID " + servicioId + " no existe.", "Servicio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el servicio con ID " + servicioId + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string endpoint = "api/Servicio/" + servicioId;
                    string responseData = await apiManager.DeleteApiResponse(endpoint);
                    Console.WriteLine(responseData);

                    servicios.Remove(servicio);
                    dataGridViewServicios.DataSource = null;
                    dataGridViewServicios.DataSource = servicios;

                    MessageBox.Show("El servicio se eliminó correctamente.", "Servicio eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el servicio: " + ex.Message);
            }
        }

        private async void comboBoxServicio_DropDown(object sender, EventArgs e)
        {
            try
            {
                await CargarServicios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los servicios: " + ex.Message);
            }
        }

        private async void btnAsignarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentCode = comboBoxDpto.Text;
                int serviceId = Convert.ToInt32(comboBoxDptoServicio.Text);

                Departamento departamento = departamentos.FirstOrDefault(d => d.DepartmentCod == departmentCode);
                if (departamento == null)
                {
                    MessageBox.Show("El departamento con código " + departmentCode + " no existe.", "Departamento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Servicio servicio = servicios.FirstOrDefault(s => s.ServiceId == serviceId);
                if (servicio == null)
                {
                    MessageBox.Show("El servicio con ID " + serviceId + " no existe.", "Servicio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el servicio ya está asociado al departamento
                bool isAlreadyAssigned = await CheckServiceDepartmentAssignment(departmentCode, serviceId);
                if (isAlreadyAssigned)
                {
                    MessageBox.Show("El servicio ya está asociado al departamento.", "Asignación duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServicioDepartamento servicioDepartamento = new ServicioDepartamento
                {
                    DepartmentId = departamento.DepartmentCod,
                    ServiceId = serviceId
                };

                string requestData = JsonConvert.SerializeObject(servicioDepartamento);
                string responseData = await apiManager.PostApiResponse("api/ServicioDepartamento", requestData);
                Console.WriteLine(responseData);

                MessageBox.Show("El servicio se asignó correctamente al departamento.", "Servicio asignado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el servicio: " + ex.Message);
            }
        }

        private async Task<bool> CheckServiceDepartmentAssignment(string departmentCode, int serviceId)
        {
            string endpoint = $"api/ServicioDepartamento/{departmentCode}/{serviceId}";
            string responseData = await apiManager.GetApiResponse(endpoint);
            return !string.IsNullOrEmpty(responseData);
        }

        private async Task<List<Servicio>> CargarServiciosDpto()
        {
            string responseData = await apiManager.GetApiResponse("api/Servicio");
            Console.WriteLine(responseData);

            servicios = JsonConvert.DeserializeObject<List<Servicio>>(responseData);

            comboBoxDptoServicio.DataSource = servicios;
            comboBoxDptoServicio.DisplayMember = "ServiceId";
            comboBoxDptoServicio.ValueMember = "ServiceId";

            return servicios;
        }

    }
}
