<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxDemo.aspx.cs" Inherits="ASPNetDemoExample1.AJAXDemo.AjaxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="MyTitle" runat="server"></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 288px;
            border: 2px solid #00FF00;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 375px;
            height: 78px;
        }
        .auto-style3 {
            width: 423px;
            height: 78px;
        }
        .auto-style4 {
            width: 700px;
            height: 78px;
        }
        .auto-style5 {
            height: 78px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label1" runat="server" Text="Enter First No"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label2" runat="server" Text="Enter Second No"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add" />
                            </td>
                            <td class="auto-style3">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="subtract" />
                            </td>
                            <td class="auto-style4">
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="multiply" />
                            </td>
                            <td class="auto-style5">
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="divide" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <br />
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <asp:Label ID="Label4" runat="server" Text="Performing Operations Please wait !!"></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:Label ID="Label5" runat="server" ForeColor="Fuchsia"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
