<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrojSjedala.aspx.cs" Inherits="BrojSjedala" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rezervacija filma</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Izaberi film" Font-Bold="True" Font-Size="Large"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>--&gt;Choose one&lt;--</asp:ListItem>
                <asp:ListItem>Avengers Endgame</asp:ListItem>
                <asp:ListItem>Fast and Furious</asp:ListItem>
                <asp:ListItem>Once upon a time in Hollywood</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Početna" />
            <br />
            <br />
            <asp:Label ID="SlobodnaSjedala" runat="server" Text="Slobodna sjedala su" ForeColor="#660066"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonRezerviraj" runat="server" OnClick="ButtonRezerviraj_Click" Text="Rezerviraj" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
