<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landing page.aspx.cs" Inherits="milestone3.landing_page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Label ID="Label1" runat="server" Text="Landing Page"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Supervisor Register" OnClick="supRegRed" />
        
        <asp:Button ID="Button2" runat="server" Text="Student Register" onClick="stuRegRed"/>
        <asp:Button ID="Button3" runat="server" Text="Login" onClick="loginRed"/>
    </form>
</body>
</html>
