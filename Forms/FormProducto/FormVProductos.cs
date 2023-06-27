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

namespace DashboardTurismoReal.FormProducto
{
    public partial class FormVProductos : Form
    {
        private AzureApiManager apiManager;
        private List<Producto> productos;

        public FormVProductos()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

            // Configurar el modo de autocompletado del ComboBox
            comboBoxProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void FormVProductos_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los productos: " + ex.Message);
            }
        }

        private async void comboBoxProducto_DropDown(object sender, EventArgs e)
        {
            try
            {
                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los productos: " + ex.Message);
            }
        }

        private async Task CargarProductos()
        {
            string responseData = await apiManager.GetApiResponse("api/Producto");
            productos = JsonConvert.DeserializeObject<List<Producto>>(responseData);
            comboBoxProducto.DataSource = productos.Select(p => p.ProductId).ToList();
            dataGridViewProductos.DataSource = productos;
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los productos: " + ex.Message);
            }
        }

        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string productoIdString = comboBoxProducto.Text;
                if (!int.TryParse(productoIdString, out int productoId))
                {
                    MessageBox.Show("ID de producto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Producto producto = productos.FirstOrDefault(p => p.ProductId == productoId);
                if (producto == null)
                {
                    MessageBox.Show("El producto con ID " + productoId + " no existe.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto con ID " + productoId + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string endpoint = "api/Producto/" + productoId;
                    string responseData = await apiManager.DeleteApiResponse(endpoint);
                    Console.WriteLine(responseData);

                    productos.Remove(producto);
                    dataGridViewProductos.DataSource = null;
                    dataGridViewProductos.DataSource = productos;

                    MessageBox.Show("El producto se eliminó correctamente.", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }
    }
}
