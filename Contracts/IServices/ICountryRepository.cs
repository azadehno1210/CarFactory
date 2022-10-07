using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICountryRepository
	{
		IEnumerable<TbCountry> GetCountries(bool trackChanges);
		TbCountry GetCountry(int countryId, bool trackChanges);
	}
}
