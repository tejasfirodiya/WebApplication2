using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Pages
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            show();
      
        }

        protected void Update_ServerClick(object sender, EventArgs e)
        {
            var services = new Services();
            var student = new ClassLibrary1.Student
            {
                Student_Roll_No = int.Parse(TextBoxRollNo.Text),
                Student_Name = TextBoxName.Text,
                Student_Address = TextBoxAddress.Text,
                Student_email = TextEmail.Text,
                FK_Course_Id = int.Parse(TextCourseID.Text),
                Student_Id = int.Parse(Request.QueryString["id"])
        };

            services.Update(student);

        }

        public void show()
        {

            var services = new Services();
            var studs = services.GetByID(int.Parse(Request.QueryString["id"]));
            foreach(var stud in studs )
            {
                TextBoxRollNo.Text= stud.Student_Roll_No.ToString();
                TextBoxName.Text = stud.Student_Name;
                TextBoxAddress.Text = stud.Student_Address;
                TextEmail.Text = stud.Student_email;
                TextCourseID.Text= stud.FK_Course_Id.ToString();

            }
           
        }
    }
}