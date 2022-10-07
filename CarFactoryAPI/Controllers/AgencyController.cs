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
	[Route("Agency")]
	public class AgencyController : ControllerBase
	{
		private readonly ILoggerManager _logger;
		private readonly IAgencyService _agencyservice;


		public AgencyController(ILoggerManager logger, IAgencyService agencyService)
		{
			_logger = logger;
			_agencyservice = agencyService;
		}

		[HttpGet(Name = "GetAgencyList")]
		public IActionResult GetAgencyList()
		{
			List<AgencyListResponseDTO> Agencies =_agencyservice.GetAgencyList(false);
			if (Agencies == null)
			{
				_logger.LogInfo($"No Agency doesn't exist in the database.");
				return NotFound();
			}
			return Ok(Agencies);
			
		}
	}



	
}
