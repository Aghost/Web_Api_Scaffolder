using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROJECTNAME.Business.Interfaces;

namespace PROJECTNAME.App.Controllers
{
    [ApiController]
    public class ITEMsController : ControllerBase
    {
        private readonly ILogger<ITEMsController> _logger;
        private readonly IITEMService _iTEMService;

        public ITEMsController(ILogger<ITEMsController> logger, IITEMService iTEMService) {
            _logger = logger;
            _iTEMService = iTEMService;
        }

        [HttpGet("/api/ITEMs")]
        public ActionResult GetAllITEMs() {
            var iTEMs = _iTEMService.GetAllITEMs();
            return Ok(iTEMs);
        }

        [HttpGet("/api/ITEMs/{id:int}")]
        public ActionResult GetITEM(int id) {
            var iTEM = _iTEMService.GetITEM(id);
            return Ok(iTEM);
        }

        [HttpGet("/api/ITEMs/{name}")]
        public ActionResult GetITEM(string name) {
            var iTEM = _iTEMService.GetITEM(name);
            return Ok(iTEM);
        }

        [HttpGet("/api/ITEMs/add/{name}")]
        public ActionResult AddITEM(string name) {
            _iTEMService.AddITEM(name);
            return Ok();
        }

        [HttpGet("/api/ITEMs/delete/{id:int}")]
        public ActionResult DeleteITEM(int id) {
            _iTEMService.DeleteITEM(id);
            return Ok();
        }

    }
}
