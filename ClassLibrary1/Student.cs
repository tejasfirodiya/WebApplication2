using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public int Student_Id { get; set; }
        public int Student_Roll_No { get; set; }
        public string Student_Name { get; set; }
        public string Student_email { get; set; }
        public string Student_Address { get; set; }
        public int FK_Course_Id { get; set; }


    }
}
