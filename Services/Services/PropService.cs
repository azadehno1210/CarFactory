using Contracts.IServices;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
	public class PropService : IPropService
	{
		private readonly IRepositoryManager _repository;
		private readonly ILoggerManager _logger;
		public PropService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
		{
			_repository = repositoryManager;
			_logger = loggerManager;
		}
		void IPropService.CreateProp(PropsDTO propsDTO,int CarId)
		{
			_repository.PropValue.CreatePropValue(new TbPropValue { CarId = CarId, PropId = propsDTO.PropId, Value = propsDTO.PropValue });
			
		}
	}
}
