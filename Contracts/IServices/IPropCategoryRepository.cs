using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IPropCategoryRepository
	{
		IEnumerable<TbPropCategory> GetPropCategories(bool trackChanges);
		TbPropCategory GetPropCategory(int propCategoryId, bool trackChanges);
	}
}
