<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1_W3_D1_Homework_Backend.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="NomeInput" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox ID="CognomeInput" runat="server"></asp:TextBox>
            <hr />
            <asp:DropDownList ID="MenuSala" runat="server">
                <asp:ListItem Value="SALA NORD">SALA NORD</asp:ListItem>
                <asp:ListItem Value="SALA EST">SALA EST</asp:ListItem>
                <asp:ListItem Value="SALA SUD">SALA SUD</asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBox ID="BigliettoRidotto" text="Biglietto ridotto" runat="server" />
            <hr />
            <asp:Button ID="BottonePrenotazione" runat="server" Text="Button" OnClick="BottonePrenotazione_Click"/>
        </div>
        <div>
            <h1>Informazioni Supplementari</h1>
            <asp:Label ID="SalaNord" Text="Biglietti venduti SALA NORD: , di cui   ridotti." runat="server" />
            <hr />
            <asp:Label ID="SalaEst" Text="Biglietti venduti SALA EST: , di cui   ridotti." runat="server" />
            <hr />
            <asp:Label ID="SalaSud" Text="Biglietti venduti SALA SUD: , di cui   ridotti." runat="server" />
        </div>
    </form>
</body>
</html>
