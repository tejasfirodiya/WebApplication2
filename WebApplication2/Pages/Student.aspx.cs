using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Pages
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       


        }

        protected void Submit_ServerClick(object sender, EventArgs e)
        {
            var services = new Services();
            var student = new ClassLibrary1.Student
            {
                Student_Roll_No = int.Parse(TextBoxRollNo.Text),
                Student_Name = TextBoxName.Text,
                Student_Address = TextBoxAddress.Text,
                Student_email = TextEmail.Text,
                FK_Course_Id = int.Parse(TextCourseID.Text)
            };

            services.Add(student);
        }
    }
}