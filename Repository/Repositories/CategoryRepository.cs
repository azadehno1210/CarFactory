using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	class CategoryRepository : RepositoryBase<TbCategory>, ICategoryRepository
	{
		public CategoryRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}

		IEnumerable<TbCategory> ICategoryRepository.GetCategories(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(c => c.Name).ToList();
		}
		public TbCategory GetCategory(int categoryId, bool trackChanges) => FindByCondition(c => c.Id.Equals(categoryId), trackChanges).SingleOrDefault();
	}
}
