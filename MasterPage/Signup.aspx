<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="MasterPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Username
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            Email<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Urole
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
