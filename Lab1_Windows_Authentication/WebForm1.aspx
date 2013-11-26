<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab1_Windows_Authentication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome To Our Website<br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SecureFolder/WebForm2.aspx">HyperLink</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="lblAuth" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblType" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
