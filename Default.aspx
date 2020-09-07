<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kino rezervacija</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div style="background-image: url('Slike/kino2.jpg'); height:480px; width: 1351px;">
        <div align=center style= " background-color:white; padding: 10px; border-bottom:initial; border-style: solid; border-color: #666699; width: 50%; margin-left: 25%; text-align: center;">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="Dobrodošli na stranicu kino rezervacija!"></asp:Label>
            <br />
            <br />
        <asp:Button ID="Podaci" runat="server" OnClick="Podaci_Click" Text="Podaci o kinu i filmovima" />
        &nbsp;&nbsp;
        <asp:Button ID="Rezervacija" runat="server" OnClick="Rezervacija_Click" Text="Prijava" />
    
            
        &nbsp;
    
            
        <asp:Button ID="ButtonSlike" runat="server" OnClick="ButtonSlike_Click" Text="Slike" />
    </div>
    </div>
    </form>
    <link rel="stylesheet" type="text/css" href="C:\Users\Nik Titanik\Documents\Visual Studio 2015\WebSites\WebSite2\CSS.css" />
</body>
</html>
