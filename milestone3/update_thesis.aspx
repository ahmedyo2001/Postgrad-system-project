<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update thesis.aspx.cs" Inherits="milestone3.update_thesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Update Thesis Extension Page"></asp:Label>
        </div>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Thesis Serial Number"></asp:Label>
        <br />
        <asp:TextBox ID="Thesissn" runat="server" TextMode="Number" required ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" onclick ="upsub"/>
        <br />
         <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
    </form>

   
</body>
</html>
