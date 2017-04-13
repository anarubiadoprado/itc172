<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calendarevents.aspx.cs" Inherits="calendarevents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar Events- Assigment2</title>
    <link href="calendarstyle.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <h2> Welcome to my Calendar! </h2>
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar> <br />
        <asp:Label ID="Label1" runat="server" Text="" CssClass="result"></asp:Label>
    </div>
    </form>
</body>
</html>
