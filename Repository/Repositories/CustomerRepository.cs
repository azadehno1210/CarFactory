using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class CustomerRepository : RepositoryBase<TbCustomer>, ICustomerRepository
	{
		public CustomerRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbCustomer> ICustomerRepository.GetCustomers(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(c => c.LastName).ToList();
		}
		public TbCustomer GetCustomer(int customerId, bool trackChanges) => FindByCondition(c => c.Id.Equals(customerId), trackChanges).SingleOrDefault();
	
	}
}
