<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue Installments.aspx.cs" Inherits="milestone3.Issue_Installments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Label ID="Label1" runat="server" Text="Issue Installments"></asp:Label>
        <br />
        <br />
        <br />
        
        <br />
        <asp:Label ID="Label2" runat="server" Text="Payment Id"></asp:Label>
        <br />
        <asp:TextBox ID="Payment" runat="server" TextMode="Number" required></asp:TextBox>
                <br />
        <asp:Label ID="Label3" runat="server" Text="Installment Start Date"></asp:Label>
        <br />
        <asp:TextBox ID="sdate" runat="server" required></asp:TextBox>
                        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Issue Installments" OnClick="Button1_Click" />
        <br />
       <p>
                <asp:Button ID="Back" runat="server" Text="Back" onClick="Back_Click"/>
            </p>
    </form>

    
</body>
</html>
