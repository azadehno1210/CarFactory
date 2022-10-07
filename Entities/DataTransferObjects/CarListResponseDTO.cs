using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
	public class CarListResponseDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public TbModel Model { get; set; }
		public TbManufacturer Manufacture { get; set; }
		public string DesignYear { get; set; }
		public TbCategory Category { get; set; }
		public TbCountry Country { get; set; }
		public List<TbCarPrice> CarPrices { get; set; }
		public List<CarPropsDTO> props { get; set; }

	}
}
