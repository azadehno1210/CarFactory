using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IModelRepository
	{
		IEnumerable<TbModel> GetModels(bool trackChanges);
		TbModel GetModel(int modelId, bool trackChanges);
	}
}
