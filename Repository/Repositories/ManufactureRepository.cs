using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class ManufactureRepository: RepositoryBase<TbManufacturer>, IManufactureRepository
	{
		public ManufactureRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}

		IEnumerable<TbManufacturer> IManufactureRepository.GetManufactures(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(m => m.Name).ToList();
		}
		public TbManufacturer GetManufacture(int manufactureId, bool trackChanges) => FindByCondition(m => m.Id.Equals(manufactureId), trackChanges).SingleOrDefault();
	}
}
