<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login</h1>
        <table>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label> </td>
            </tr>
        </table>
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="Register.aspx">Register</asp:LinkButton>
    </form>
   
</body>
</html>
