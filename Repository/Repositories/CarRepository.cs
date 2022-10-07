using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class CarRepository : RepositoryBase<TbCar>, ICarRepository
	{
		public CarRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}

		IEnumerable<TbCar> ICarRepository.GetCars(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
		}
		public TbCar GetCar(int carId, bool trackChanges) => FindByCondition(c => c.Id.Equals(carId), trackChanges).SingleOrDefault();
		public void CreateCar(TbCar car) => Create(car);

		public void DeleteCar(TbCar Car) => Delete(Car);
	
	}

}
