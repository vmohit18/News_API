using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace News_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class News : ControllerBase
    {
        private readonly ILogger<News> _logger;

        public News(ILogger<News> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            //implement exception handling and use _logger to log exceptions
            try
            {
                // Call the News API and retrieve the top headlines for the US business category
                var url = "https://newsapi.org/v2/top-headlines?country=us&category=business&apiKey=7ab65c8d70d54b779440eb361565ad02";

                // Create a new HttpClient instance
                var client = new HttpClient();

                // Set the User-Agent header to identify the request as coming from a C# console program
                client.DefaultRequestHeaders.Add("User-Agent", "C# console program");

                // Send a GET request to the News API and retrieve the response
                var response = client.GetAsync(url).Result;

                // Read the response content as a string
                var content = response.Content.ReadAsStringAsync().Result;

                // Return the response content as JSON
                return content;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the news");
                return string.Empty;
            }
        }

        [HttpGet]
        [Route("everything")]
        public string GetEverything()
        {
            //implement exception handling and use _logger to log exceptions
            try
            {
                // Call the News API and retrieve all the articles about Bitcoin
                var url = "https://newsapi.org/v2/everything?q=bitcoin&apiKey=7ab65c8d70d54b779440eb361565ad02";

                // Create a new HttpClient instance
                var client = new HttpClient();

                // Set the User-Agent header to identify the request as coming from a C# console program
                client.DefaultRequestHeaders.Add("User-Agent", "C# console program");

                // Send a GET request to the News API and retrieve the response
                var response = client.GetAsync(url).Result;

                // Read the response content as a string
                var content = response.Content.ReadAsStringAsync().Result;

                // Return the response content as JSON
                return content;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the news");
                return string.Empty;
            }
        }
    }
}
