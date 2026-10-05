<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validations.aspx.cs" Inherits="Validations_example.Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="grid_deptdetails" />
        </div>
        <table>
            <tr>
                <td>Depname</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_depname" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="txt_depname" ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                <td>Location</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_location" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txt_depname" ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_Email" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txt_depname" ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Email:</td>
                <td>
                    <asp:TextBox runat="server" ID="txt_CEmail" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txt_depname" ForeColor="Red" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button Text="Insert" runat="server" ID="txt_insert" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
