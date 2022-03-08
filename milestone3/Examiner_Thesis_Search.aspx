<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner Thesis Search.aspx.cs" Inherits="milestone3.Examiner_Thesis_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label0" runat="server" Text="Examiner Thesis Search"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Thesis_Title_Label" runat="server" Text="Title"></asp:Label>
        <br />
        <asp:TextBox ID="Thesis_Title" runat="server" ></asp:TextBox>
        <br />
         <br />
        <asp:Button ID="Examiner_Search" runat="server" Text="Search" onClick="Search"/>
          <br />
          <br />
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
        <br />
        <p>
            <asp:Button ID="Back1" runat="server" OnClick= "Back" Text="Back To Main Page" />
        </p>
    </form>
</body>
</html>
