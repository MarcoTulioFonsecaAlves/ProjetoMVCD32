<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="ProjetoMVCD32.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblCPF" runat="server" Text="CPF:"></asp:Label><br />
            <asp:TextBox ID="txtCPFD32" runat="server" TextMode="Number"></asp:TextBox><br />
            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label><br />
            <asp:TextBox ID="txtNomeD32" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblNMae" runat="server" Text="Nome da Mãe:"></asp:Label><br />
            <asp:TextBox ID="txtNomeMaeD32" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" BackColor="#6666FF" BorderStyle="Outset" /><br />

        </div>
    </form>
</body>
</html>
