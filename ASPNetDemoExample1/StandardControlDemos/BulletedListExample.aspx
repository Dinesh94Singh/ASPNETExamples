<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulletedListExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.BulletedListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #00FFFF;
        }
        .auto-style2 {
            height: 287px;
        }
        .auto-style3 {
            height: 287px;
            width: 1222px;
        }
        .auto-style4 {
            width: 1222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3">
                        <asp:BulletedList ID="BulletedList1" runat="server" BorderColor="#FF99FF" BorderWidth="2px" BulletStyle="Numbered" DisplayMode="LinkButton" Height="151px" OnClick="BulletedList1_Click">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>Australia</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                        </asp:BulletedList>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:BulletedList ID="BulletedList2" runat="server">
                        </asp:BulletedList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:BulletedList ID="BulletedList3" runat="server">
                        </asp:BulletedList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:BulletedList ID="BulletedList4" runat="server">
                        </asp:BulletedList>
                    </td>
                    <td class="auto-style4">
                        <asp:BulletedList ID="BulletedList5" runat="server">
                        </asp:BulletedList>
                    </td>
                    <td>
                        <asp:BulletedList ID="BulletedList6" runat="server">
                        </asp:BulletedList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
