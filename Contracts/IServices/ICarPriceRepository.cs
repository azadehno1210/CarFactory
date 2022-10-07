using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICarPriceRepository
	{
		List<TbCarPrice> GetCarPrices(int carId, bool trackChanges);
	}
}
