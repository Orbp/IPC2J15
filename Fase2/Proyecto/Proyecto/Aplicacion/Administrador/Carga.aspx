<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Carga.aspx.cs" Inherits="Proyecto.Aplicacion.Administrador.Carga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID="pAdmin" runat="server">
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li><a href="Inicio.aspx">Inicio</a></li>
                    <li class="active"><a href="Administrador/Carga.aspx">Carga masiva de información</a></li>
                    <li><a href="Administrador/Cobros.aspx">Cobros</a></li>
                    <li><a href="Administrador/Agregar.aspx">Agregar un empleado nuevo</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul><asp:FileUpload ID="FileUpload1" runat="server" /></ul>
    <asp:Button ID="BotonCargar" runat="server" OnClick="BotonCargar_Click" Text="Cargar Archivo"/>
</asp:Content>
