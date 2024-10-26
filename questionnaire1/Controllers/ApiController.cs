using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using questionnaire1.Models;

namespace questionnaire1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // Используем WebClient для простоты примера,
        // реальная интеграция может использовать другие методы
        private static readonly HttpClient client = new();

        [HttpPost]
        public void Post([FromBody] QuizResult result)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            var response = client.PostAsync("https://example.com/api/submitquiz", new StringContent(json)).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error submitting quiz results: {response.ReasonPhrase}");
            }
        }
    }
}
