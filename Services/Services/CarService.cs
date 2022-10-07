using Contracts.IServices;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using System.Linq;

namespace Services.Services
{
	public class CarService : ICarService
	{
		private readonly IRepositoryManager _repository;
		private readonly ILoggerManager _logger;

		public CarService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
		{
			_repository = repositoryManager;
			_logger = loggerManager;

		}



		void ICarService.CreateCar(CarCreateDTO carCreateDTO)
		{
			if (carCreateDTO != null)
			{

				List<TbPropValue> propval = new List<TbPropValue>();
				foreach (var item in carCreateDTO.props)
				{
					propval.Add(new TbPropValue { PropId = item.PropId, Value = item.PropValue });
				}
				_repository.Car.CreateCar(new TbCar
				{
					ManufactureId = carCreateDTO.ManufactureId,
					DesignYear = carCreateDTO.DesignYear,
					CountryId = carCreateDTO.CountryId,
					CategoryId = carCreateDTO.CategoryId,
					IsDeleted = false,
					TbPropValue = propval,
					ModelId = carCreateDTO.ModelId,
					Name = carCreateDTO.Name
				});
				_repository.Save();
			}

		}

		void ICarService.DeleteCar(int carId)
		{
			try
			{
				TbCar Car = _repository.Car.GetCar(carId, false);
				if (Car == null)
				{
					_logger.LogError($"Something went wrong in the Deleting Car By Id{carId}.Car Not Found");

				}
				_repository.Car.DeleteCar(Car);
				_repository.Save();


			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong in the Deleting Car By Id{carId}" + ex.Message);

			}

		}

		List<CarListResponseDTO> ICarService.GetCarList(bool trackChanges)
		{
			try
			{
				var carsDto = new List<CarListResponseDTO>();

				var Cars = _repository.Car.GetCars(trackChanges: false);
				var CarsPropCategory = _repository.PropCategory.GetPropCategories(trackChanges: false);
				var CarPropsTitle = _repository.PropTitle.GetPropTitles(trackChanges: false);
				var CarPropsValue = _repository.PropValue.GetPropValues(trackChanges: false);

				foreach (var Car in Cars)
				{
					List<CarPropsDTO> CP = new List<CarPropsDTO>();
					var CarPrices = _repository.CarPrice.GetCarPrices(Car.Id, false);
					foreach (var PropCategory in CarsPropCategory)
					{
						var query = (from cpt in CarPropsTitle join cpv in CarPropsValue on cpt.Id equals cpv.PropId where cpv.CarId == Car.Id select new PropsDTO { PropId = (int)cpv.PropId, PropTitle = cpt.Name, PropValue = cpv.Value }).ToList();
						CP.Add(new CarPropsDTO { PropCatgeoryTitle = PropCategory.Name, Props = query });
					}
					carsDto.Add(new CarListResponseDTO
					{
						Id = Car.Id,
						Name = Car.Name,
						Model = _repository.Model.GetModel((int)Car.ModelId, false),
						Category = _repository.Category.GetCategory((int)Car.CategoryId, false),
						Manufacture = _repository.Manufacture.GetManufacture((int)Car.ManufactureId, false),
						DesignYear = Car.DesignYear,
						Country = _repository.Country.GetCountry((int)Car.CountryId, false),
						props = CP,
						CarPrices = CarPrices

					});
				}
				return carsDto;

			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong in the Getting Car List" + ex.Message);
				return null;
			}

		}

		void ICarService.UpdateCar(CarCreateDTO carCreateDTO)
		{
			try
			{
				TbCar Car = _repository.Car.GetCar(carCreateDTO.Id, false);
				if (Car == null)
				{
					_logger.LogError($"Something went wrong in the Updating Car By Id{carCreateDTO.Id}.Car Not Found");

				}
				Car.CategoryId = carCreateDTO.CategoryId;
				Car.CountryId = carCreateDTO.CountryId;
				Car.DesignYear = carCreateDTO.DesignYear;
				Car.ManufactureId = carCreateDTO.ManufactureId;
				Car.ModelId = carCreateDTO.ModelId;
				Car.Name = carCreateDTO.Name;
				foreach (var item in carCreateDTO.props)
				{
					TbPropValue PV = _repository.PropValue.GetPropValueByPropCarID(item.PropId,carCreateDTO.Id, false);
					PV.Value = item.PropValue;
				}

				_repository.Save();
			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong in the Deleting Car By Id{carCreateDTO.Id}" + ex.Message);

			}
		}
	}
}
