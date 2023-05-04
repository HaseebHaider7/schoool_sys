using System;

namespace SchoolManagementSystem.Data
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Cnic { get; set; }
        public string MobileNo { get; set; }
        public string StaffDesignation { get; set; }
        //public string emailAdd { get; set; }
        public DateTime JoiningDate { set; get; }
        //public decimal StaffSalary { get; set; } 
    }
}
