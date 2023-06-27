using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DashboardTurismoReal.Models;
using Newtonsoft.Json;

namespace DashboardTurismoReal
{
    public partial class FormVDepartamentos : Form
    {
        private AzureApiManager apiManager;
        private List<EstadoDepartamento> estadosDepartamento;

        public FormVDepartamentos()
        {
            InitializeComponent();

            // Inicializar AzureApiManager con la URL base de la API
            apiManager = new AzureApiManager("https://deploy-backend-turismoreal.azurewebsites.net/");
            CargarEstadosDepartamento();
        }

        private async void FormVDepartamentos_Load(object sender, EventArgs e)
        {
            await CargarDatosDepartamentos();
        }

        private async void btnCargarDatos_Click(object sender, EventArgs e)
        {
            await CargarDatosDepartamentos();
        }

        private async Task CargarDatosDepartamentos()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Departamento/GetAllDepartamentos"
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");
                // Imprimir la respuesta JSON en la consola
                Console.WriteLine(responseData);

                // Deserializar la respuesta JSON en una lista de Departamento
                List<Departamento> departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

                // Agregar los departamentos al DataGridView
                dataGridViewDepartamentos.DataSource = departamentos;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }

        private void dataGridViewDepartamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDepartamentos.Columns[e.ColumnIndex].Name == "DepartmentStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Disponible")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (status == "No Disponible")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (status == "Mantenimiento" || status == "Reservado")
                    {
                        e.CellStyle.ForeColor = Color.Blue;
                    }
                }
            }
        }

        // --- Actualizar Departamento

        private async void btnModificarDpto_Click(object sender, EventArgs e)
        {
            await ActualizarDepartamento();
        }

        private async Task ActualizarDepartamento()
        {
            string jsonData = string.Empty;
            try
            {
                // Obtener el código del departamento seleccionado desde el ComboBox
                string codDepartamento = ((Departamento)comboBoxDpto.SelectedItem).DepartmentCod;

                // Obtener el departamento seleccionado de la lista de departamentos
                Departamento departamento = dataGridViewDepartamentos.SelectedRows[0].DataBoundItem as Departamento;
                EstadoDepartamento estadoDepartamento = comboBoxEstado.SelectedItem as EstadoDepartamento;

                // Crear un objeto auxiliar con los campos necesarios
                var departamentoUpdate = new
                {
                    DepartmentCod = codDepartamento,
                    DepartmentDesc = txtDescripcion.Text,
                    DepartmentDailyValue = int.TryParse(txtValorDiario.Text, out int value) ? value : departamento.DepartmentDailyValue,
                    DepartmentStatus = estadoDepartamento.StateDepartmentName
                };

                // Serializar el objeto auxiliar a formato JSON
                jsonData = JsonConvert.SerializeObject(departamentoUpdate);

                // Construir el endpoint para la solicitud PUT
                string endpoint = $"api/Departamento/{codDepartamento}";

                // Enviar la solicitud PUT a la API con los datos actualizados
                string responseData = await apiManager.PutApiResponse(endpoint, jsonData);

                // Verificar si la respuesta indica una actualización exitosa
                if (!string.IsNullOrEmpty(responseData))
                {
                    // Actualización exitosa
                    MessageBox.Show("Departamento actualizado exitosamente");
                    LimpiarFormulario();
                    await CargarDatosDepartamentos(); // Opcional: Volver a cargar los departamentos después de la actualización
                }
                else
                {
                    // La API no devolvió una respuesta válida
                    MessageBox.Show("Error al actualizar el departamento: no se recibió una respuesta válida de la API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el departamento: " + jsonData + "\n\nError: " + ex.Message);
            }
        }





        private void LimpiarFormulario()
        {
            comboBoxDpto.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
            txtDescripcion.Clear();
            txtValorDiario.Clear();
        }

        private async void comboBoxDpto_DropDown(object sender, EventArgs e)
        {
            try
            {
                // Cargar los departamentos en el ComboBox
                await CargarDepartamentos();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }

        private async void comboBoxEstado_DropDown(object sender, EventArgs e)
        {
            try
            {
                // Cargar los estados de departamento en el ComboBox
                await CargarEstadosDepartamento();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los estados de departamento: " + ex.Message);
            }
        }


        private async Task CargarDepartamentos()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/Departamento/GetAllDepartamentos"
                string responseData = await apiManager.GetApiResponse("api/Departamento/GetAllDepartamentos");

                // Deserializar la respuesta JSON en una lista de Departamento
                List<Departamento> departamentos = JsonConvert.DeserializeObject<List<Departamento>>(responseData);

                // Agregar los departamentos al ComboBox
                comboBoxDpto.DataSource = departamentos;
                comboBoxDpto.DisplayMember = "DepartmentCod";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los departamentos: " + ex.Message);
            }
        }

        private async Task CargarEstadosDepartamento()
        {
            try
            {
                // Obtener la respuesta de la API para el endpoint "api/EstadoDepartamento/GetAllEstadoDepartamento"
                string responseData = await apiManager.GetApiResponse("api/EstadoDepartamento/GetAllEstadoDepartamento");

                // Deserializar la respuesta JSON en una lista de EstadoDepartamento
                estadosDepartamento = JsonConvert.DeserializeObject<List<EstadoDepartamento>>(responseData);

                // Agregar los estados de departamento al ComboBox
                comboBoxEstado.DataSource = estadosDepartamento;
                comboBoxEstado.DisplayMember = "StateDepartmentName";
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra al obtener los datos de la API
                MessageBox.Show("Error al obtener los estados de departamento: " + ex.Message);
            }
        }

        private async void comboBoxDpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDpto.SelectedItem != null)
            {
                try
                {
                    // Obtener el departamento seleccionado directamente del ComboBox
                    Departamento departamento = comboBoxDpto.SelectedItem as Departamento;

                    // Mostrar los valores del departamento en los controles correspondientes
                    comboBoxEstado.SelectedItem = estadosDepartamento.FirstOrDefault(ed => ed.StateDepartmentName == departamento.DepartmentStatus);
                    txtDescripcion.Text = departamento.DepartmentDesc;
                    txtValorDiario.Text = departamento.DepartmentDailyValue.ToString();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra al obtener los datos de la API
                    MessageBox.Show("Error al obtener los detalles del departamento: " + ex.Message);
                }
            }
        }
    }
}
