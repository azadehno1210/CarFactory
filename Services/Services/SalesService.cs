using Contracts.IServices;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
	public class SalesService : ISalesService
	{
		private readonly IRepositoryManager _repository;
		private readonly ILoggerManager _logger;

		public SalesService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
		{
			_repository = repositoryManager;
			_logger = loggerManager;

		}
		List<SalesListResponseDTO> ISalesService.GetSalesList(bool trackChanges)
		{
			try
			{
				var salesList = new List<SalesListResponseDTO>();

				var Agency = _repository.Agency.GetAgencies(trackChanges: false);
				var Car = _repository.Car.GetCars(trackChanges: false);
				var Customer = _repository.Customer.GetCustomers(trackChanges: false);
				var SalesList = _repository.Sales.GetSales(trackChanges: false);
				var query = (from sa in SalesList 
							join Ca in Car on sa.CarId equals Ca.Id
							join ag in Agency on sa.AgencyId equals ag.Id  
							join Cu in Customer on sa.CustomerId  equals Cu.Id
							 
							 select new SalesListResponseDTO 
							 {
								 AgencyName=ag.Name,
								 CarName=Ca.Name,
								 CustomerName=Cu.Firstname+" "+Cu.LastName,
								 DeliverDate=sa.DeliverDate,
								 DeliverState=sa.DeliverState,
								 PaymentDate=sa.PaymentDate,
								 PaymentReceiptCode=sa.PaymentReceiptCode,
								 PaymentState=sa.PaymentState,
								 RegisterDate=sa.RegisterDate,
								 Id=sa.Id}).ToList();
				return query;

			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong in the Getting Sales List" + ex.Message);
				return null;
			}

		}
	}
}
