using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class AgencyRepository:RepositoryBase<TbAgency>,IAgencyRepository
	{

		public AgencyRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbAgency> IAgencyRepository.GetAgencies(bool trackChanges)		{
			return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
		}
	}
}
