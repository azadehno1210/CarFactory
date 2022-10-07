using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IAgencyRepository
	{
		IEnumerable<TbAgency> GetAgencies(bool trackChanges);
	}
}
