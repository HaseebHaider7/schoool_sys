using System;

namespace SchoolManagementSystem.Data
{
    public class FeeStructure
    {
        public string status { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal paid { get; set; }
        public decimal remaining { get; set; }
        public DateTime? paymentDate { get; set; }
        public DateTime dueDate { get; set; }
        public string feeMonth { get; set; }
        public int feeYear { get; set; }

    }
}
