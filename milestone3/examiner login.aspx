<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="examiner login.aspx.cs" Inherits="milestone3.examiner_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" Text="Examiner Register"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="name"></asp:Label>
        <br />
        <asp:TextBox ID="examiner_name" runat="server"></asp:TextBox>
         <br />

        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
        <br />
        <asp:TextBox ID="examiner_email" runat="server"></asp:TextBox>
                 <br />
        <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="examiner_password" runat="server"></asp:TextBox>
                         <br />
   
        <asp:Label ID="Label7" runat="server" Text="field of work"></asp:Label>
        <br />
        <asp:TextBox ID="examiner_field_of_work" runat="server"></asp:TextBox>
        <br />
    <br />
        <asp:RadioButtonList id="isNational" runat="server">
            <asp:ListItem Value=1>National</asp:ListItem>
            <asp:ListItem Value=0>InterNational</asp:ListItem>

         </asp:RadioButtonList>
        <br />
         <br />
        <asp:Button ID="examinerRegister" runat="server" Text="register" onclick="ExaminerRegister" />
    </form>
</body>
</html>
