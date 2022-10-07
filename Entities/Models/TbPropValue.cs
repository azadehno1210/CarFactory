using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbPropValue
    {
        public int Id { get; set; }
        public int? CarId { get; set; }
        public int? PropId { get; set; }
        public string Value { get; set; }

        public virtual TbCar Car { get; set; }
        public virtual TbPropTitle Prop { get; set; }
    }
}
