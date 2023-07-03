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

namespace DashboardTurismoReal.FormUsuario
{
    public partial class FormVUsuarios : Form
    {
        private AzureApiManager apiManager;
        private List<Usuario> usuarios;
        private List<Rol> roles;
        private bool comboBoxRutEnabled = true; // Variable para controlar el estado del ComboBox de Rut

        public FormVUsuarios()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");

            // Configurar el modo de autocompletado del ComboBox de Rut
            comboBoxRut.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRut.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Configurar el modo de autocompletado del ComboBox de Rol
            comboBoxRol.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRol.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void FormVUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }

            await CargarRoles();
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }
        }

        private void txtFiltroRut_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto del TextBox de filtro
            string filtroRut = txtFiltroRut.Text;

            // Filtra la lista de usuarios por el campo "Rut"
            List<Usuario> usuariosFiltrados = usuarios.Where(u => u.Rut.Contains(filtroRut)).ToList();

            // Actualiza el origen de datos del DataGridView con los usuarios filtrados
            dataGridViewUsuarios.DataSource = usuariosFiltrados;
        }

        private async Task CargarUsuarios()
        {
            // Deshabilitar el ComboBox de Rut
            comboBoxRutEnabled = false;
            comboBoxRut.Enabled = false;

            // Obtener la respuesta de la API para el endpoint "api/Usuario/GetAllUsuarios"
            string responseData = await apiManager.GetApiResponse("api/Usuario/GetAllUsuarios");
            // Imprimir la respuesta JSON en la consola
            Console.WriteLine(responseData);

            // Deserializar la respuesta JSON en una lista de Usuario
            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(responseData);

            // Agregar los usuarios al DataGridView
            dataGridViewUsuarios.DataSource = usuarios;

            // Obtener los RUT de los usuarios y agregarlos al ComboBox de Rut
            comboBoxRut.DataSource = usuarios.Select(u => u.Rut).ToList();
            comboBoxRutDelete.DataSource = usuarios.Select(u => u.Rut).ToList();

            // Habilitar el ComboBox de Rut
            comboBoxRutEnabled = true;
            comboBoxRut.Enabled = true;
        }

        private async Task CargarRoles()
        {
            // Obtener la respuesta de la API para el endpoint "api/Rol/GetAllRoles"
            string responseData = await apiManager.GetApiResponse("api/Rol/GetAllRoles");
            // Imprimir la respuesta JSON en la consola
            Console.WriteLine(responseData);

            // Deserializar la respuesta JSON en una lista de Rol
            roles = JsonConvert.DeserializeObject<List<Rol>>(responseData);

            // Agregar los roles al ComboBox de Rol
            comboBoxRol.DataSource = roles.Select(r => r.Name).ToList();
        }

        private async void btnActualizarRol_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = comboBoxRut.Text;
                string rol = comboBoxRol.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show("Por favor, seleccione un RUT y un Rol.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Buscar el usuario por su RUT
                Usuario usuario = usuarios.FirstOrDefault(u => u.Rut == rut);

                if (usuario == null)
                {
                    MessageBox.Show("No se encontró un usuario con el RUT especificado.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar el rol del usuario
                usuario.Rol = rol;
                usuario.idRol = roles.FirstOrDefault(r => r.Name == rol)?.RoleId ?? 0;

                // Serializar el usuario actualizado en formato JSON
                string jsonUsuario = JsonConvert.SerializeObject(usuario);

                // Enviar la solicitud de actualización a la API
                await apiManager.PutApiResponse($"/api/Usuario/UpdateRol/{rut}", jsonUsuario);

                MessageBox.Show("El rol del usuario se actualizó correctamente.", "Rol actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el rol del usuario: " + ex.Message);
            }

            await CargarUsuarios();
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = comboBoxRutDelete.Text;

                if (string.IsNullOrEmpty(rut))
                {
                    MessageBox.Show("Por favor, seleccione un RUT.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Buscar el usuario por su RUT
                Usuario usuario = usuarios.FirstOrDefault(u => u.Rut == rut);

                if (usuario == null)
                {
                    MessageBox.Show("No se encontró un usuario con el RUT especificado.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar la eliminación del usuario
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Enviar la solicitud de eliminación a la API
                    await apiManager.DeleteApiResponse($"api/Usuario/DeleteUsuario/{rut}");

                    MessageBox.Show("El usuario se eliminó correctamente.", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el ComboBox de Rut y recargar los usuarios
                    comboBoxRutDelete.DataSource = null;
                    await CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void comboBoxRut_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rut = comboBoxRut.SelectedValue?.ToString();

            // Buscar el usuario por su RUT
            Usuario usuario = usuarios.FirstOrDefault(u => u.Rut == rut);

            if (usuario != null)
            {
                // Habilitar el ComboBox de Rol
                comboBoxRol.Enabled = true;

                // Obtener el nombre del rol del usuario
                string rol = usuario.Rol;

                if (comboBoxRol.Items.Count > 0)
                {
                    // Seleccionar el rol en el ComboBox de Rol
                    comboBoxRol.SelectedItem = rol;
                }
            }
            else
            {
                // Si no se encuentra el usuario, deshabilitar el ComboBox de Rol
                comboBoxRol.Enabled = false;
            }
        }

        private async void comboBoxRol_DropDown(object sender, EventArgs e)
        {
            try
            {
                await CargarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los roles: " + ex.Message);
            }
        }
    }
}
