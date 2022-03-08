<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDefenseNonGucian.aspx.cs" Inherits="milestone3.AddDefenseNonGucian" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          Thesis Serial Number<div>
        </div>
        <asp:TextBox ID="ThesissnNG" runat="server" required TextMode="Number"></asp:TextBox>
        <p>
            Defense Date</p>
        <p>
            <asp:Calendar ID="DefDateNG" runat="server" required></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Defense Location</p>
        <p>
            <asp:TextBox ID="DefLocNG" runat="server" required></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="AddNG" Text="Add" />
        <div>
        </div>
    </form>
</body>
</html>