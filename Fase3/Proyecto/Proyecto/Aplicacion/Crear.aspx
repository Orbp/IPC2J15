<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="Proyecto.Aplicacion.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID ="PCliente" runat="server" >
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li><a href ="Inicio.aspx">Inicio</a></li> 
                    <li><a href="Cotizar.aspx">Cotizar</a></li>
                    <li><a href="Paquetes.aspx">Ver casilla</a></li>
                    <li><a href="Perfil.aspx">Perfil</a></li>
                    <li class="active"><a href="Crear.aspx">Crear Pedido</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Para crear un paquete llene los siguientes espacios: "></asp:Label>
    <ul>
        <asp:Label ID="Label2" runat="server" Text="Precio del paquete: "></asp:Label>
        <asp:TextBox ID="TBPrecio" runat="server"></asp:TextBox> 
    </ul>
    <ul>
        <asp:Label ID="Label8" runat="server" Text="Moneda en la que se pedira el paquete: "></asp:Label>
        <asp:DropDownList ID="DDLMoneda" runat="server">
            <asp:ListItem>Moneda</asp:ListItem>
            <asp:ListItem>Q</asp:ListItem>
            <asp:ListItem>$</asp:ListItem>
        </asp:DropDownList>
    </ul>
    <ul>
        <asp:Label ID="Label3" runat="server" Text="Libraje del paquete: "></asp:Label>
        <asp:TextBox ID="TBLibraje" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Label ID="Label4" runat="server" Text="Categoria del producto: "></asp:Label>
        <asp:DropDownList ID="DDLCategoria" runat="server">
            <asp:ListItem>No Seleccionado</asp:ListItem>
        </asp:DropDownList>
    </ul>
    <ul>
        <asp:Label ID="Label5" runat="server" Text="Sucursal a enviar: "></asp:Label>
        <asp:DropDownList ID="DDLSucursal" runat="server">
            <asp:ListItem>No Seleccionado</asp:ListItem>
        </asp:DropDownList>
    </ul>
    <ul>
        <asp:Label ID="Label6" runat="server" Text="El valor de importar su producto será de: Q"></asp:Label>
        <asp:Label ID="Label7" runat="server"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="Label9" runat="server" Text="Nombre del pedido: "></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    </ul>

    <ul>
        <asp:Label ID="Label10" runat="server" Text="Descripcion del pedido: "></asp:Label>
        <asp:TextBox ID="TBDescripcion" runat="server"></asp:TextBox>
    </ul>

    <ul>
        <asp:Button ID="BTNAceptar" runat="server" Text="Crear pedido" OnClick="BTNAceptar_Click" />
    </ul>
</asp:Content>
