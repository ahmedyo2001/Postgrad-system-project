<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List all Theses.aspx.cs" Inherits="milestone3.List_all_Theses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

            <asp:Label ID="Label1" runat="server" Text="List All Theses"></asp:Label>
        <br />
          <br />
          <br />
     
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
     
    <p>
                <asp:Button ID="Back" runat="server" Text="Back" onClick="Back_Click"/>
            </p>
    </form>

</body>
</html>
