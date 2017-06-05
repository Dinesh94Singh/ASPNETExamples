<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsViewControl.aspx.cs" Inherits="ASPNetDemoExample1.DataBoundControlsDemos.DetailsViewControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" CellPadding="4" DataKeyNames="UserName" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <Fields>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
        </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" DeleteCommand="DELETE FROM UserDetails WHERE (UserName = @UserName)" SelectCommand="SELECT * FROM [UserDetails]" UpdateCommand="UPDATE UserDetails SET Password = @Password, Email = @Email, Country = @Country WHERE (UserName = @UserName)" InsertCommand="INSERT INTO UserDetails(UserName, Password, Email, Country) VALUES (@UserName, @Password, @Email, @Country)">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="Password" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="Email" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="Country" PropertyName="SelectedValue" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="Password" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="Email" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="Country" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
    </form>
</body>
</html>
