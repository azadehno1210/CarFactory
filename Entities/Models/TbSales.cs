using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Models
{
    public partial class TbSales
    {
        public int Id { get; set; }
        public int? AgencyId { get; set; }
        public int? CarId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? PaymentState { get; set; }
        public DateTime? DeliverDate { get; set; }
        public bool? DeliverState { get; set; }
        public string PaymentReceiptCode { get; set; }

        public virtual TbAgency Agency { get; set; }
        public virtual TbCar Car { get; set; }
        public virtual TbCustomer Customer { get; set; }
    }
}
