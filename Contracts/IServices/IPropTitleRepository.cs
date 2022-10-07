using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IPropTitleRepository
	{
		IEnumerable<TbPropTitle> GetPropTitles(bool trackChanges);
		TbPropTitle GetPropTitle(int propTitleId, bool trackChanges);
		TbPropTitle GetPropTitleByCategory(int propcategoryId, bool trackChanges);
	}
}
