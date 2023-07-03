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

namespace DashboardTurismoReal.FormProveedor
{
    public partial class FormVProveedores : Form
    {
        private AzureApiManager apiManager;
        private List<Proveedor> proveedores;

        public FormVProveedores()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

            // Configurar el modo de autocompletado del ComboBox
            comboBoxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void FormVProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los proveedores: " + ex.Message);
            }
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                await CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los proveedores: " + ex.Message);
            }
        }

        private async Task CargarProveedores()
        {
            // Obtener la respuesta de la API para el endpoint "api/Proveedor/GetAllProveedores"
            string responseData = await apiManager.GetApiResponse("api/Proveedor/GetAllProveedores");
            // Imprimir la respuesta JSON en la consola
            Console.WriteLine(responseData);

            // Deserializar la respuesta JSON en una lista de Proveedor
            proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(responseData);

            // Agregar los proveedores al DataGridView
            dataGridViewProveedores.DataSource = proveedores;

            // Obtener los RUT de los proveedores y agregarlos al ComboBox
            comboBoxProveedor.DataSource = proveedores.Select(p => p.CompanyId).ToList();
        }
        private void txtFiltroProveedorRUT_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox de filtro
            string filtroProveedorRUT = txtFiltroProveedorRUT.Text;

            // Obtén el origen de datos actual del DataGridView (lista de proveedores)
            List<Proveedor> proveedores = dataGridViewProveedores.DataSource as List<Proveedor>;

            // Filtra la lista de proveedores por el campo "CompanyId"
            List<Proveedor> proveedoresFiltrados = proveedores.Where(p => p.CompanyId.Contains(filtroProveedorRUT)).ToList();

            // Asigna los datos filtrados al DataGridView
            dataGridViewProveedores.DataSource = proveedoresFiltrados;
        }


        private void comboBoxProveedor_DropDown(object sender, EventArgs e)
        {
            // Actualizar los datos del ComboBox cuando se muestra el menú desplegable
            comboBoxProveedor.DataSource = proveedores.Select(p => p.CompanyId).ToList();
        }

        private async void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string companyId = comboBoxProveedor.Text;
                if (string.IsNullOrEmpty(companyId))
                {
                    MessageBox.Show("ID de proveedor inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Proveedor proveedor = proveedores.FirstOrDefault(p => p.CompanyId == companyId);
                if (proveedor == null)
                {
                    MessageBox.Show("El proveedor con ID " + companyId + " no existe.", "Proveedor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el proveedor con ID " + companyId + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string endpoint = "api/Proveedor/" + companyId;
                    string responseData = await apiManager.DeleteApiResponse(endpoint);
                    Console.WriteLine(responseData);

                    proveedores.Remove(proveedor);
                    dataGridViewProveedores.DataSource = null;
                    dataGridViewProveedores.DataSource = proveedores;

                    MessageBox.Show("El proveedor se eliminó correctamente.", "Proveedor eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
            }
        }
    }
}
