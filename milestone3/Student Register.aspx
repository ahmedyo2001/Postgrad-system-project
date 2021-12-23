<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Register.aspx.cs" Inherits="milestone3.Student_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="Label1" runat="server" Text="Student Register"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="first name"></asp:Label>
        <br />
        <asp:TextBox ID="student_first_name" runat="server"></asp:TextBox>
         <br />
                <asp:Label ID="Label5" runat="server" Text="last name"></asp:Label>
        <br />
        <asp:TextBox ID="student_last_name" runat="server"></asp:TextBox>
         <br />
        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
        <br />
        <asp:TextBox ID="student_email" runat="server"></asp:TextBox>
                 <br />
        <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
        <br />
        <asp:TextBox ID="student_password" runat="server"></asp:TextBox>
                         <br />
        <asp:Label ID="Label6" runat="server" Text="address"></asp:Label>
        <br />
        <asp:TextBox ID="student_address" runat="server"></asp:TextBox>
                                 <br />
        <asp:Label ID="Label7" runat="server" Text="faculty"></asp:Label>
        <br />
        <asp:TextBox ID="student_faculty" runat="server"></asp:TextBox>
        <br />
        <br />
        
        <asp:RadioButtonList id="Gucian" runat="server">
            <asp:ListItem Value=1>Gucian</asp:ListItem>
            <asp:ListItem Value=0>Non Gucian</asp:ListItem>

         </asp:RadioButtonList>
        
        
        <br />
         <br />
        <asp:Button ID="studentRegister" runat="server" Text="register" onclick="studentRegister"/>






    </form>
</body>
</html>
       
