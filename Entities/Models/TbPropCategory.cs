using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbPropCategory
    {
        public TbPropCategory()
        {
            TbPropTitle = new HashSet<TbPropTitle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbPropTitle> TbPropTitle { get; set; }
    }
}
