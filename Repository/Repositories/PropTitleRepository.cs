using Contracts.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
	public class PropTitleRepository:RepositoryBase<TbPropTitle>,IPropTitleRepository
	{
		public PropTitleRepository(CarFactoryContext CarFactoryDbContext) : base(CarFactoryDbContext)
		{

		}
		IEnumerable<TbPropTitle> IPropTitleRepository.GetPropTitles(bool trackChanges)
		{
			return FindAll(trackChanges).OrderBy(s => s.Id).ToList();
		}
		public TbPropTitle GetPropTitle(int propTitleId, bool trackChanges) => FindByCondition(s => s.Id.Equals(propTitleId), trackChanges).SingleOrDefault();

		

		TbPropTitle IPropTitleRepository.GetPropTitleByCategory(int propcategoryId, bool trackChanges) => FindByCondition(s => s.CategoryId.Equals(propcategoryId), trackChanges).SingleOrDefault();
		
	}
}
