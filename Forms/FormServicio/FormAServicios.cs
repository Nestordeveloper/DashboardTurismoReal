using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DashboardTurismoReal.Models;

namespace DashboardTurismoReal.FormServicio
{
    public partial class FormAServicios : Form
    {
        private AzureApiManager apiManager;

        public FormAServicios()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async void btnCrearServicio_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados de los ComboBox
            Comuna comunaSeleccionada = (Comuna)comboBoxComuna.SelectedItem;
            Proveedor proveedorSeleccionado = (Proveedor)comboBoxProveedor.SelectedItem;
            TipoServicio tipoServicioSeleccionado = (TipoServicio)comboBoxTipoServicio.SelectedItem;

            // Crear una instancia de Servicio con los valores
            Servicio nuevoServicio = new Servicio
            {
                ServiceId = null,
                ServiceName = txtNombreServicio.Text,
                ServiceType = tipoServicioSeleccionado.ServiceType,
                CompanyRut = proveedorSeleccionado.CompanyId,
                CommuneId = null,
                ServiceTypeId = null,
                ServiceValue = int.Parse(txtValorServicio.Text),
                CommuneName = comunaSeleccionada.ComunneName
            };

            try
            {
                string jsonData = JsonConvert.SerializeObject(nuevoServicio);
                string responseData = await apiManager.PostApiResponse("api/Servicio", jsonData);

                MessageBox.Show("Servicio creado exitosamente");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el servicio: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreServicio.Text = "";
            txtValorServicio.Text = "";
            comboBoxRegion.SelectedIndex = -1;
            comboBoxProvincia.DataSource = null;
            comboBoxComuna.DataSource = null;
            comboBoxProveedor.DataSource = null;
            comboBoxTipoServicio.DataSource = null;
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
                string responseData = await apiManager.GetApiResponse("api/Region/GetAllRegions");

                List<Models.Region> regiones = JsonConvert.DeserializeObject<List<Models.Region>>(responseData);

                comboBoxRegion.DataSource = regiones;
                comboBoxRegion.DisplayMember = "RegionName";
                comboBoxRegion.ValueMember = "RegionId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las regiones: " + ex.Message);
            }
        }

        private async Task CargarProveedor()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/Proveedor/GetAllProveedores");

                List<Proveedor> proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(responseData);

                comboBoxProveedor.DataSource = proveedores;
                comboBoxProveedor.DisplayMember = "CompanyId";
                comboBoxProveedor.ValueMember = "CompanyId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los proveedores: " + ex.Message);
            }
        }

        private async Task CargarTipoServicio()
        {
            try
            {
                string responseData = await apiManager.GetApiResponse("api/TipoServicio");

                List<TipoServicio> tiposervicios = JsonConvert.DeserializeObject<List<TipoServicio>>(responseData);

                comboBoxTipoServicio.DataSource = tiposervicios;
                comboBoxTipoServicio.DisplayMember = "ServiceType";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los tipos de servicio: " + ex.Message);
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

        private async void comboBoxProveedor_DropDown(object sender, EventArgs e)
        {
            await CargarProveedor();
        }

        private async void comboBoxTipoServicio_DropDown(object sender, EventArgs e)
        {
            await CargarTipoServicio();
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
