<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webpage.aspx.cs" Inherits="Webpage.Webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label Text="username" ID="lbl_UserName" runat="Server" />
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_UserName" OnTextChanged="txt_UserName_TextChanged"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text="Password" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_Password" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                       <asp:Button Text="login" runat="server" ID="btn_login" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
