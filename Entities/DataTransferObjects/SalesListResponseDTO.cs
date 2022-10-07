using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
	public class SalesListResponseDTO
	{
        public int Id { get; set; }
        public string AgencyName { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? PaymentState { get; set; }
        public DateTime? DeliverDate { get; set; }
        public bool? DeliverState { get; set; }
        public string PaymentReceiptCode { get; set; }
    }
}
