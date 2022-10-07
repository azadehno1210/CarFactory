using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IRepositoryManager
	{
		ICarRepository Car { get; }
		ICategoryRepository Category { get; }

		ICustomerRepository Customer { get; }
		IManufactureRepository Manufacture { get; }
		IModelRepository Model { get; }
		ISalesRepository Sales { get; }
		ICountryRepository Country { get; }
		IPropCategoryRepository PropCategory { get; }
		IPropTitleRepository PropTitle { get; }
		IPropValueRepository PropValue { get; }
		ICarPriceRepository CarPrice { get; }
		IAgencyRepository Agency { get; }
		void Save();
	}

}
