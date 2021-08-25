using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserRepositoryApi.Business.Interfaces;

namespace UserRepositoryApi.App.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IUserService userService) {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("/api/Users")]
        public ActionResult GetAllUsers() {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("/api/Users/{id:int}")]
        public ActionResult GetUser(int id) {
            var user = _userService.GetUser(id);
            return Ok(user);
        }

        [HttpGet("/api/Users/{name}")]
        public ActionResult GetUser(string name) {
            var user = _userService.GetUser(name);
            return Ok(user);
        }

        [HttpGet("/api/Users/add/{name}")]
        public ActionResult AddUser(string name) {
            _userService.AddUser(name);
            return Ok();
        }

        [HttpGet("/api/Users/delete/{id:int}")]
        public ActionResult DeleteUser(int id) {
            _userService.DeleteUser(id);
            return Ok();
        }

    }
}
