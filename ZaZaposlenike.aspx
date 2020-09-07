<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ZaZaposlenike.aspx.cs" Inherits="ZaZaposlenike" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Za zaposlenike</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="LabelPopisSjedala" runat="server" Text="Popis sjedala za film"></asp:Label>
            &nbsp;Avengers Endgame&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Početna" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelOtkazanoSjedalo" runat="server" Text="Napisi sjedalo koje se otkazuje"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonOtkazi" runat="server" OnClick="ButtonOtkazi_Click" Text="Otkazi" />
&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server">
                <asp:Label ID="LabelPopisSjedala0" runat="server" Text="Popis sjedala za film"></asp:Label>
                &nbsp;Fast and Furious<br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="LabelOtkazanoSjedalo0" runat="server" Text="Napisi sjedalo koje se otkazuje"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonOtkazi0" runat="server" OnClick="ButtonOtkazi0_Click" Text="Otkazi" />
                &nbsp;
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Panel ID="Panel3" runat="server">
                    <asp:Label ID="LabelPopisSjedala1" runat="server" Text="Popis sjedala za film"></asp:Label>
                    &nbsp;Once upon a time in Hollywood<br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="LabelOtkazanoSjedalo1" runat="server" Text="Napisi sjedalo koje se otkazuje"></asp:Label>
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="ButtonOtkazi1" runat="server" OnClick="ButtonOtkazi1_Click" Text="Otkazi" />
&nbsp;&nbsp;<asp:Label ID="Label6" runat="server"></asp:Label>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
