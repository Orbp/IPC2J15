<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto.Aplicacion.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <div id ="topbar">
        <div id ="topnav">
            <ul>
                <li><a href ="/Default.aspx">Inicio</a></li>
                <li><a href="Login.aspx">Inicio de sesion</a></li>
                <li class ="active"><a href ="Registro.aspx">Registro de cliente</a></li>
            </ul>
        </div>
        <br class="clear" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul>
        <asp:Label ID="label1" runat="server" Text="Llene los siguientes campos para crear una nueva cuenta: "></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="TbNombre" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="Label4"  runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="TBApellido" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="Label6" runat="server" Text="NIT:"></asp:Label>
        <asp:TextBox ID="TBNit" runat="server"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label id="Label8" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="TBTelefono" runat="server"></asp:TextBox>
        <asp:Label ID ="Label19" runat ="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="Label10" runat="server" Text="Domicilio"></asp:Label>
        <asp:TextBox ID="TBDomicilio" runat="server"></asp:TextBox>
        <asp:Label ID="Label11"  runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="label12" runat="server" Text="Numero Tarjeta"></asp:Label>
        <asp:TextBox ID="TBNume" runat="server"></asp:TextBox>
        <asp:Label ID="label13" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="label14" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="TBUsuario" runat="server"></asp:TextBox>
        <asp:Label ID="label15" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="label16" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="TBContraseña" runat="server"></asp:TextBox>
        <asp:Label ID="label17" runat="server" Text="(*)"></asp:Label>
    </ul>

    <ul>
        <asp:Label ID="label18" runat="server" Text="DPI"></asp:Label>
        <asp:TextBox ID="TBDpi" runat="server"></asp:TextBox>
        <asp:Label ID="label9" runat="server"  Text="(*)"></asp:Label>
    </ul>
    <ul>
        <asp:Label ID="label20" runat="server" Text="Sucursal"></asp:Label>
        <asp:DropDownList ID ="DDL1" runat ="server"></asp:DropDownList>
    </ul>
    <ul>
        <asp:Button ID="BTNRegistrar" runat="server" Text="Registrar" OnClick="BTNRegistrar_Click" />
    </ul>
</asp:Content>
