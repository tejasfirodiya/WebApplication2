<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebApplication2.Pages.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
          


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

            <button  runat="server" id="Edit" onserverclick="Update_ServerClick">Edit</button>
   
    </form>
</body>
</html>
