using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbAgencyCar
    {
        public int Id { get; set; }
        public int? AgencyId { get; set; }
        public int? CarId { get; set; }

        public virtual TbAgency Agency { get; set; }
        public virtual TbCar Car { get; set; }
    }
}
