using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ISalesService
	{
		List<SalesListResponseDTO> GetSalesList(bool trackChanges);
	}
}
