<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="milestone3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="login" runat="server" Text="Login" onclick="login_Click"/>
            <asp:Button ID="admin" runat="server" Text="Admin Register" onclick="admin_Click"/>
            <asp:Button ID="student" runat="server" Text="Student Register" onclick="student_Click"/>
        </div>
        <div>
        <asp:Button ID="examiner" runat="server" Text="Examiner Register" onclick="examiner_Click"/>
        <asp:Button ID="supervisor" runat="server" Text="Supervisor Register" OnClick="supervisor_Click" />
         </div>
    </form>
</body>
</html>