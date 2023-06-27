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
    }
}
