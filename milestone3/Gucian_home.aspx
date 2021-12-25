<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gucian_home.aspx.cs" Inherits="milestone3.Gucian_home" %>

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
    <asp:Button ID="Button3" runat="server" Text="manage progress report" OnClick="progress_report" />
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Text="manage publications" OnClick="Publication" />


      </form>

</body>
</html>
