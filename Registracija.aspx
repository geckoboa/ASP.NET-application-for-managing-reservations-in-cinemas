<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registracija.aspx.cs" Inherits="Registracija" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Početna" />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Regi" runat="server" OnClick="Regi_Click" Text="Registracija" />
            <br />
            <br />
            <asp:Label ID="Source" runat="server"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
