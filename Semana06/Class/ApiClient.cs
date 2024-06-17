using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Semana06.Modulos;

namespace Semana06.Class
{
    internal class ApiClient : Menu
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Produto>> ConsultarApiExternaAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://fakestoreapi.com/products");
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();

                List<Produto> produtos = JsonSerializer.Deserialize<List<Produto>>(jsonResponse);
                return produtos;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro ao consultar API externa: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {e.Message}");
                return null;
            }
        }
    }
}
