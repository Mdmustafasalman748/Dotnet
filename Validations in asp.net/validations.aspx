<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validations.aspx.cs" Inherits="Validations_in_asp.net.validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="Red">*</asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="5000" MinimumValue="1000" Type="Double"></asp:RangeValidator>
        <p>
            &nbsp;</p>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_CEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
    </form>
    <!--Types of validators:
        1. Required field validator
        2. Regular Expression
        3. Compare 
        4. Range
        !-->
</body>
</html>
