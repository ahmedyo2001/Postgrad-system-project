<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelThesis.aspx.cs" Inherits="milestone3.CancelThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        Thesis Serial Number<p>
            <asp:TextBox ID="ThesisSN" runat="server" required TextMode="Number"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Cancel" Text="Cancel" />
    </form>
</body>
</html>