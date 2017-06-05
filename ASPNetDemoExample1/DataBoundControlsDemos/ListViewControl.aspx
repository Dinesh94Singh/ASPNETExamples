<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewControl.aspx.cs" Inherits="ASPNetDemoExample1.DataBoundControlsDemos.ListViewControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="UserName" DataSourceID="SqlDataSource1" GroupItemCount="3" InsertItemPosition="LastItem">
                <AlternatingItemTemplate>
                    <td runat="server" style="background-color:#FFF8DC;">UserName:
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                        <br />Password:
                        <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                        <br />Email:
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                        <br />Country:
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">UserName:
                        <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                        <br />Password:
                        <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' />
                        <br />Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />Country:
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br /></td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
<td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">UserName:
                        <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                        <br />Password:
                        <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' />
                        <br />Email:
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                        <br />Country:
                        <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br /></td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="background-color:#DCDCDC;color: #000000;">UserName:
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                        <br />Password:
                        <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                        <br />Email:
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                        <br />Country:
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">UserName:
                        <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                        <br />Password:
                        <asp:Label ID="PasswordLabel" runat="server" Text='<%# Eval("Password") %>' />
                        <br />Email:
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                        <br />Country:
                        <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br /></td>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" DeleteCommand="DELETE FROM UserDetails WHERE (UserName = @UserName)" SelectCommand="SELECT * FROM [UserDetails]" UpdateCommand="UPDATE UserDetails SET Password = @Password, Email = @Email, Country = @Country WHERE (UserName = @UserName)" InsertCommand="INSERT INTO UserDetails(UserName, Password, Email, Country) VALUES (@UserName, @Password, @Email, @Country)">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="ListView1" Name="UserName" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="ListView1" Name="UserName" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="Password" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="Email" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="Country" PropertyName="SelectedValue" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="ListView1" Name="Password" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="Email" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="Country" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="ListView1" Name="UserName" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
        <asp:DataPager ID="DataPager2" runat="server" PagedControlID="ListView1" PageSize="2">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
            </Fields>
        </asp:DataPager>
    </form>
</body>
</html>
