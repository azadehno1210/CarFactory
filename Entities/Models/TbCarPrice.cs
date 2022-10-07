using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbCarPrice
    {
        [JsonIgnore]
        public int Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string Year { get; set; }
        [JsonIgnore]
        public int? CarId { get; set; }
        [JsonIgnore]
        public virtual TbCar Car { get; set; }
    }
}
