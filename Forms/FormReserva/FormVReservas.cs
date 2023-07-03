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
        private List<Reserva> reservas;
        private List<EstadoReserva> estadosReserva;

        public FormVReservas()
        {
            InitializeComponent();
            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async void FormVReservas_Load(object sender, EventArgs e)
        {
            await CargarReservas();
            await CargarEstadosReserva();
        }

        private async Task CargarReservas()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Reserva/GetAllReservas"
                string responseData = await apiManager.GetApiResponse("api/Reserva/GetAllReservas");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Reserva
                reservas = JsonConvert.DeserializeObject<List<Reserva>>(responseData);

                // Agregar las reservas al DataGridView
                dataGridViewReservas.DataSource = reservas;

                // Llenar el ComboBoxReserva con las reservas
                comboBoxReserva.DataSource = reservas;
                comboBoxReserva.DisplayMember = "NombreReserva";
                comboBoxReserva.ValueMember = "BookingId";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener las reservas: " + ex.Message);
            }
        }
        private void txtFiltroRUTReserva_TextChanged(object sender, EventArgs e)
        {
            // Obtén el RUT del TextBox de filtro
            string filtroRUTReserva = txtFiltroRUTReserva.Text;

            // Obtén el origen de datos actual del DataGridView (lista de reservas)
            List<Reserva> reservas = dataGridViewReservas.DataSource as List<Reserva>;

            // Filtra la lista de reservas por el campo "RUT"
            List<Reserva> reservasFiltradas = reservas.Where(r => r.RUT.Contains(filtroRUTReserva)).ToList();

            // Asigna los datos filtrados al DataGridView
            dataGridViewReservas.DataSource = reservasFiltradas;
        }

        private async Task CargarEstadosReserva()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/EstadoReserva/GetAllEstadoReserva"
                string responseData = await apiManager.GetApiResponse("api/EstadoReserva/GetAllEstadoReserva");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de EstadoReserva
                estadosReserva = JsonConvert.DeserializeObject<List<EstadoReserva>>(responseData);

                // Llenar el ComboBoxEstadoReserva con los estados de reserva
                comboBoxEstadoReserva.DataSource = estadosReserva;
                comboBoxEstadoReserva.DisplayMember = "StatusBookingName";
                comboBoxEstadoReserva.ValueMember = "StatusBookingId";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los estados de reserva: " + ex.Message);
            }
        }

        private async void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la reserva seleccionada en el ComboBoxReserva
                Reserva reservaSeleccionada = comboBoxReserva.SelectedItem as Reserva;

                if (reservaSeleccionada == null)
                {
                    MessageBox.Show("Seleccione una reserva");
                    return;
                }

                // Obtener el estado de reserva seleccionado en el ComboBoxEstadoReserva
                EstadoReserva estadoReservaSeleccionado = comboBoxEstadoReserva.SelectedItem as EstadoReserva;

                if (estadoReservaSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un estado de reserva");
                    return;
                }

                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de cambiar el estado de la reserva?", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Actualizar el estado de la reserva utilizando la API
                    string endpoint = $"api/Reserva/UpdateBooking/{reservaSeleccionada.BookingId}";
                    var requestData = new
                    {
                        bookingId = reservaSeleccionada.BookingId,
                        bookingStatus = estadoReservaSeleccionado.StatusBookingName
                    };
                    string jsonRequest = JsonConvert.SerializeObject(requestData);
                    await apiManager.PutApiResponse(endpoint, jsonRequest);

                    // Actualización exitosa
                    MessageBox.Show("Estado de reserva actualizado correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver a cargar las reservas para reflejar los cambios
                    await CargarReservas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
