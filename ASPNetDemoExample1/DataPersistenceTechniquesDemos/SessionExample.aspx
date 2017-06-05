<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExample.aspx.cs" Inherits="ASPNetDemoExample1.DataPersistenceTechniquesDemos.SessionExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            border: 2px solid #FFFF00;
            background-color: #00FFFF;
        }
        .auto-style3 {
            margin-left: 120px;
        }
        .auto-style4 {
            width: 86px;
            height: 456px;
        }
        .auto-style5 {
            height: 456px;
        }
        .auto-style6 {
            height: 456px;
            width: 120px;
        }
        .auto-style7 {
            height: 456px;
            width: 268435216px;
        }
        .auto-style8 {
            height: 456px;
            width: 268435456px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Write Into Session Object" />
                    </td>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="Read Into Session Object" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Test" Width="608px" />
                    &nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style6">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td colspan="2" class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Click Me to Change the Session TimeOut" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
