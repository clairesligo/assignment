<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" Text="Age:" AssociatedControlID="tbxAge"></asp:Label>
        <asp:TextBox ID="tbxAge"  runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Gender:" AssociatedControlID="tbxGender"></asp:Label>
        <asp:TextBox ID="tbxGender"  runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
