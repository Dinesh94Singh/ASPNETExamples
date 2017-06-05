<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeViewControlStaticExample.aspx.cs" Inherits="ASPNetDemoExample1.NavigationControlDemos.TreeViewControlStaticExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="News" NodeIndent="10" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" />
                <Nodes>
                    <asp:TreeNode Text="Standard Controls" Value="Standard Controls">
                        <asp:TreeNode NavigateUrl="~/StandardControlDemos/TextBoxExample.aspx" Text="TextBox" Value="TextBox"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/StandardControlDemos/CheckBoxExample.aspx" Text="CheckBox" Value="CheckBox"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/StandardControlDemos/RadioButtonExample.aspx" Text="RadioButton" Value="RadioButton"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="DataBound Controls" Value="DataBound Controls">
                        <asp:TreeNode NavigateUrl="~/DataBoundControlsDemos/GridViewExample.aspx" Text="GridView" Value="GridView"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/DataBoundControlsDemos/DetailsViewControl.aspx" Text="DetailsView" Value="DetailsView"></asp:TreeNode>
                        <asp:TreeNode Text="FormView" Value="FormView"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Arial" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
