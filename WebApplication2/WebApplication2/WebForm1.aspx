<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align=center>
        <tr>
            <td class="style1">
            <asp:Label ID="Label1" runat="server" Text="No"></asp:Label>
            </td>
            <td class="style1">
                <asp:TextBox ID="txtno" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style1">
            
                <asp:Button ID="Button1" runat="server" Text="Button" />
            
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
