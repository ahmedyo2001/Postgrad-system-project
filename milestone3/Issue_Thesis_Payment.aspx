<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue Thesis Payment.aspx.cs" Inherits="milestone3.Issue_Thesis_Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
         <asp:Label ID="Label1" runat="server" Text="Issue Thesis Payment" Height="34px" Width="192px"></asp:Label>
       
        <br />
        <asp:Label ID="Label2" runat="server" Text="Thesis Serial Number"></asp:Label>
        <br />
        <asp:TextBox ID="Thesis" runat="server" TextMode="Number" required></asp:TextBox>
                <br />
        <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
        <br />
        <asp:TextBox ID="Amount" runat="server" TextMode="Number" required></asp:TextBox>
                        <br />
        <asp:Label ID="Label4" runat="server" Text="Number of Installments" ></asp:Label>
        <br />
        <asp:TextBox ID="Inst" runat="server" TextMode="Number" required></asp:TextBox>
                                <br />
        <asp:Label ID="Label5" runat="server" Text="fund percentage"></asp:Label>
        <br />
        <asp:TextBox ID="fund" runat="server" TextMode="Number" required></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Issue Payment" onClick="Issue_Payment"/>
        <br />
         <p>
                <asp:Button ID="Back" runat="server" Text="Back" onClick="Back_Click"/>
            </p>
    </form>

   
</body>
</html>
