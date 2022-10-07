using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
	public class CarCreateDTO
	{
		public int Id { get; set; }

		[MaxLength(250)]
		public string Name { get; set; }
		public int ModelId { get; set; }
		public int ManufactureId { get; set; }

		[MinLength(4)]
		[MaxLength(4)]
		[RegularExpression(@"\d{4}")]
		public string DesignYear { get; set; }
		public int CategoryId { get; set; }
		public int CountryId { get; set; }
		public List<PropsCreateDTO> props { get; set; }

	}
}
