using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public UsersController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser()
        {
            // Dummy user
            var user = new
            {
                Name = "Noel",
                Email = "noel@test.com"
            };

            // Call Notification Service
            var response = await _httpClient.PostAsJsonAsync(
                "https://localhost:6001/api/notify",
                user
            );

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode(500, "User created but notification failed");
            }

            return Ok("User registered and notification sent");
        }
    }
}
