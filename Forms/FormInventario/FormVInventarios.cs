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

namespace DashboardTurismoReal.FormInventario
{
    public partial class FormVInventarios : Form
    {
        private AzureApiManager apiManager;
        public FormVInventarios()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }
        private async void FormVInventarios_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "​/api​/Inventario​/GetAllInventarioDepartamentos"
                string responseData = await apiManager.GetApiResponse("api/Inventario/GetAllInventarioDepartamentos");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<InventarioDepartamento> inventarios = JsonConvert.DeserializeObject<List<InventarioDepartamento>>(responseData);

                // Agregar los departamentos al DataGridView
                dataGridViewInventarios.DataSource = inventarios;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los inventarios: " + ex.Message);
            }
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "​/api​/Inventario​/GetAllInventarioDepartamentos"
                string responseData = await apiManager.GetApiResponse("api/Inventario/GetAllInventarioDepartamentos");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<InventarioDepartamento> inventarios = JsonConvert.DeserializeObject<List<InventarioDepartamento>>(responseData);

                // Agregar los departamentos al DataGridView
                dataGridViewInventarios.DataSource = inventarios;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los inventarios: " + ex.Message);
            }
        }

        // AGREGAR INVENTARIOS

        private async Task CargarDepartamentos()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Departamento/GetAllDepartamentos"
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");

                // Deserializar la respuesta JSON en una lista de Departamento
                List<Departamento> departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

                // Filtrar la lista de departamentos que no tienen inventario asignado
                List<Departamento> departamentosSinInventario = departamentos.Where(d => string.IsNullOrEmpty(d.DepartmentInventory)).ToList();

                // Asignar los departamentos al ComboBox
                comboBoxCodDpto.DataSource = departamentosSinInventario;
                comboBoxCodDpto.DisplayMember = "DepartmentCod";
                comboBoxCodDpto.ValueMember = "DepartmentCod";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }

        private async void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el departamento seleccionado ya tiene un inventario asignado
                Departamento departamentoSeleccionado = (Departamento)comboBoxCodDpto.SelectedItem;
                if (!string.IsNullOrEmpty(departamentoSeleccionado.DepartmentInventory))
                {
                    MessageBox.Show("Este departamento ya tiene un inventario asignado.");
                    return;
                }

                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de asignar el inventario al departamento?", "Confirmar asignación de inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Obtener el código del departamento
                    string departamentoId = departamentoSeleccionado.DepartmentCod;

                    // Crear el objeto InventarioDepartamento con el código del departamento
                    InventarioDepartamento inventario = new InventarioDepartamento
                    {
                        DepartmentId = departamentoId
                    };

                    // Serializar el objeto InventarioDepartamento a JSON
                    string inventarioJson = JsonConvert.SerializeObject(inventario);

                    // Llamar a la API para agregar el inventario al departamento
                    string responseData = await apiManager.PostApiResponse("api/Inventario/Create", inventarioJson);

                    // Aquí puedes procesar la respuesta si es necesario

                    MessageBox.Show("Inventario agregado exitosamente al departamento.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al llamar a la API
                MessageBox.Show("Error al agregar el inventario al departamento: " + ex.ToString());
            }
        }



        private async void comboBoxCodDpto_DropDown(object sender, EventArgs e)
        {
            await CargarDepartamentos();
        }
    }
}
