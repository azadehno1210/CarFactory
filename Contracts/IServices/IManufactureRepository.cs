using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IManufactureRepository
	{
		IEnumerable<TbManufacturer> GetManufactures(bool trackChanges);
		TbManufacturer GetManufacture(int manufactureId, bool trackChanges);
	}
}
