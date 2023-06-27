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

namespace DashboardTurismoReal.Forms.FormChecks
{
    public partial class FormVCheckIn : Form
    {
        private AzureApiManager apiManager;
        public FormVCheckIn()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }
        private async void FormVCheckIn_Load(object sender, EventArgs e)
        {
            await CargarDatosCheckin();
        }

        private async Task CargarDatosCheckin()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/CheckIn"
                string responseData = await apiManager.GetApiResponse("api/CheckIn");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<CheckIn> checkin = JsonConvert.DeserializeObject<List<CheckIn>>(responseData);

                // Agregar los departamentos al DataGridView
                dataGridViewCheckIn.DataSource = checkin;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            await CargarDatosCheckin();
        }
    }
}
