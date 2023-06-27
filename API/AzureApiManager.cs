using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DashboardTurismoReal
{
    public class AzureApiManager
    {
        private string apiUrl;
        private HttpClient httpClient;

        public AzureApiManager(string apiUrl)
        {
            this.apiUrl = apiUrl;
            this.httpClient = new HttpClient();
        }

        public async Task<string> GetApiResponse(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return responseData;
                }
                else
                {
                    throw new Exception("No se pudo obtener la respuesta de la API. Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la respuesta de la API: " + ex.Message);
            }
        }

        public async Task<string> PostApiResponse(string endpoint, string jsonData)
        {
            try
            {
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl + endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return responseData;
                }
                else
                {
                    throw new Exception("No se pudo obtener la respuesta de la API. Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la respuesta de la API: " + ex.Message);
            }
        }

        public async Task<string> PutApiResponse(string endpoint, string jsonData)
        {
            try
            {
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(apiUrl + endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return responseData;
                }
                else
                {
                    throw new Exception("No se pudo obtener la respuesta de la API. Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la respuesta de la API: " + ex.Message);
            }
        }

        public async Task<string> DeleteApiResponse(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return responseData;
                }
                else
                {
                    throw new Exception("No se pudo obtener la respuesta de la API. Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la respuesta de la API: " + ex.Message);
            }
        }
    }
}
