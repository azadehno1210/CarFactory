using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ISalesRepository
	{
		IEnumerable<TbSales> GetSales(bool trackChanges);
		TbSales GetSale(int saleId, bool trackChanges);
	}
}
