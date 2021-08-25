using Microsoft.AspNetCore.Mvc;
using PROJECTNAME.Data;
using PROJECTNAME.Business.Interfaces;

namespace PROJECTNAME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishNumberController : ControllerBase
    {
        private readonly IEnglishNumberService englishNumberService;

        public EnglishNumberController(IEnglishNumberService englishNumberService) {
            this.englishNumberService = englishNumberService;
        }

        [HttpGet]
        [Route("ToEnglish/{number}")]
        public IActionResult ToEnglishNumber(string number) {
            return Ok(englishNumberService.NumberToEnglish(number));
        }
    }
}
