<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Comentarios.aspx.cs" Inherits="AdministradorGUI.Comentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            width: 100%;
            top: 17px;
            left: 1px;
            height: 214px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 31%;
            top: 17px;
            left: 1px;
            height: 154px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 50%;
            top: 17px;
            left: 1px;
            height: 155px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style4 {
            height: 642px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server" class="auto-style4">
        <div class="panel panel-primary">
            <div class="auto-style1">
                <div class="auto-style2">
        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" CssClass=" form-control" runat="server" Width="305px" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Evento:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Width="305px" Enabled="False"></asp:TextBox>
                    </div>
                <div class="auto-style3">
                    <asp:label runat="server" text="Comentario:"></asp:label><br />
                    <asp:TextBox ID="txtComentario" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; " CssClass="form-control" runat="server" Height="116px" Width="535px"></asp:TextBox>
                </div>
                </div>
            </div>
        <div class="panel panel-success">
            <div class="panel-heading">
                <asp:button runat="server" ID="btnModificar" text="Modificar" CssClass="btn btn-primary" OnClick="seleccionar" /> <asp:button ID="btnEliminar" runat="server" text="Eliminar" CssClass="btn btn-danger" OnClick="seleccionar" /> <asp:button ID="btnBuscar" runat="server" text="Buscar" CssClass="btn btn-success" OnClick="seleccionar" />
                <asp:button ID="btnLimpiar" runat="server" text="Limpiar" CssClass="btn btn-dropbox" OnClick="seleccionar" />
            </div>
            </div>
            <br />
            <div class="panel panel-danger">
                <asp:gridview runat="server" ID="dgbDatos" CssClass="table table-responsive table-bordered" OnRowCommand="selecionar" OnRowCreated="ocultar">
                    <Columns>
                        <asp:ButtonField CommandName="btnSeleccionar" Text="Seleccionar" />
                    </Columns>
                </asp:gridview>
            </div>
        <div>
            <asp:hiddenfield runat="server" ID="txtIDcomentario"></asp:hiddenfield>
            <asp:hiddenfield runat="server" ID="txtUsuarioID"></asp:hiddenfield>
            <asp:hiddenfield runat="server" ID="txtEventoID"></asp:hiddenfield>
        </div>
    </form>
</asp:Content>
