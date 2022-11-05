<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="practical13.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="userLabel" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="unameTextBox" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="passLabel" runat="server" Text="Password"> </asp:Label>
        <asp:TextBox ID="passTextBox" runat="server" TextMode="Password" ToolTip="please enter the password" ViewStateMode="Enabled"></asp:TextBox>
        <p>
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="login" />
        </p>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </form>
</body>
</html>