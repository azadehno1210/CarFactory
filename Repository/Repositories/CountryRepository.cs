using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	class CountryRepository : RepositoryBase<TbCountry>, ICountryRepository
	{
		public CountryRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbCountry> ICountryRepository.GetCountries(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
		}
		public TbCountry GetCountry(int countryId, bool trackChanges) => FindByCondition(c => c.Id.Equals(countryId), trackChanges).SingleOrDefault();
	}
	
}
