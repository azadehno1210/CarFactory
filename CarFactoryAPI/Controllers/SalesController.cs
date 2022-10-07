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
	[Route("Sales")]
	public class SalesController : ControllerBase
	{
		private readonly ILoggerManager _logger;
		private readonly ISalesService _salesService;


		public SalesController(ILoggerManager logger, ISalesService salesService )
		{
			_logger = logger;
			_salesService = salesService;
		}


		[HttpGet(Name = "GetSalesList")]
		public IActionResult GetSalesList()
		{
			List<SalesListResponseDTO> Sales = _salesService.GetSalesList(false);
			if (Sales == null)
			{
				_logger.LogInfo($"No Sales doesn't exist in the database.");
				return NotFound();
			}
			return Ok(Sales);
		}
	}
}
