<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addtocart2.aspx.cs" Inherits="addtocart2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-large;
            color: #006600;
        }
        .auto-style3 {
            color: #660033;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <strong>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text="Label"></asp:Label>
            </strong>You hvae products<asp:Label ID="Label1" runat="server" CssClass="auto-style1"></asp:Label>
&nbsp;in your cart
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Continue Shoping</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Edit" SelectText="Modify" ShowSelectButton="True" />
                    <asp:CommandField HeaderText="Remove" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <strong>
            <br />
            <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="Grand Total"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/ch2.png" OnClick="ImageButton1_Click1" />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="btnCashOndelivery" runat="server" ImageUrl="~/images/cnd.png" OnClick="btnCashOndelivery_Click" Visible="False" Width="123px" />
&nbsp;&nbsp;
            <asp:ImageButton ID="btnCreditCard" runat="server" ImageUrl="~/images/creditCard.png" OnClick="btnCreditCard_Click" Visible="False" Width="215px" />
&nbsp;
            <asp:ImageButton ID="btnOnlinePayment" runat="server" Height="52px" ImageUrl="~/images/p2.jpg" OnClick="btnOnlinePayment_Click" Visible="False" Width="106px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Enter Credit Card Number" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Visible="False" Width="286px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Ennter Expiry Date of Your Credit Card" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Visible="False" Width="286px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="CVCode" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Visible="False" Width="286px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Please mention Delivery Date" Visible="False"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Visible="False" Width="286px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Please mention Delivery Time" Visible="False"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Visible="False" Width="286px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="btnOrder" runat="server" ImageUrl="~/images/order.jpg" Visible="False" OnClick="btnOrder_Click" />
            <br />
            <br />
            </strong>



        </div>
    </form>
</body>
</html>
