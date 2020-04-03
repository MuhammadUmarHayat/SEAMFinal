<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierManagement.aspx.cs" Inherits="SupplierManagement" %>

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
            font-size: x-large;
            color: #660066;
        }
        .auto-style3 {
            color: #660066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3"><strong>Supplier Pannel: Supply Management</strong></td>
                </tr>
                <tr>
                    <td colspan="3">

                        
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SuplierPannel.aspx">Supplier Pannel</asp:HyperLink>
&nbsp;|
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/SupplierItems.aspx">Supply Items</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/SupplierManagement.aspx">Supplier Management</asp:HyperLink>
&nbsp; |<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/LogOut.aspx">Log Out</asp:HyperLink>

                    </td>
                </tr>
                <tr>
                    <td><strong>
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style3"></asp:Label>
                        </strong></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowSorting="True" DataKeyNames="itemId" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="itemId" HeaderText="itemId" InsertVisible="False" ReadOnly="True" SortExpression="itemId" />
                                <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                                <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                                <asp:BoundField DataField="unitPrice" HeaderText="unitPrice" SortExpression="unitPrice" />
                                <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                                <asp:BoundField DataField="ManDate" HeaderText="ManDate" SortExpression="ManDate" />
                                <asp:BoundField DataField="ExpiryDate" HeaderText="ExpiryDate" SortExpression="ExpiryDate" />
                                <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
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
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SEAMFinalDBConnectionString %>" SelectCommand="SELECT DISTINCT [itemId], [title], [category], [unitPrice], [quantity], [ManDate], [ExpiryDate], [Remarks] FROM [Items] WHERE ([userid] = @userid)" DeleteCommand="delete from items where itemid=@itemid" UpdateCommand="update Items set [title]=@title, [category]=@category, [unitPrice]=@unitPrice, [quantity]=@quantity, [Remarks]=@Remarks where itemid=@itemid">
                            <SelectParameters>
                                <asp:SessionParameter Name="userid" SessionField="userid" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
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