<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudentPublication.aspx.cs" Inherits="milestone3.ViewStudentPublication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Please enter the student ID</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Submit" OnClick= "Submission" runat="server" Text="Submit" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
