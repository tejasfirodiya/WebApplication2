using System.Configuration;

namespace Student.Services
{
    public class Class1
    {
        string Connection = ConfigurationManager.ConnectionStrings["UserManagement"].ConnectionString;
    }
}