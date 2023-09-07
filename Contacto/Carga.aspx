<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carga.aspx.cs" Inherits="Contacto.Carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
            <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            
            <br />
            <asp:Button ID="Button2" runat="server" Text="Atras" OnClick="Button2_Click" />



            </div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
