<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPannel.aspx.cs" Inherits="AdminPannel" %>

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
                    <td class="auto-style2" colspan="3"><strong>Admin Pannel</strong></td>
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
 |<asp:HyperLink ID="HyperLink9" runat="server">
     Approve Publication Or supplies
  </asp:HyperLink>

                        |<asp:HyperLink ID="HyperLink8" runat="server">View User Profile</asp:HyperLink>
                        | <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/LogOut.aspx">Log Out</asp:HyperLink>
                    </td>
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
