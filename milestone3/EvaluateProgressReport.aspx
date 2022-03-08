<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvaluateProgressReport.aspx.cs" Inherits="milestone3.EvaluateProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Thesis Serial Number</div>
        <p>
            <asp:TextBox ID="ThesisSN" runat="server" required TextMode="Number"></asp:TextBox>
        </p>
        Progress Report No.<p>
            <asp:TextBox ID="ProgressReportNo" runat="server" required TextMode="Number"></asp:TextBox>
        </p>
        Evaluation (0 to 3)<p>
            <asp:TextBox ID="Evaluation" runat="server" required TextMode="Number"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Height="67px" OnClick="Evaluate" Text="Evaluate" Width="124px" />
    </form>
</body>
</html>