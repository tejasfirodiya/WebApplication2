using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Services
    {
        readonly string connectionstring = ConfigurationManager.ConnectionStrings["StudentManagement"].ConnectionString;

        public List<Student> Getall()
        {
            var student = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "GetallAndByID";
                using (var command = new SqlCommand(cmdtext, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();
                    var Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        var stud = new Student
                        {
                            Student_Id = (int)Reader["Student_Id"],
                            Student_Name = Reader["Student_Name"].ToString(),
                            Student_Roll_No = (int)Reader["Student_Roll_No"],
                            Student_Address = (string)Reader["Student_Address"],
                            Student_email = (string)Reader["Student_email"],
                            FK_Course_Id = (int)Reader["FK_Course_Id"]

                        };

                        student.Add(stud);
                    }
                }
            }
            return student;
        }
        //@Student_Id

        public List<Student> GetByID( int id)
        {
            var student = new List<Student>();
            using (var connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "GetallAndByID";
                using (var command = new SqlCommand(cmdtext, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    var Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        var stud = new Student
                        {
                            Student_Id = (int)Reader["Student_Id"],
                            Student_Name = Reader["Student_Name"].ToString(),
                            Student_Roll_No = (int)Reader["Student_Roll_No"],
                            Student_Address = (string)Reader["Student_Address"],
                            Student_email = (string)Reader["Student_email"],
                            FK_Course_Id = (int)Reader["FK_Course_Id"]

                        };

                        student.Add(stud);
                    }
                }
            }
            return student;
        }
        public void Add(Student student)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {


                    string cmdtext = "proc_AddUpdateStudent";
                    using (var command = new SqlCommand(cmdtext, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Student_Name", student.Student_Name);
                        command.Parameters.AddWithValue("@Student_Roll_No", student.Student_Roll_No);
                        command.Parameters.AddWithValue("@Student_email", student.Student_email);
                        command.Parameters.AddWithValue("@Student_Address", student.Student_Address);
                        command.Parameters.AddWithValue("@FK_Course_Id", student.FK_Course_Id);
                        connection.Open();
                        var Reader = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }


        public void Update(Student student)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    string cmdtext = "proc_AddUpdateStudent";
                    using (var command = new SqlCommand(cmdtext, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Student_Name", student.Student_Name);
                        command.Parameters.AddWithValue("@Student_Roll_No", student.Student_Roll_No);
                        command.Parameters.AddWithValue("@Student_email", student.Student_email);
                        command.Parameters.AddWithValue("@Student_Address", student.Student_Address);
                        command.Parameters.AddWithValue("@FK_Course_Id", student.FK_Course_Id);
                        command.Parameters.AddWithValue("@Student_Id", student.Student_Id);
                        connection.Open();
                        var Reader = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }





    }
}
