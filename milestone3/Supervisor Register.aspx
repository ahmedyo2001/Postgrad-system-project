<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supervisor Register.aspx.cs" Inherits="milestone3.Supervisor_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Supervisor Register"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="first_name"></asp:Label>
        <br />
        <asp:TextBox ID="supervisor_first_name" runat="server"></asp:TextBox>
         <br />
                <asp:Label ID="Label5" runat="server" Text="last_name"></asp:Label>
        <br />
        <asp:TextBox ID="supervisor_last_name" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
        <br />
        <asp:TextBox ID="supervisor_email" runat="server"></asp:TextBox>
                 <br />
        <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="supervisor_password" runat="server"></asp:TextBox>
                         <br />

        <asp:Label ID="Label7" runat="server" Text="faculty"></asp:Label>
        <br />
        <asp:TextBox ID="supervisor_faculty" runat="server"></asp:TextBox>
        <br />

         <br />
        <asp:Button ID="supervisorRegister" runat="server" Text="register" OnClick="supReg" />
    </form>
</body>
</html>
