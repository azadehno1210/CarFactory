using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
	public class CarPropsDTO
	{
		public string PropCatgeoryTitle { get; set; }
		public List<PropsDTO> Props { get; set; }
	}
}
