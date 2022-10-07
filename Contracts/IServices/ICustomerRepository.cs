using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICustomerRepository
	{
		IEnumerable<TbCustomer> GetCustomers(bool trackChanges);
		TbCustomer GetCustomer(int customerId, bool trackChanges);
	}
}
