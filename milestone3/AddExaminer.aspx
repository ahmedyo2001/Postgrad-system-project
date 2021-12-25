<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExaminer.aspx.cs" Inherits="milestone3.AddExaminer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Thesis Serial Number</div>
        <asp:TextBox ID="ThesisSN" runat="server"></asp:TextBox>
         <p>
            Defense Date</p>
        <p>
            <asp:Calendar ID="DefDate" runat="server"></asp:Calendar>
        </p>
        <p>
            Examiner Name<p>
            <asp:TextBox ID="ExaminerName" runat="server"></asp:TextBox>
        </p>
        National<asp:CheckBox ID="CheckBox1" runat="server" />
        <p>
            Field of work</p>
        <asp:TextBox ID="FieldOfWork" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="AddEx" Text="Add Examiner" />
        </p>
    </form>

</body>
</html>
