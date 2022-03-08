<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="milestone3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="login"></asp:Label>
        <br />
        <br/>
        <asp:Label ID="label0" runat="server" Text="email"></asp:Label>
        <br />
        <asp:TextBox ID="login_id" runat="server" TextMode="Email"></asp:TextBox>
        <br />
         <asp:Label ID="Label1" runat="server" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="login_password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
                 <br />
        <asp:Button ID="login_button" runat="server" Text="login" onClick="Login"/> 
     
    </form>
</body>
</html>
