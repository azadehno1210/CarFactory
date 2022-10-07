using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IPropValueRepository
	{
		IEnumerable<TbPropValue> GetPropValues(bool trackChanges);
		TbPropValue GetPropValue(int propTitleId, bool trackChanges);
		void CreatePropValue(TbPropValue propValue);
	    TbPropValue GetPropValueByPropCarID(int propId, int CarId, bool trackChanges);
	}
}
