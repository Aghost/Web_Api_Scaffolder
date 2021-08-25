using Microsoft.AspNetCore.Mvc;
using UserRepositoryApi.Data;
using UserRepositoryApi.Business.Interfaces;

namespace UserRepositoryApi.Controllers
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
