<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prijava.aspx.cs" Inherits="Prijava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prijava</title>
    <Script language="javascript">
        Windows.History.Forward(-1);
    </Script>
</head>

<body>
    
    <form id="form1" runat="server">
        <div align=center style=" background-color:white; padding: 10px; border-style: solid; border-color: #666699; width: 50%; margin-left: 25%; text-align: center;">
    <div>
    
        Prijava/Registracija&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Pocetna" runat="server" OnClick="Pocetna_Click" Text="Početna" />
        </div>
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="Username "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="LabelPoruka" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register now" />
        </p>
            </div>
    </form>
</body>
</html>
