<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="progress_report.aspx.cs" Inherits="milestone3.progress_report_Gucian" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
    <style type="text/css">
      
    </style>
 
</head>
<body>
    <form id="form1" runat="server">


         <asp:Button ID="Button1" runat="server" Text="back to main page" onClick="back"/> 
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Add progress report">

        </asp:Label>
        <br />
        <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text="thesis serial number ">   </asp:Label>
        <br />
        <asp:TextBox ID="thesis_serial_add" runat="server" CssClass="auto-style1" style="z-index: 1"  TextMode="Number"></asp:TextBox>
      <br />
       <br />
           <asp:Label ID="Label9" runat="server" Text="progress report number ">   </asp:Label>
        <br />
        <asp:TextBox ID="progress_no" runat="server" CssClass="auto-style1" style="z-index: 1" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <br /><asp:Label ID="Label3" runat="server" Text="progress report date ">   </asp:Label>
        <br />
        <br />
         <asp:Calendar ID="progDate" runat="server" CssClass="auto-style1" style="z-index: 1" ></asp:Calendar>
         
        <br />
        

        <br />
     
           <asp:Button ID="add" runat="server" Text="Add" onClick="add_progress_report"/> 

        <br />
        <br />
        <br />
        <br />
        <br />


          <asp:Label ID="Label4" runat="server" Text="fill progress report">  </asp:Label>
        <br />
        <br />
           <asp:Label ID="Label5" runat="server" Text="thesis serial number ">   </asp:Label>
        <br />
        <asp:TextBox ID="thesis_serial_fill" runat="server" CssClass="auto-style1" style="z-index: 1" TextMode="Number" > </asp:TextBox>
        <br />
        <br />
           <asp:Label ID="Label6" runat="server" Text="progress report number ">   </asp:Label>
        <br />
        <asp:TextBox ID="progress_report_number2" runat="server" CssClass="auto-style1" style="z-index: 1" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
           <asp:Label ID="Label7" runat="server" Text="state ">   </asp:Label>
        <br />
        <asp:TextBox ID="state1" runat="server" CssClass="auto-style1" style="z-index: 1" TextMode="Number" ></asp:TextBox>
        <br />
        <br />
           <asp:Label ID="Label8" runat="server" Text="description ">   </asp:Label>
        <br />
        <asp:TextBox ID="description1" runat="server" CssClass="auto-style1" style="z-index: 1" ></asp:TextBox>
        <br />
        <br />
           <asp:Button ID="Button2" runat="server" Text="fill" onClick="fill_progress_report"/> 
    </form>
</body>
</html>
