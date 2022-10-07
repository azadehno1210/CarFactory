using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbCar
    {
        public TbCar()
        {
            TbAgencyCar = new HashSet<TbAgencyCar>();
            TbCarPrice = new HashSet<TbCarPrice>();
            TbPropValue = new HashSet<TbPropValue>();
            TbSales = new HashSet<TbSales>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ModelId { get; set; }
        public int? CategoryId { get; set; }
        public int? CountryId { get; set; }
        public int? ManufactureId { get; set; }
        public string DesignYear { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TbCategory Category { get; set; }
        public virtual TbCountry Country { get; set; }
        public virtual TbManufacturer Manufacture { get; set; }
        public virtual TbModel Model { get; set; }
        public virtual ICollection<TbAgencyCar> TbAgencyCar { get; set; }
        public virtual ICollection<TbCarPrice> TbCarPrice { get; set; }
        public virtual ICollection<TbPropValue> TbPropValue { get; set; }
        public virtual ICollection<TbSales> TbSales { get; set; }
    }
}
