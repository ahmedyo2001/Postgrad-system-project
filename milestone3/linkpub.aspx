<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linkpub.aspx.cs" Inherits="milestone3.linkpub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Label ID="Label6" runat="server" CssClass="auto-style1" style="z-index: 1" Text="link publication to my thesis"></asp:Label>

        <br />
        <br />
        <br />
        <br/>
        <br />
        <asp:Label ID="Label7" runat="server" CssClass="auto-style1" style="z-index: 1" Text="thesis serial number"></asp:Label>
        <br />
         <asp:TextBox ID="serialNo" runat="server" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style1" style="z-index: 1" Text="link publication" OnClick="linkPub" />

    <br />
        <br />
                <asp:Button ID="Button1" runat="server" CssClass="auto-style1" style="z-index: 1" Text="back to main page" OnClick="back" />
    </form>
</body>
</html>
