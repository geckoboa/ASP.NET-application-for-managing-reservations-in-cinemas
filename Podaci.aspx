<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Podaci.aspx.cs" Inherits="Podaci" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Podaci o filmovima</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<asp:Label ID="Label2" runat="server" Text="Podaci o kinu" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Pocetna" runat="server" Text="Početna" OnClick="Pocetna_Click" style="align-content:flex-end" />
        </div>
        <p>
            </p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Osvetnici" Font-Size="Large" ForeColor="Red"></asp:Label>
            <br />
            <asp:Image ID="ImageButton1" runat="server" Height="165px" Width="314px" src="Resursi/Osvetnici1.jpg" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Rezerviraj" runat="server" OnClick="Rezerviraj_Click" Text="Rezerviraj" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Podaci"></asp:Label>
            :<br />
            <br />
            <asp:Panel ID="Panel2" runat="server">
                <asp:Label ID="Label5" runat="server" Text="Brzi i zestoki" Font-Size="Large" ForeColor="#0000CC"></asp:Label>
            </asp:Panel>
        </asp:Panel>
        <p>
            <asp:Image ID="ImageButton2" runat="server" Height="148px" Width="316px" src="Resursi/BrziIZestoki1.jpg" />
        &nbsp;&nbsp;
            <asp:Button ID="Rezerviraj1" runat="server" OnClick="Rezerviraj1_Click" Text="Rezerviraj" />
        </p>
        <asp:Label ID="Label6" runat="server" Text="Podaci"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label7" runat="server" Text="Bilo jednom u Hollywoodu " Font-Size="Large" ForeColor="#CC0066"></asp:Label>
            <br />
            <asp:Image ID="ImageButton3" runat="server" Height="140px" Width="321px" src="Resursi/Once1.jpg" />
            &nbsp;&nbsp;
            <asp:Button ID="Rezerviraj2" runat="server" OnClick="Rezerviraj2_Click" Text="Rezerviraj" />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Podaci"></asp:Label>
        </asp:Panel>
        <br />
    </form>
</body>
</html>
