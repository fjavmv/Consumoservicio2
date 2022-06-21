<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ConsumeServicio.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cosumo de servicios web creados</h1>
        </div>

        <div>
            <h2>Número aleatorio</h2>
            <p>
                <asp:Label ID="LblAleatorio" runat="server" Text="Label"></asp:Label>
            </p>
        </div>

        <div>
            <h2>Convertir grados Fahrenheit a grados centígrados </h2>
            </div>
                <label>Temperatura a convertir: 
        <asp:TextBox ID="TxtTeperatura1" runat="server"></asp:TextBox>
        <asp:Button ID="BtnC1" runat="server" Text="Button" OnClick="BtnC1_Click" />
        <label>Resultado:</label>
        <asp:Label ID="LblFC" runat="server" Text="Label"></asp:Label>
       
        </div>

        

        <div>
            <h2>Convertir grados grados centígrados a Fahrenheit</h2>
                <label>Temperatura a convertir: 
            <asp:TextBox ID="TxtTeperatura2" runat="server"></asp:TextBox>
            <asp:Button ID="BtnC2" runat="server" Text="Button" OnClick="BtnC2_Click" />
            Resultado: 
            <asp:Label ID="LblCF" runat="server" Text="Label"></asp:Label>
            </label>
               
        </div>

        <div>
            <h2>Suma de valores</h2>
                <label>valor uno:</label>
                
                <label>
            <asp:TextBox ID="Txtval1" runat="server"></asp:TextBox>
            Valor dos: 
            <asp:TextBox ID="Txtval2" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSuma" runat="server" Text="Sumar" OnClick="BtnSuma_Click" />
            Resultado:
       
            <asp:Label ID="LblResultado" runat="server" Text="Label"></asp:Label>
       
         </div>


    </form>
</body>
</html>
