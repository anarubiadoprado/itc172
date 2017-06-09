<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viewgrants.aspx.cs" Inherits="Viewgrants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Display</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>This is your Grant</h2>
        <asp:GridView ID="GrantGridView" runat="server" OnSelectedIndexChanged="GrantGridView_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>
