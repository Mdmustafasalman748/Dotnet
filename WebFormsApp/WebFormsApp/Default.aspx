<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Web Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello from Web Forms</h1>
            <asp:Label ID="lblName" runat="server" Text="Your name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnGreet" runat="server" Text="Greet" OnClick="btnGreet_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Empid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Empid" HeaderText="Empid" ReadOnly="True" SortExpression="Empid" />
                    <asp:BoundField DataField="Empname" HeaderText="Empname" SortExpression="Empname" />
                    <asp:BoundField DataField="Empgender" HeaderText="Empgender" SortExpression="Empgender" />
                    <asp:BoundField DataField="Sal" HeaderText="Sal" SortExpression="Sal" />
                    <asp:BoundField DataField="Depid" HeaderText="Depid" SortExpression="Depid" />
                    <asp:BoundField DataField="Comm" HeaderText="Comm" SortExpression="Comm" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:batchMdfConnectionString %>" SelectCommand="SELECT [Empid], [Empname], [Empgender], [Sal], [Depid], [Comm] FROM [tbl_emp]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
