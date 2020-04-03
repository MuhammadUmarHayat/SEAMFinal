<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemManagement.aspx.cs" Inherits="ItemManagement" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3"><strong>Admin Pannel: Items Management </strong></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminPannel.aspx">Admin Pannel</asp:HyperLink>
&nbsp;|
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AddCategory.aspx">Add Category</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/CategoryManagement.aspx">Category Management</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AddItems.aspx">Add Item</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/ItemManagement.aspx">Item Management</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/OrderManagement.aspx">Place Order</asp:HyperLink>
                        |<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/LogOut.aspx">Log Out</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="itemId" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="itemId" HeaderText="itemId" InsertVisible="False" ReadOnly="True" SortExpression="itemId" />
                                <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                                <asp:BoundField DataField="unitPrice" HeaderText="unitPrice" SortExpression="unitPrice" />
                                <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                                <asp:BoundField DataField="ManDate" HeaderText="ManDate" SortExpression="ManDate" />
                                <asp:BoundField DataField="ExpiryDate" HeaderText="ExpiryDate" SortExpression="ExpiryDate" />
                                <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
                                <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                                <asp:BoundField DataField="userid" HeaderText="userid" SortExpression="userid" />
                                <asp:BoundField DataField="userType" HeaderText="userType" SortExpression="userType" />
                                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                            </Columns>
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SortedAscendingCellStyle BackColor="#EDF6F6" />
                            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                            <SortedDescendingCellStyle BackColor="#D6DFDF" />
                            <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SEAMFinalDBConnectionString %>" SelectCommand="SELECT * FROM [Items]" UpdateCommand="update Items set [title]=@title, [category]=@category, [unitPrice]=@unitPrice, [quantity]=@quantity, [Remarks]=@Remarks where itemid=@itemid" DeleteCommand="delete from items where itemid=@itemid"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>



        </div>
    </form>
</body>
</html>
