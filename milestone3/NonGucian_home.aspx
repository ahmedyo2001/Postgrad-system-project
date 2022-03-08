<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NonGucian_home.aspx.cs" Inherits="milestone3.NonGucian_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <asp:Button ID="Button1" runat="server" Text="view  personal information" OnClick="viewInfo" />
    <br />
      <br />
     
     <asp:Button ID="Button2" runat="server" Text="List all my theses" OnClick="list_thesis" />

        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="view courses and grades" OnClick="Course"/>
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="manage progress report" OnClick="progress_report" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Text="manage publications" OnClick="Publication" />
        <br />
        <br />


            <asp:Button ID="Button6" runat="server" Text="log out" OnClick="logout" />

    </form>
</body>
</html>
