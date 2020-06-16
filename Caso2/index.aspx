<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Caso2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="User" runat="server" Text="Usuario" ></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Password" runat="server" Text="Contraseña" ></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Onclick="btnIngresar_Click" />
        </div>
    </form>
</body>
</html>
