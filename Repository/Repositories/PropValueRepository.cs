using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class PropValueRepository:RepositoryBase<TbPropValue>,IPropValueRepository
	{
		public PropValueRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		public void CreatePropValue(TbPropValue propValue) => Create(propValue);


		IEnumerable<TbPropValue> IPropValueRepository.GetPropValues(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(s => s.Id).ToList();
		}


		public TbPropValue GetPropValue(int propValueId, bool trackChanges) => FindByCondition(s => s.Id.Equals(propValueId), trackChanges).SingleOrDefault();

		public TbPropValue GetPropValueByPropCarID(int propId,int CarId, bool trackChanges) => FindByCondition(s => s.PropId.Equals(propId) && s.CarId==CarId, trackChanges).First();

	}
}
