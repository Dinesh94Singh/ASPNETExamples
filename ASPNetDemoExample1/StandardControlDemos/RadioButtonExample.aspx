<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.RadioButtonExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 3px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 412px;
        }
        .auto-style3 {
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Salary"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Allowances"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="HRARadio" runat="server" AutoPostBack="True" GroupName="Allowances" OnCheckedChanged="RadioButton1_CheckedChanged" Text="HRA" />
                        <br />
                        <asp:RadioButton ID="CARadio" runat="server" AutoPostBack="True" GroupName="Allowances" OnCheckedChanged="CARadio_CheckedChanged" Text="CA" />
                        <br />
                        <asp:RadioButton ID="MARadio" runat="server" AutoPostBack="True" GroupName="Allowances" OnCheckedChanged="MARadio_CheckedChanged" Text="MA" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Net Salary"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
