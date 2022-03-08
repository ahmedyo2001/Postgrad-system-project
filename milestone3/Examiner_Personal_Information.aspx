<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner Personal Information.aspx.cs" Inherits="milestone3.Examiner_Personal_Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:Label ID="Label0" runat="server" Text="Examiner Personal Information"></asp:Label>
        <br/>
        <br />
        <asp:Label ID="Examiner_Name_Label" runat="server" Text="New Name"></asp:Label>
        <br />
        <asp:TextBox ID="Examiner_Name" runat="server" ></asp:TextBox>
        <br />
        <br />
        <br />
         <asp:Label ID="Examiner_Field_Of_Work_Label" runat="server" Text="New Field OF Work"></asp:Label>
        <br />
        <asp:TextBox ID="Examiner_Field_Of_Work" runat="server" ></asp:TextBox>
        <br />
         <br />
        <asp:Button ID="Examiner_Confirm_Edit" runat="server" Text="Confirm" onClick="Confirm"/>

        <p>
            <asp:Button ID="Back1" runat="server" OnClick= "Back" Text="Back to Main Page" />
        </p>
    </form>
</body>
</html>
