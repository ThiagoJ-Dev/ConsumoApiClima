using ConsumoApiClima.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ConsumoApiClima.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _ChaveApi;


        public WeatherController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _ChaveApi = configuration["WeatherApi:ApiKey"];
        }

        public async Task<IActionResult>Index(string cidade )
        {
            if (string.IsNullOrEmpty(cidade))
            {
                return View();

            }

            var DadosClima = await ObterDadosClima(cidade);

            if (DadosClima == null)
            {
                ViewBag.MensagemErro = "Cidade não encontrada ou Erro na aplicação";
                return View();
            }

            return View(DadosClima);
        }

        private async Task<DadosClima>ObterDadosClima(string cidade) 
        {
            try
            {
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={_ChaveApi}&units=metric&lang=pt_br";

                var resposta = await _httpClient.GetStringAsync(url);

                if (resposta.Contains("city not found"))
                {
                    return null;
                }

                var dados = JObject.Parse(resposta);

                var clima = new DadosClima
                {
                    Cidade = dados["name"].ToString(),
                    Temperatura = dados["main"]["temp"].ToString() + "°C",
                    Condicao = dados["weather"][0]["description"].ToString(),
                    Umidade = dados["main"]["humidity"].ToString() + "%",
                    VelocidadeVento = dados["wind"]["speed"].ToString() + " m/s"
                };

                return clima;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter dados do clima: {ex.Message}");
                return null;
            }
        }


    } 
}
