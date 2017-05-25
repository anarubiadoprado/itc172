<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Application.aspx.cs" Inherits="Application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Grant Application </h1>
    <table>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Select Date</td>
            <td>
                <asp:Calendar ID="DateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="85px" Width="179px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="DateRequiredFieldValidator" runat="server" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Amount $</td>
            <td>
                <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
            </td>
             <td>
                <asp:RequiredFieldValidator ID="AmountRequiredFieldValidator" runat="server" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Explanation</td>
            <td>
                <asp:TextBox ID="ExplanationTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ExplanationRequiredFieldValidator" runat="server" ErrorMessage="Required Field!"></asp:RequiredFieldValidator>
            </td>
        </tr>

    </table>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
