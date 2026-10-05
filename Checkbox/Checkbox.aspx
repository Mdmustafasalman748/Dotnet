<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkbox.aspx.cs" Inherits="Checkbox.Checkbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox ID="chk_Male" runat="server" Text="Male" OnCheckedChanged="chk_male_checkedchanged" />
        <asp:CheckBox ID="chk_Female" runat="server" Text="Female" AutoPostBack="true" OnCheckedChanged="chk_female_checkedchanged"/>
        <div>
        </div>
    </form>
</body>
</html>
