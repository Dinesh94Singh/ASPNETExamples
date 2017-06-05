<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.TextBoxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 5px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            height: 38px;
        }
        .auto-style3 {
            width: 1095px;
        }
        .auto-style4 {
            height: 38px;
            width: 1095px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Employee Name</td>
                    <td>
                        <asp:TextBox ID="lblEmployeeName" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Salary</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">HRA</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">CA</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">MA</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Net Salary</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Profile</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Height="201px" TextMode="MultiLine" Width="509px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Access Code</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
