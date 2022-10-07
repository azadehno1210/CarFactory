using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbAgency
    {
        public TbAgency()
        {
            TbAgencyCar = new HashSet<TbAgencyCar>();
            TbSales = new HashSet<TbSales>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public string FaxNumber { get; set; }

        public virtual ICollection<TbAgencyCar> TbAgencyCar { get; set; }
        public virtual ICollection<TbSales> TbSales { get; set; }
    }
}
