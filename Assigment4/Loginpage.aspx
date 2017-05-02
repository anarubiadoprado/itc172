<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
         <h1> Log in!</h1>
        <table>
            <tr>
                <td> Username</td>
                <td>
                    <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" /></td>
               
            </tr>
            <tr>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>

        <asp:LinkButton ID="RegisterLinkButton" runat="server" OnClick="RegisterLinkButton_Click">Register</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
