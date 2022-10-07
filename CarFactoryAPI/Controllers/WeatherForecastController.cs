using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Contracts.IServices;
using System.Threading.Tasks;
using Entities.DataTransferObjects;

namespace CarFactoryAPI.Controllers
{


	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = "v1")]
	public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly ICarService _carService;
     
        public WeatherForecastController(ILoggerManager logger,ICarService carService)
        {
            _logger = logger;
            _carService = carService;

        }
		[HttpGet]
		public List<CarListResponseDTO> Get()
		{
			List<CarListResponseDTO> Cars = _carService.GetCarList(false);
			//_logger.LogInfo("Here is info message from our values controller.");
			//_logger.LogDebug("Here is debug message from our values controller.");
			//_logger.LogWarn("Here is warn message from our values controller.");
			//_logger.LogError("Here is an error message from our values controller.");

			return Cars;
		}
	}
}
