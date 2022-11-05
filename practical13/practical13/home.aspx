<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="practical13.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <center><h1>
&nbsp;Welcome to  <b style="color:red;"><asp:Label ID="welcomeLabel" runat="server"></asp:Label></b></h1>
            <asp:Button ID="LogoutButton" runat="server" OnClick="LogoutButton_Click" Text="Logout" />
    
    </center>
        
    </form>
</body>
</html>