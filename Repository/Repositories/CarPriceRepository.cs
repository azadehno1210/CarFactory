using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class CarPriceRepository : RepositoryBase<TbCarPrice>, ICarPriceRepository
	{
		public CarPriceRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}

		List<TbCarPrice> ICarPriceRepository.GetCarPrices(int carId, bool trackChanges)
		{
			return FindByCondition(c => c.CarId.Equals(carId), trackChanges).OrderByDescending(c => c.Year).ToList();
		}
	}
}
