<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterControl.aspx.cs" Inherits="ASPNetDemoExample1.DataBoundControlsDemos.RepeaterControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource2">
            </asp:Repeater>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" SelectCommand="SELECT * FROM [UserDetails]"></asp:SqlDataSource>
    </form>
</body>
</html>
