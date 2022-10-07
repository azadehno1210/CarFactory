using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class SalesRepository:RepositoryBase<TbSales>,ISalesRepository
	{
		public SalesRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbSales> ISalesRepository.GetSales(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(s => s.Id).ToList();
		}
		public TbSales GetSale(int salesId, bool trackChanges) => FindByCondition(s => s.Id.Equals(salesId), trackChanges).SingleOrDefault();
	}
}
