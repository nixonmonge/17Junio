<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="_17Junio.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insertar Productos<br />
            Productos ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Nombre:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Precio:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Cantidad:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>
