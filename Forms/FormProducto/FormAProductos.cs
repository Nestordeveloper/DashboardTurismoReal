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
    public partial class FormAProductos : Form
    {
        private AzureApiManager apiManager;
        public FormAProductos()
        {
            InitializeComponent();
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
        }

        private async void FormAProductos_Load(object sender, EventArgs e)
        {

        }

        private async void comboBoxCategoria_DropDown(object sender, EventArgs e)
        {
            await CargarCategorias();
        }

        private async void comboBoxInventario_DropDown(object sender, EventArgs e)
        {
            await CargarInventario();
        }

        private async Task CargarCategorias()
        {
            try
            {
                // Llamar a la API para obtener la lista de categorías
                string categoriasResponse = await apiManager.GetApiResponse("api/Categoria");
                List<Categoria> categorias = JsonConvert.DeserializeObject<List<Categoria>>(categoriasResponse);

                // Asignar la lista de categorías al ComboBox
                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.ToString());
            }
        }

        private async Task CargarInventario()
        {
            try
            {
                // Llamar a la API para obtener la lista de inventario
                string inventarioResponse = await apiManager.GetApiResponse("api/Inventario/GetAllInventarioDepartamentos");
                List<InventarioDepartamento> inventario = JsonConvert.DeserializeObject<List<InventarioDepartamento>>(inventarioResponse);

                // Asignar la lista de inventario al ComboBox
                comboBoxInventario.DataSource = inventario;
                comboBoxInventario.DisplayMember = "InventoryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.ToString());
            }
        }

        private async void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si los campos obligatorios están vacíos
                if (comboBoxInventario.SelectedItem == null ||
                    comboBoxCategoria.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.");
                    return;
                }

                // Obtener los valores seleccionados de los ComboBox
                InventarioDepartamento inventarioSeleccionado = (InventarioDepartamento)comboBoxInventario.SelectedItem;
                Categoria categoriaSeleccionada = (Categoria)comboBoxCategoria.SelectedItem;
                string nombreProducto = txtNombreProducto.Text;

                // Crear el objeto Producto con los valores seleccionados y demás datos ingresados
                Producto producto = new Producto
                {
                    InventoryId = inventarioSeleccionado.InventoryId,
                    CategoryName = categoriaSeleccionada.CategoryName,
                    ProductName = nombreProducto
                };

                // Serializar el objeto Producto a JSON
                string productoJson = JsonConvert.SerializeObject(producto);

                // Llamar a la API para crear el producto
                try
                {
                    string responseData = await apiManager.PostApiResponse("api/Producto/CreateProducto", productoJson);

                    // Aquí puedes procesar la respuesta si es necesario

                    MessageBox.Show("Producto creado correctamente.");
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra al llamar a la API
                    MessageBox.Show("Error al crear el producto: " + ex.ToString());
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro error
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
