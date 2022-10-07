using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IAgencyService
	{
		List<AgencyListResponseDTO> GetAgencyList(bool trackChanges);
	}
}
