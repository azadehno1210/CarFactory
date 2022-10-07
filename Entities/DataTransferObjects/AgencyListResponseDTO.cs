using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
	public class AgencyListResponseDTO
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public string FaxNumber { get; set; }
        
    }
}
