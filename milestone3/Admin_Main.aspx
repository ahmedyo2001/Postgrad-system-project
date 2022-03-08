<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin Main.aspx.cs" Inherits="milestone3.Admin_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Admin Main Page"></asp:Label>
        </div>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Count of ongoning theses is "></asp:Label>
         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         <br />
        <asp:Button ID="Button1" runat="server" Text="List All Supervisors" OnClick="ListSup" />
        <asp:Button ID="List_All_Theses" runat="server" Text="List All Theses" onClick="List_All_Theses_Click" />
        <asp:Button ID="Button3" runat="server" Text="Issue Thesis Payment" OnClick="IssuePay" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Issue Installments" OnClick="IssueInstall" />
        
        <asp:Button ID="Button5" runat="server" Text="Update Number of extensions by 1" OnClick="UpdateextPage" />
        
    </form>
</body>
</html>
