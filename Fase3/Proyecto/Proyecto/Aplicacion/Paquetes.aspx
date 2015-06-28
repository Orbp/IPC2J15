<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Paquetes.aspx.cs" Inherits="Proyecto.Aplicacion.Paquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID ="PCliente" runat="server" >
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li><a href ="Inicio.aspx">Inicio</a></li> 
                    <li><a href="Cotizar.aspx">Cotizar</a></li>
                    <li class="active"><a href="Paquetes.aspx">Ver casilla</a></li>
                    <li><a href="Perfil.aspx">Perfil</a></li>
                    <li><a href="Crear.aspx">Crear Pedido</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul>
        <asp:Label id="LabelNombre" runat="server" Text="Bienvenido"></asp:Label>
    </ul>
        <asp:GridView ID="DGProducto" runat="server" AutoGenerateColumns="false" DataKeyNames ="Número" DataSourceID="datospedido">
            <Columns>
                <asp:BoundField DataField ="Número" HeaderText="Número" ReadOnly="true" SortExpression="Número"/>

            </Columns>
        </asp:GridView>
    <asp:SqlDataSource ID="datospedido" runat="server"></asp:SqlDataSource>
    <ul>
        <asp:Label ID="Label1" runat="server" Text="Número de casilla:"></asp:Label>
        <asp:Label ID="LabelCasilla" runat="server"></asp:Label>
    </ul>
</asp:Content>
