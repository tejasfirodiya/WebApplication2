<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="WebApplication2.Pages.Display" %>
<%@ Import Namespace="ClassLibrary1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Roll Number</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Address</th>
                    <th>Course ID</th>
                </tr>
                <% var servic = new Services();
                    var students = servic.Getall();
                    foreach (var student in students)
                    {

                        %>
                <tr>
                    <td><%= student.Student_Roll_No %></td>
                    <td><%= student.Student_Name %></td>
                    <td><%= student.Student_email %></td>
                    <td><%= student.Student_Address %></td>
                    <td><%= student.FK_Course_Id %></td>
                    <td><a href="Update.aspx?id=<%=student.Student_Id%>">Update </a></td>


                </tr>

                <%} %>
                <tr>




                </tr>

            </table>
        </div>
    </form>
</body>
</html>
