using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NotificationService.Controllers
{
    [Route("api/notify")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendNotification([FromBody] UserDto user)
        {
            Console.WriteLine($"Notification sent to {user.Email}");
            return Ok("Notification sent");
        }
    }

    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
