<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuStaticExample.aspx.cs" Inherits="ASPNetDemoExample1.NavigationControlDemos.MenuStaticExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#F7F6F3" />
                <DynamicSelectedStyle BackColor="#5D7B9D" />
                <Items>
                    <asp:MenuItem Text="Standard Controls" Value="Standard Controls">
                        <asp:MenuItem NavigateUrl="~/StandardControlDemos/TextBoxExample.aspx" Text="TextBox" Value="TextBox"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/StandardControlDemos/CheckBoxExample.aspx" Text="CheckBox" Value="CheckBox"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/StandardControlDemos/RadioButtonExample.aspx" Text="Radio Button" Value="Radio Button"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="DataBound Controls" Value="DataBound Controls">
                        <asp:MenuItem NavigateUrl="~/DataBoundControlsDemos/GridViewExample.aspx" Text="GridView" Value="GridView"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/DataBoundControlsDemos/ListViewControl.aspx" Text="ListView" Value="ListView"></asp:MenuItem>
                        <asp:MenuItem Text="FormView" Value="FormView"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#5D7B9D" />
            </asp:Menu>
        </div>
    </form>
</body>
</html>
