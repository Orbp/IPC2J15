<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Proyecto.Aplicacion.Perfil" %>
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
                    <li class="active"><a href="Perfil.aspx">Perfil</a></li>
                    <li><a href="Crear.aspx">Crear Pedido</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul>
        <asp:Label ID="LabelNombre" runat="server" Text="Bienvenido "></asp:Label>
    </ul>
    <ul>
        <asp:Label ID="Label1" runat ="server" Text="A continuación se muestran sus datos personales y podra editarlos para actualizar su información y darle un mejor servicio"></asp:Label>
    </ul>
    <ul>
        <asp:Label ID="Label2" runat="server" Text="Nombre:     "></asp:Label>
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Label ID="Label3" runat="server" Text="Apellido:   "></asp:Label>
        <asp:TextBox ID="TBApellido" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Label ID="Label4" runat="server" Text="NIT:         "></asp:Label>
        <asp:TextBox ID="TBNit" runat="server"></asp:TextBox>       
    </ul>
    <ul>
        <asp:Label ID="label5" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID ="TBTelefono" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Label ID="label6" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="TBDireccion" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Label ID="labe7" runat ="server" Text ="Número de tarjeta:"></asp:Label>
        <asp:TextBox ID="TBNume" runat="server"></asp:TextBox>
    </ul>
    <ul>
        <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar datos" OnClick="BtnActualizar_Click"/>
    </ul>
</asp:Content>
