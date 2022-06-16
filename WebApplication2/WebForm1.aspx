<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome</h1>
            <label>Username</label>
            <input type="text" name="name" value="" />
             <label>Password</label>
            <input type="password" name="password" value="" />
            <button>Submit</button>
        </div>

        <hr />

        <div>
            <asp:Label ID="Label1" runat="server" Text="USername" />
            <asp:TextBox ID="TextBoxUsername" runat="server" placeholder="Enter Username"></asp:TextBox>

            <asp:Label ID="Label2" runat="server">Password</asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" ></asp:TextBox>

            <asp:button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" ></asp:button>
        </div>
    </form>
</body>
</html>
