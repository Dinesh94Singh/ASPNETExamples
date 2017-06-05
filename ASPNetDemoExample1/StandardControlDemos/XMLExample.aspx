<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.XMLExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Xml ID="Xml1" runat="server" DocumentSource="~/App_Data/Details.xml"></asp:Xml>
        </div>
    </form>
</body>
</html>
