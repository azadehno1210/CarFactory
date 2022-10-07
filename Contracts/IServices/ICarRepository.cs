using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICarRepository
	{
		IEnumerable<TbCar> GetCars(bool trackChanges);
		TbCar GetCar(int carId, bool trackChanges);
		void CreateCar(TbCar car);
		void DeleteCar(TbCar car);
	}
}
