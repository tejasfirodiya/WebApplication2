<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebApplication2.Pages.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
     <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <title></title>
</head>
<body>
    <div class="text-center">
        <h1 >Student Form</h1>
    </div>
    <form id="form1" runat="server">
        <div >
             <asp:Label ID="LabelRollNo" runat="server" Text="Roll No"></asp:Label>
            <asp:TextBox ID="TextBoxRollNo" runat="server"></asp:TextBox>

            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>

             <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TextBoxAddress" TextMode="MultiLine"  runat="server"></asp:TextBox>

             <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextEmail" runat="server" TextMode="Email"></asp:TextBox>

             <asp:Label ID="LabelCourseID" runat="server" Text="Course"></asp:Label>
            <asp:TextBox ID="TextCourseID" runat="server" ></asp:TextBox>

            <button  runat="server" id="Submit" onserverclick="Submit_ServerClick">Submit</button>
                    </div>
    </form>
</body>
</html>
