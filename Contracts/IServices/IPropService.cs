using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
	public interface IPropService
	{
		void CreateProp(PropsDTO propsDTO, int CarId);
	}
}
