using DashboardTurismoReal.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardTurismoReal
{
    public partial class FormInicio : Form
    {
        private IConfiguration _configuration;
        private AzureApiManager apiManager;

        public FormInicio()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async void FormInicio_Load(object sender, EventArgs e)
        {
            try
            {
                Dashboard dashboard = await ObtenerDatosDashboard();

                // Asignar los valores a los Labels
                lblReservas.Text = dashboard.BookingTotal.ToString();
                lblDepartamentos.Text = dashboard.DepartmentTotal.ToString();
                lblIngresos.Text = "$" + dashboard.PayValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del panel de control: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task<Dashboard> ObtenerDatosDashboard()
        {
            string responseData = await apiManager.GetApiResponse("api/Dashboard");
            Dashboard dashboard = JsonConvert.DeserializeObject<Dashboard>(responseData);
            return dashboard;
        }

    }
}
