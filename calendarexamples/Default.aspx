<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Array Sample</title>
    <link href="CalendarCss.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="AuthorsDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="AuthorsDropDownList_SelectedIndexChanged"></asp:DropDownList><br /> 
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
