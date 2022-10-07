using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class ModelRepository:RepositoryBase<TbModel>,IModelRepository
	{
		public ModelRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbModel> IModelRepository.GetModels(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(m => m.Name).ToList();
		}
		public TbModel GetModel(int modelId, bool trackChanges) => FindByCondition(m => m.Id.Equals(modelId), trackChanges).SingleOrDefault();
	}
}
