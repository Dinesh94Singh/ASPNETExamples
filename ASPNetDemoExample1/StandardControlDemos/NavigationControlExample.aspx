<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavigationControlExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.NavigationControlExample" %>

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
            width: 813px;
        }
        .auto-style3 {
            width: 823px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StandardControlDemos/TextBoxExample.aspx">GoTo TextBox Example</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl="~/Images/Sai gold.jpg" OnClick="ImageButton1_Click" Width="300px" />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">GoTo TextBox Example</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
