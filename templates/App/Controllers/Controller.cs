using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROJECTNAME.Business;

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

        [HttpGet("/api/ITEMs/{id}")]
        public ActionResult GetITEMs(int id) {
            var iTEMs = _iTEMService.GetITEM(id);
            return Ok(iTEMs);
        }

    }
}
