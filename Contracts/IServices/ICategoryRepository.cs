using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface ICategoryRepository
	{
		IEnumerable<TbCategory> GetCategories(bool trackChanges);
		TbCategory GetCategory(int categoryId, bool trackChanges);
	}
}
