using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class PropCategoryRepository:RepositoryBase<TbPropCategory>,IPropCategoryRepository
	{
		public PropCategoryRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}

		IEnumerable<TbPropCategory> IPropCategoryRepository.GetPropCategories(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(s => s.Id).ToList();
		}
		public TbPropCategory GetPropCategory(int propCategoryId, bool trackChanges) => FindByCondition(s => s.Id.Equals(propCategoryId), trackChanges).SingleOrDefault();
	}
}
