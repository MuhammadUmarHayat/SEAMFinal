<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PublisherPannel.aspx.cs" Inherits="PublisherPannel" %>

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
                    <td class="auto-style2" colspan="3"><strong>Publisher Pannel</strong></td>
                </tr>
                <tr>
                    <td colspan="3">

                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PublisherPannel.aspx">Publisher Pannel</asp:HyperLink>
&nbsp;|
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PublishItems.aspx">Publish Items</asp:HyperLink>
&nbsp;|<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/PublishItemsManagement.aspx">Publish Management</asp:HyperLink>
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
