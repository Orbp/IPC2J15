<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto.Aplicacion.Default" %>
<asp:Content ID="mens" ContentPlaceHolderID="menus" runat="server">
    <div id ="topbar">
        <div id ="topnav">
            <ul>
                <li class ="active"><a href ="/Default.aspx">Inicio</a></li>
                <li><a href="Login.aspx">Inicio de sesion</a></li>
            </ul>
        </div>
        <br class="clear" />
    </div>
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Debe iniciar sesión o registrarse para poder pedir objetos.
    </p>
</asp:Content>