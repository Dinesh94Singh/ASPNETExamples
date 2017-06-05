<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageMapExample.aspx.cs" Inherits="ASPNetDemoExample1.StandardControlDemos.ImageMapExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageMap ID="ImageMap1" runat="server" Height="400px" ImageUrl="~/Images/Sai_gold.jpg" Width="400px">
                <asp:RectangleHotSpot AlternateText="UpperLeft" Bottom="400" HotSpotMode="Navigate" NavigateUrl="~/StandardControlDemos/CalendarExample.aspx" Right="200" />
                <asp:RectangleHotSpot AlternateText="BottomLeft" Bottom="400" HotSpotMode="Navigate" Left="201" NavigateUrl="~/StandardControlDemos/FileUploadExample.aspx" Right="400" />
            </asp:ImageMap>
        </div>
        <asp:ImageMap ID="ImageMap2" runat="server" Height="400px" HotSpotMode="Navigate" ImageUrl="~/Images/Sai-Baba.jpg" Width="400px">
            <asp:CircleHotSpot AlternateText="Circle2" HotSpotMode="Navigate" NavigateUrl="~/StandardControlDemos/TextBoxExample.aspx" Radius="190" X="200" Y="200" />
        </asp:ImageMap>
    </form>
</body>
</html>
