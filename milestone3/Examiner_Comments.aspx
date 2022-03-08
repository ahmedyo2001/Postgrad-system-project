<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner Comments.aspx.cs" Inherits="milestone3.Examiner_Comments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label" runat="server" Text="Examiner Comments For A Defense"></asp:Label>
        <br/>
        <asp:Label ID="Thesis_NO_label" runat="server" Text="Thesis Serial Number"></asp:Label>
        <br />
        <asp:TextBox ID="Thesis_NO" runat="server" ></asp:TextBox>
        <br />
         <asp:Label ID="Defense_Date_label" runat="server" Text="Defense Date"></asp:Label>
        <br />
        <asp:TextBox ID="Defense_Date" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="Comments_label" runat="server" Text="Comments"></asp:Label>
        <br />
        <asp:TextBox ID="Comments" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Confirm_Changes" runat="server" Text="Confirm Changes" onClick="Confirm"/>

        <p>
            <asp:Button ID="Back1" runat="server" OnClick= "Back" Text="Back To Main Page" />
        </p>
    </form>
</body>
</html>
