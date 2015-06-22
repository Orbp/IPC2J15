<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Cotizar.aspx.cs" Inherits="Proyecto.Aplicacion.Cotizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID ="PCliente" runat="server" >
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li><a href ="Inicio.aspx">Inicio</a></li> <li><a href="Cotizar.aspx">Cotizar</a></li>
                    <li class="active"><a href="Paquetes.aspx">Ver casilla</a></li>
                    <li><a href="Perfil.aspx">Perfil</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel  ID="pCotizar" runat="server">
        <ul>
            <asp:Label ID="Label1" runat="server" Text="Precio del producto:"></asp:Label>
            <asp:TextBox ID="TBPrecio" runat="server" ></asp:TextBox>
        </ul>
        <ul>
            <asp:Label ID="Label2" runat="server" Text="Peso del producto:"></asp:Label>
            <asp:TextBox ID="TBPeso" runat="server"></asp:TextBox>
        </ul>
        <ul>
            <asp:Label ID="Label3" runat="server" Text="Categoria:"></asp:Label>
            <asp:DropDownList ID="DDLCategoria" runat="server"></asp:DropDownList>
        </ul>
        <ul>
            <asp:Button id="BTCotizar" runat="server" Text="Cotizar" OnClick="BTCotizar_Click"/>
            <asp:Label ID="LblPrecio" runat="server"></asp:Label>
        </ul>
    </asp:Panel>
</asp:Content>
