<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add mobile.aspx.cs" Inherits="milestone3.add_mobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <asp:Label ID="Label2" runat="server" Text="add mobile"></asp:Label>
        <br/>
        <asp:Label ID="label0" runat="server" Text="id"></asp:Label>
        <br />
        <asp:TextBox ID="addNumber_id" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label1" runat="server" Text="mobile number"></asp:Label>
        <br />
        <asp:TextBox ID="addnumber_number" runat="server"></asp:TextBox>
        <br />
                 <br />
        <asp:Button ID="addmobile_button" runat="server" Text="add mobile" BackColor="White" />
    </form>
</body>
</html>
