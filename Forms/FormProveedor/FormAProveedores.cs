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
    public partial class FormAProveedores : Form
    {
        private AzureApiManager apiManager;
        public FormAProveedores()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si los campos obligatorios están vacíos
                if (string.IsNullOrWhiteSpace(txtRutEmpresa.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccionEmpresa.Text) ||
                    comboBoxComuna.SelectedItem == null)
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.");
                    return;
                }

                // Obtener el valor seleccionado del ComboBox de Comuna
                Comuna comunaSeleccionada = (Comuna)comboBoxComuna.SelectedItem;

                // Crear el objeto Proveedor con los valores ingresados y la comuna seleccionada
                Proveedor proveedor = new Proveedor
                {
                    CompanyId = txtRutEmpresa.Text,
                    CompanyName = txtNombreEmpresa.Text,
                    Address = txtDireccionEmpresa.Text,
                    CommuneName = comunaSeleccionada.ComunneName
                };

                // Llamar a la API para crear el proveedor
                await CrearProveedor(proveedor);

                MessageBox.Show("Proveedor creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el proveedor: " + ex.ToString());
            }
        }

        private async Task CrearProveedor(Proveedor proveedor)
        {
            try
            {
                // Serializar el objeto Proveedor a JSON
                string proveedorJson = JsonConvert.SerializeObject(proveedor);

                // Llamar a la API para crear el proveedor
                string responseData = await apiManager.PostApiResponse("api/Proveedor/CreateProveedor", proveedorJson);

                // Verificar si la llamada fue exitosa
                Console.WriteLine(responseData);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el proveedor: " + ex.Message);
            }
        }

        private async Task CargarComunas()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/comunas"
                string responseData = await apiManager.GetApiResponse("api/comunas");

                // Deserializar la respuesta JSON en una lista de Comuna
                List<Comuna> comunas = JsonConvert.DeserializeObject<List<Comuna>>(responseData);

                // Asignar las comunas al ComboBox
                comboBoxComuna.DataSource = comunas;
                comboBoxComuna.DisplayMember = "ComunneName";
                comboBoxComuna.ValueMember = "ComunneId";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener las comunas: " + ex.Message);
            }
        }

        private async void comboBoxComuna_DropDown(object sender, EventArgs e)
        {
            await CargarComunas();
        }

        private void txtRutEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla de retroceso
            if (e.KeyCode == Keys.Back)
            {
                // Permitir eliminar caracteres
                return;
            }

            // Verificar si se presionó una tecla numérica o un guión
            bool isNumeric = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isHyphen = e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract;
            bool isValidKey = isNumeric || isHyphen;

            // Rechazar la tecla si no es un número o un guión
            if (!isValidKey)
            {
                e.SuppressKeyPress = true;
            }

            // Verificar la longitud actual del texto
            string text = txtRutEmpresa.Text;
            bool hasHyphen = text.Contains('-');
            int length = text.Length;

            // Verificar si ya se ingresó un guión y si la longitud máxima permitida es alcanzada
            if (hasHyphen && (length >= 12 || (length >= 10 && !e.SuppressKeyPress)))
            {
                e.SuppressKeyPress = true; // Rechazar la tecla si se alcanza la longitud máxima
            }
            // Verificar si no se ingresó un guión y si la longitud máxima permitida es alcanzada
            else if (!hasHyphen && length >= 9 && !e.SuppressKeyPress)
            {
                e.SuppressKeyPress = true; // Rechazar la tecla si se alcanza la longitud máxima
            }
        }






    }
}
