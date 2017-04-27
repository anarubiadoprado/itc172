<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Invalid Login. Register here first</h2>
      <table>
          <tr>
              <td>Email</td>
              <td>
                  <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                      runat="server" 
                      ErrorMessage="Required Field"
                      ControlToValidate="EmailTextBox">
                  </asp:RequiredFieldValidator></td>
              <td>
                  <asp:Label ID="Label" runat="server" Text="Your email is used as username"></asp:Label></td>
          </tr>
          <tr>
              <td>First Name</td>
              <td>
                  <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                      runat="server" 
                      ErrorMessage="Required Field"
                      ControlToValidate="FirstnameTextBox">

                  </asp:RequiredFieldValidator></td>
          </tr>
          <tr>
              <td>Last Name</td>
              <td>
                  <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                       runat="server"
                       ErrorMessage="Required Field"
                      ControlToValidate="LastNameTextBox">

                  </asp:RequiredFieldValidator></td>
          </tr>
          <tr>
              <td>Password</td>
              <td>
                  <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                      runat="server"
                      ErrorMessage="Required Field"
                      ControlToValidate="PasswordTextBox">

                  </asp:RequiredFieldValidator></td>
          </tr>
          <tr>
              <td>Confirm Password</td>
              <td>
                  <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                       runat="server" 
                      ErrorMessage="Required Field"
                      ControlToValidate="ConfirmPasswordTextBox"> 

                  </asp:RequiredFieldValidator>
              &nbsp;
              <asp:CompareValidator ID="CompareValidator1" 
                   runat="server"
                   ErrorMessage="Passwords don't match"
                  ControlToValidate="ConfirmPasswordTextBox"
                  ControlToCompare="PasswordTextBox" >

              </asp:CompareValidator></td>
          </tr>
          <tr>
              <td>
                  <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
              <td>
                  <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label></td>
              <td></td>
          </tr>
      </table>
    
    </div>
    </form>
</body>
</html>
