<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthorList.aspx.cs" Inherits="AuthorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>
