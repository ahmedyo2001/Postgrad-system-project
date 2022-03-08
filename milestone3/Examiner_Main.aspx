<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner_Main.aspx.cs" Inherits="milestone3.Examiner_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Examiner Main Page"></asp:Label>
        <div>
        </div>
        <asp:Button ID="Examiner_Information" runat="server" OnClick="ViewExaminerInfo" Text="edit personal information" />
        <p>
            <asp:Button ID="Examiner_Responsibilities" runat="server" OnClick="ViewExaminerResponsibilities" Text="view students,supervisors,thesis" />
        </p>
        <p>
            <asp:Button ID="Examiner_Comments" runat="server" OnClick= "AddComments" Text="add comment for a defense" />
        </p>
        <asp:Button ID="Examiner_Grade" runat="server" OnClick="AddGrade" Text="add grade for a defense" />
         <p>
            <asp:Button ID="Examiner_Thesis_Search" runat="server" OnClick= "SearchThesis" Text="search for thesis" />
        </p>
    </form>
</body>
</html>
