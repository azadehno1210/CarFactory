using Contracts.IServices;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
	public class AgencyService:IAgencyService
	{
		private readonly IRepositoryManager _repository;
		private readonly ILoggerManager _logger;

		public AgencyService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
		{
			_repository = repositoryManager;
			_logger = loggerManager;

		}

		List<AgencyListResponseDTO> IAgencyService.GetAgencyList(bool trackChanges)
		{
			try
			{
				var AgencyList = _repository.Agency.GetAgencies(false);
				List<AgencyListResponseDTO> AgencyResult = new List<AgencyListResponseDTO>();
				

				foreach (var Agency in AgencyList)
				{

					AgencyResult.Add(new AgencyListResponseDTO
					{
						Id = Agency.Id,
						Address=Agency.Address,
						FaxNumber=Agency.FaxNumber,
						ManagerName=Agency.ManagerName,
						Name=Agency .Name,
						PhoneNumber=Agency.PhoneNumber


					});
				}
				return AgencyResult;

			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong in the Getting Car Agency" + ex.Message);
				return null;
			}

		}
	}
}
