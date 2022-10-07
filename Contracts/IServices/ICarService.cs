using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICarService
	{
		List<CarListResponseDTO> GetCarList(bool trackChanges);
		void CreateCar(CarCreateDTO carCreateDTO);
		void UpdateCar(CarCreateDTO carCreateDTO);
		void DeleteCar(int carId);

		

	}
}
