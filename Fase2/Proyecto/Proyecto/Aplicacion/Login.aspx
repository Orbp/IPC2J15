<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto.Aplicacion.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <div id="topbar">
        <div id="topnav">
            <ul>
                <li><a href="Default.aspx">Inicio</a></li>
                <li class="active"><a href="Login.aspx">Inicio de sesion</a></li>
            </ul>
        </div>
        <br class="clear"/>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" OnAuthenticate="Login1_Authenticate"></asp:Login>
</asp:Content>
