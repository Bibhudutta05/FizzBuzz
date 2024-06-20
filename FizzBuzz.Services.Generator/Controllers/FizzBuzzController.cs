using FizzBuzz.Services.Generator.Model;
using FizzBuzz.Services.Generator.Service;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Services.Generator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly ILogger<FizzBuzzController> _logger;

        public FizzBuzzController(ILogger<FizzBuzzController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Generate")]
        public List<string> Generate(FizzBuzzModel model)
        {
            try
            {
                return FizzBuzzFactory.GetGeneratorInstance("FizzBuzz").Generator(model.InpurArray);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<string>();
            }

        }
    }
}
