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
        <asp:TextBox ID="ThesisSN" runat="server" required TextMode="Number"></asp:TextBox>
         <p>
            Defense Date</p>
        <p>
            <asp:Calendar ID="DefDate" runat="server" required></asp:Calendar>
        </p>
        <p>
            Examiner ID<p>
            <asp:TextBox ID="ExID" runat="server" required TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="AddEx" Text="Add Examiner" />
        </p>
    </form>

</body>
</html>