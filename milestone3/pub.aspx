<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pub.aspx.cs" Inherits="milestone3.Gucian_pub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <br />  
    <br />

    <form id="form1" runat="server"> 
     
      
       <asp:Button ID="Button3" runat="server" CssClass="auto-style1" style="z-index: 1" Text="back to main page" OnClick="back" />
           <br />
           <br />
           <br />
           <br />
      <asp:Label ID="Label1" runat="server" CssClass="auto-style1" style="z-index: 1" Text="add publication"></asp:Label>
 <br />
<br />
         
 <br />
<br />   
                <asp:Label ID="Label2" runat="server" CssClass="auto-style1" style="z-index: 1" Text="title"></asp:Label>
        <br />
        <asp:TextBox ID="title1" runat="server" ></asp:TextBox>

        <br />
        <br />
              <asp:Label ID="Label3" runat="server" CssClass="auto-style1" style="z-index: 1" Text="host"></asp:Label>
        <br />
        <asp:TextBox ID="host1" runat="server"  ></asp:TextBox>
        <br />
        <br />
              <asp:Label ID="Label4" runat="server" CssClass="auto-style1" style="z-index: 1" Text="place"></asp:Label>
        <br />
        <asp:TextBox ID="place1" runat="server" ></asp:TextBox>
      
  <br />
        <br />
        <br />
         <asp:Label ID="Label5" runat="server" CssClass="auto-style1" style="z-index: 1" Text="publication date"></asp:Label>
        <br />
        <br />

        <asp:Calendar ID="pubDate1" runat="server" CssClass="auto-style1" style="z-index: 1" ></asp:Calendar>
        <br />
        <br />

        <asp:RadioButtonList id="Accepted1" runat="server" >
            <asp:ListItem Value=1>Accepted</asp:ListItem>
            <asp:ListItem Value=0>Not accepted</asp:ListItem>
            </asp:RadioButtonList>
      <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" style="z-index: 1" Text="add publication" OnClick="addPub" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

      
  
    </form>
</body>
</html>
