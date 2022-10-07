using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbPropTitle
    {
        public TbPropTitle()
        {
            TbPropValue = new HashSet<TbPropValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual TbPropCategory Category { get; set; }
        public virtual ICollection<TbPropValue> TbPropValue { get; set; }
    }
}
