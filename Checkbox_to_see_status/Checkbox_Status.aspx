<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkbox_Status.aspx.cs" Inherits="Checkbox_to_see_status.Checkbox_Status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Hitme" AutoPostBack="true" OnCheckedChanged="checkbox_1_checkedchanged" />
        <div>
        </div>
    </form>
</body>
</html>
