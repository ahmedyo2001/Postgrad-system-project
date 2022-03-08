<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner Responsibilities.aspx.cs" Inherits="milestone3.Examiner_Responsibilities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <asp:Label ID="Label1" runat="server" Text="Examiner Responsibilities"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="Back1" runat="server" OnClick= "Back" Text="Back To Main Page" />
        </p>
    </form>
</body>
</html>
