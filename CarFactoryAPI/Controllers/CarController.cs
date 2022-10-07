using Contracts.IServices;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFactoryAPI.Controllers
{

	[ApiExplorerSettings(GroupName = "v1")]
	[Route("car")]
	public class CarController : ControllerBase
	{
		private readonly ILoggerManager _logger;
		private readonly ICarService _carservice;


		public CarController(ILoggerManager logger, ICarService carService)
		{
			_logger = logger;
			_carservice = carService;
		}


		[HttpGet(Name = "GetCarList")]
		public IActionResult GetCarList()
		{
			List<CarListResponseDTO> Cars = _carservice.GetCarList(false);
			if (Cars == null)
			{
				_logger.LogInfo($"No Car doesn't exist in the database.");
				return NotFound();
			}
			return Ok(Cars);
		}



		[HttpPost(Name = "CreateCar")]
		public IActionResult CreateCar([FromBody] CarCreateDTO Car)
		{
			if (Car == null)
			{
				_logger.LogError("CarCreateDto object sent from client is null.");
				return BadRequest("CarCreateDto object is null");

			}
			if (!ModelState.IsValid)
			{
				_logger.LogError("CarCreateDto object is Not Valid.");
				return BadRequest("CarCreateDto object is Not Valid");
			}
			_carservice.CreateCar(Car);
			return Ok();
		}

		[HttpPut(Name = "UpdateCar")]
		public IActionResult UpdateCar([FromBody] CarCreateDTO Car)
		{
			if (Car == null)
			{
				_logger.LogError("CarUpdateDto object sent from client is null.");
				return BadRequest("CarUpdateDto object is null");

			}
			if (!ModelState.IsValid)
			{
				_logger.LogError("CarUpdateDto object is Not Valid.");
				return BadRequest("CarUpdateDto object is Not Valid");
			}
			_carservice.UpdateCar(Car);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteCar(int CarId)
		{
			_carservice.DeleteCar(CarId);
			return Ok();
		}
	}
}
