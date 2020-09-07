<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DateTime.aspx.cs" Inherits="DateTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Odabir datuma i vremena prikazivanja filma</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Button ID="Odjava" runat="server" OnClick="Odjava_Click" Text="Odjava" />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Panel ID="Panel2" runat="server">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Vrijeme početka filma"></asp:Label>
            </asp:Panel>
        </asp:Panel>
    <div>
    
    </div>
    </form>
</body>
</html>
