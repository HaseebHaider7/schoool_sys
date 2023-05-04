using System;

namespace SchoolManagementSystem.Data
{
    public class Student
    {
        // auto generating
        public string AdmissionID { get; set; }
        public DateTime AdmissionDate { get; set; }
        // auto generating based on class maximum student
        public int StdRollNo { get; set; }

        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string FatherMobileNo { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public string DateOfBirthInWord { get; set; }
        public string StudentResidence { get; set; }
        public string Qaum { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        // getting value from dropdown menu
        public string Religion { get; set; }

        // getting value from dropdown menu
        public string AdmissionClass { get; set; }
        public string AdmissionSection { get; set; }

        // need to deal with when student get promoted to next class
        public int sectionID { get; set; }
        public string currentClass { get; set; }
        public string currentSection { get; set; }

        // does not need to be validate
        public byte[] StudentImage { get; set; }
        public Object StudentPic { get; set; }

    }
}
