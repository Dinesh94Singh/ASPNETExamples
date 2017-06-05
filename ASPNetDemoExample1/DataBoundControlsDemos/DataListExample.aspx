<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListExample.aspx.cs" Inherits="ASPNetDemoExample1.DataBoundControlsDemos.DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" SelectCommand="SELECT * FROM [UserDetails]"></asp:SqlDataSource>
        </div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" RepeatColumns="2" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="White" />
            <AlternatingItemTemplate>
                <strong>
                <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                </strong>
                <br />
                <strong>
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                </strong>
            </AlternatingItemTemplate>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <FooterTemplate>
                End of List Of Users
            </FooterTemplate>
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                List of Users
            </HeaderTemplate>
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                <br />
                <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                <br />
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SelectedItemTemplate>
                <strong><em>
                <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                </em></strong><em>
                <br />
                </em><strong><em>
                <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                </em></strong><em>
                <br />
                </em><strong><em>
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                </em></strong><em>
                <br />
                </em><strong><em>
                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                </em></strong>
            </SelectedItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
