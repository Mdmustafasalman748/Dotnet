<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statemgmt.aspx.cs" Inherits="State_Management_Technique.Statemgmt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!-- State Management Technique:
        It is used to constantly monitor and maintain the state of an
        object in runtime.
        There are two types of state management
        1. Client side - It stores the information on client machine.
        2. Server side - It stores the information on server.
    View state:
        -> It is one of the state management technique.
        -> It is used to carry a value from one postback to another 
        postback.
        -> The memory allocation of view state is on client side.
        -> It can aslo send objects.
    Session state:
        -> It is one of the state management technique.
        -> It is used to carry a value from one page to another page.
        -> The memory allocation of session state is on the server side.
        -> It can also send objects.
        -> We can add session timeout in Web.config.
        -> To close a session use Session.Abandon.
    Hidden Field:
        -> It is one of the asp control.
        -> It is used to carry a value from one ppstback to another
        postback.
        -> The memory allocation of hidden field is on server side.
        -> It can only send values.
        -> It is used for small values.
    Query String:
        -> It is one of the state management technique.
        -> It is used to carry a value from one page to its next 
        immediate page.
        -> Whenever there is a URL with question mark, it is Query 
        string.
    Postback:
        -> The process of submitting an asp.net page to the server for 
        processing is called postback.
    Autopostback:
        -> Autopostback is a property of .net which provides automatic 
        postback whenever an event starts its execution cycle.
    Response.Redirect:
        -> It will navigate globally and changes the URL.
    Server.Transfer:
        -> It will navigate locally within the application and doesn't
        changes the URL.
        !-->
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_price" />
                    </td>
                </tr>
                <tr>
                    <td>Quantity:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_quantity" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button Text="Submit" runat="server" ID="btn_submit"/>
                    </td>
                </tr>
                <tr>
                    <td>Percentage</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_percentage" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button Text="Percentage" runat="server" ID="btn_percentage" />
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_name" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button Text="Submit" runat="server" ID="btn_name" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
