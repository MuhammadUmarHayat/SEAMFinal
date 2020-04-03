<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerPannel.aspx.cs" Inherits="CustomerPannel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #CC0099;
            font-size: xx-large;
        }
        .auto-style3 {
            color: #006600;
        }
        .auto-style4 {
            color: #FF3300;
            font-size: x-large;
        }
        .auto-style5 {
            color: #FF0066;
            font-size: x-large;
        }
        .auto-style6 {
            font-size: large;
        }
    </style>
    
    
</head>
<body>
    <form id="form1" runat="server">
        <div>





            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3"><strong>Welcome </strong> <asp:Label ID="Label1" runat="server" CssClass="auto-style3"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="3"><span class="auto-style5"><strong>Search</strong></span>&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6" Width="529px"></asp:TextBox>
&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
&nbsp;<asp:Image ID="Image1" runat="server" />
&nbsp;<strong><asp:Label ID="Label2" runat="server" CssClass="auto-style4"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:DataList ID="DataList1" runat="server" BackColor="#3333CC" BorderColor="#666666"

            BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2"

            Font-Names="Verdana" Font-Size="Small" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal"

            Width="600px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemDataBound="DataList1_ItemDataBound1" UseAccessibleHeader="True" DataKeyField="itemid" OnItemCommand="DataList1_ItemCommand">

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

            <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Large" ForeColor="White"

                HorizontalAlign="Center" VerticalAlign="Middle" />

            <HeaderTemplate>

                Our Products 

            </HeaderTemplate>

                             <ItemStyle BackColor="White" ForeColor="Black" BorderWidth="2px" />

                             <ItemTemplate> 
 <asp:Image ID="imgEmp" runat="server" Width="100px" Height="120px" ImageUrl='<%#DataBinder.Eval(Container.DataItem, "image") %>' style="padding-left:40px"/><br />

                <b>Title :</b>

                <asp:Label ID="lblTitle" runat="server" Text='<%# Bind("title") %>'></asp:Label>
<br />

                            <b>Unit Price :</b>

                <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("unitPrice") %>'></asp:Label>

                                 <br />

                                  <b>Item Unique ID :</b>

                <asp:Label ID="Label4" runat="server" Text='<%# Bind("itemid") %>'></asp:Label>
                                 <br />

                            <b>By :</b>

                <asp:Label ID="Label3" runat="server" Text='<%# Bind("userid") %>'></asp:Label>
                                 <br />






                                 <b> Please enter the quantity: </b>

                                 <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

                                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                                 <br />

                                
                                 <br />

                                  </ItemTemplate>












                        </asp:DataList>
                    </td>




                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
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
