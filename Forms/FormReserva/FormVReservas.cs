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

namespace DashboardTurismoReal.FormReserva
{
    public partial class FormVReservas : Form
    {
        private AzureApiManager apiManager;
        public FormVReservas()
        {
            InitializeComponent();
            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }
        private async void FormVReservas_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Reservas/GetAllReservas"
                string responseData = await apiManager.GetApiResponse("api/Reserva/GetAllReservas");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<Reserva> reservas = JsonConvert.DeserializeObject<List<Reserva>>(responseData);

                // Agregar los reservas al DataGridView
                dataGridViewReservas.DataSource = reservas;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener las reservas: " + ex.Message);
            }
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Reservas/GetAllReservas"
                string responseData = await apiManager.GetApiResponse("api/Reserva/GetAllReservas");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<Reserva> reservas = JsonConvert.DeserializeObject<List<Reserva>>(responseData);

                // Agregar los reservas al DataGridView
                dataGridViewReservas.DataSource = reservas;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener las reservas: " + ex.Message);
            }
        }
    }
}
