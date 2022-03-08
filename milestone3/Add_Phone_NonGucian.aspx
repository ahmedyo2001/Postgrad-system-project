<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Phone_NonGucian.aspx.cs" Inherits="milestone3.Add_Phone_NonGucian" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        
        <asp:Label ID="Label1" runat="server" Text="Add Number Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Phone Number"></asp:Label>
        <br />
        <asp:TextBox ID="Phone_Number" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Add Phone" OnClick="add_phone" />
        &nbsp;</form>
</body>
</html>
