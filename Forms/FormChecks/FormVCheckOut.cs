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
    public partial class FormVCheckOut : Form
    {
        private AzureApiManager apiManager;
        public FormVCheckOut()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }
        private async void FormVCheckOut_Load(object sender, EventArgs e)
        {
            await CargarDatosCheckout();
        }

        private async Task CargarDatosCheckout()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/CheckIn"
                string responseData = await apiManager.GetApiResponse("api/Checkout");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<CheckOut> checkout = JsonConvert.DeserializeObject<List<CheckOut>>(responseData);

                // Agregar los departamentos al DataGridView
                dataGridViewCheckOut.DataSource = checkout;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }
        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            await CargarDatosCheckout();
        }
    }
}
