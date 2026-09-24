<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dropdown.aspx.cs" Inherits="Dropdown_list.Dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="Depid" DataValueField="Depid"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" OnSelecting="SqlDataSource2_Selecting"></asp:SqlDataSource>
        <div>
        </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Depid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Depid" HeaderText="Depid" InsertVisible="False" ReadOnly="True" SortExpression="Depid" />
            <asp:BoundField DataField="Depname" HeaderText="Depname" SortExpression="Depname" />
            <asp:BoundField DataField="Dephod" HeaderText="Dephod" SortExpression="Dephod" />
            <asp:BoundField DataField="Loc" HeaderText="Loc" SortExpression="Loc" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tbl_dept]"></asp:SqlDataSource>
    </form>
    </body>
</html>
