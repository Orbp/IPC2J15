<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto.Aplicacion.Inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="menus" runat="server">
    <asp:Panel ID ="PCliente" runat="server" >
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li class="active"><a href ="Inicio.aspx">Inicio</a></li> 
                    <li><a href="Cotizar.aspx">Cotizar</a></li>
                    <li><a href="Paquetes.aspx">Ver casilla</a></li>
                    <li><a href="Perfil.aspx">Perfil</a></li>
                    <li><a href="Crear.aspx">Crear Pedido</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>

    <asp:Panel ID="PEmpleado" runat="server">
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li class="active"><a href ="Inicio.aspx">Inicio</a></li>
                    <li><a href="Empleado/Clienteaprobar.aspx">Clientes para aprobar</a></li>
                    <li><a href="#">Paquetes</a>
                        <ul>
                            <li><a href="Empleado/Verpaquetes.aspx">Paquetes</a></li>
                            <li><a href="Empleado/Bodega.aspx">Bodega</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Servicio al cliente</a>
                        <ul>
                            <li><a href="Empleado/Factura.aspx">Facturacion</a></li>
                            <li><a href="Empleado/Devoluciones.aspx">Devoluciones</a></li>
                            <li><a href="Empleado/Busqueda.aspx">Busqueda de clientes</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pDirector" runat="server">
        <div id="topbar">
            <div id ="topnav">
                <ul>
                    <li class ="active"><a href="Inicio.aspx">Inicio</a></li>
                    <li><a href="Director/Contratacion.aspx">Realizar Contratación</a></li>
                    <li><a href="Director/Equipo.aspx">Consultar equipo de trabajo</a></li>
                    <li><a href="Director/Modificar.aspx">Modificar Contrataciones</a></li>
                    <li><a href="Director/Despido.aspx">Despedir empleado</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>

    <asp:Panel ID="pAdmin" runat="server">
        <div id="topbar">
            <div id="topnav">
                <ul>
                    <li class ="active"><a href="Inicio.aspx">Inicio</a></li>
                    <li><a href="Administrador/Carga.aspx">Carga masiva de información</a></li>
                    <li><a href="Administrador/Cobros.aspx">Cobros</a></li>
                    <li><a href="Administrador/Agregar.aspx">Agregar un empleado nuevo</a></li>
                </ul>
            </div>
            <br class="clear" />
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="labelnombre" runat="server"></asp:Label>
</asp:Content>
