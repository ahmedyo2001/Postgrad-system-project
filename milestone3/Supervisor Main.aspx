<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supervisor Main.aspx.cs" Inherits="milestone3.Supervisor_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Supervisor Main Page"></asp:Label>
        <div>
        </div>
        <asp:Button ID="ViewStudents" runat="server" OnClick="ViewStudentClick" Text="View Students" />
        <p>
            <asp:Button ID="ViewStudentPublication" runat="server" OnClick="ViewStudentPublications" Text="ViewStudentPublication" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick= "AddDefense" Text="AddDefense" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="AddExaminer" Text="AddExaminerForADefense" />
    </form>
</body>
</html>
