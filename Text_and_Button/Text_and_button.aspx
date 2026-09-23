<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Text_and_button.aspx.cs" Inherits="Text_and_Button.Text_and_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_firstnumber" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt_secondnumber" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Add" runat="server" Text="ADD" />
        <asp:Button ID="btn_Sub" runat="server" Text="SUB" />
        <div>
        </div>
    </form>
</body>
</html>
