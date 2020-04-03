<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-top: 29px;
        }
        .auto-style3 {
            color: #FF3300;
        }
        .auto-style4 {
            text-align: center;
            font-size: x-large;
            color: #660066;
        }
        .auto-style5 {
            font-size: xx-large;
            color: #FF0066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>




            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4"><strong>Customer Pannel</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Welcome <strong>
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style5"></asp:Label>
                        </strong>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Quantity
                        <strong>
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style3"></asp:Label>
                        </strong>&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/addtocart2.aspx">Shoping</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:DataList ID="DataList1" runat="server" DataKeyField="itemId" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand" RepeatColumns="3" RepeatDirection="Horizontal" Width="199px">
                            <ItemTemplate>
                                itemId:
                                <asp:Label ID="itemIdLabel" runat="server" Text='<%# Eval("itemId") %>' />
                                <br />
                                title:
                                <asp:Label ID="titleLabel" runat="server" Text='<%# Eval("title") %>' />
                                <br />
                                category:
                                <asp:Label ID="categoryLabel" runat="server" Text='<%# Eval("category") %>' />
                                <br />
                                unitPrice:
                                <asp:Label ID="unitPriceLabel" runat="server" Text='<%# Eval("unitPrice") %>' />
                                <br />
                                quantity:<asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                image:
                                 <asp:Image ID="imgEmp" runat="server" Width="100px" Height="120px" ImageUrl='<%#DataBinder.Eval(Container.DataItem, "image") %>' style="padding-left:40px"/><br />
                                <br />
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("itemid")%>' CommandName="addtocart" CssClass="auto-style2" Height="56px" ImageUrl="~/images/ad2.png" />
<br />
                                <br />

 <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("itemid")%>' CommandName="addtowishlist" CssClass="auto-style2" Height="56px" ImageUrl="~/images/ws1.png" />


                            </ItemTemplate>
                        </asp:DataList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SEAMFinalDBConnectionString %>" SelectCommand="SELECT DISTINCT [itemId], [title], [category], [unitPrice], [quantity], [image] FROM [Items]"></asp:SqlDataSource>
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
