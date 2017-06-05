<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeViewControlDynamicExample.aspx.cs" Inherits="ASPNetDemoExample1.NavigationControlDemos.TreeViewControlDynamicExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" ImageSet="XPFileExplorer" NodeIndent="15">
                <DataBindings>
                    <asp:TreeNodeBinding DataMember="ControlType" TextField="Name" />
                    <asp:TreeNodeBinding DataMember="Control" NavigateUrlField="url" TextField="Name" />
                </DataBindings>
                <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/XMLDataSourceMenuDynamicExample.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
