<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sup_home.aspx.cs" Inherits="milestone3.Sup_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Supervisor Page"></asp:Label>
        <div>
        </div>
        <p>
        <asp:Button ID="ViewStudents" runat="server" OnClick="ViewStudentClick" Text="View Students" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ViewStudentPublication" runat="server" OnClick="ViewStudentPublications" Text="ViewStudentPublication" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick= "AddDefense" Text="Add Defense" />
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" OnClick="AddExaminer" Text="Add Examiner For A Defense" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="EvaluateProgressRep" Text="Evaluate ProgressReport" />
        </p>
        <asp:Button ID="Button4" runat="server" OnClick="CancelThesis" Text="Cancel Thesis" />
    </form>
</body>
</html>