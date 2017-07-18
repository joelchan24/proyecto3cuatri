﻿<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="AdministradorGUI.Usuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        #form1 {
            height: 1235px;
            width: 1080px;
        }
        .auto-style3 {
            height: 224px;
            margin-bottom: 15px;
        }
        .auto-style4 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 241px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style5 {
            height: 242px;
            margin-bottom: 15px;
        }
        .auto-style6 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 246px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style7 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 215px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style9 {
            height: 512px;
            margin-left: -15px;
            margin-right: -15px;
        }
        .auto-style10 {
            height: 246px;
            margin-left: -15px;
            margin-right: -15px;
        }
        .auto-style11 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 215px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style12 {
            width: 1924px;
            height: 1573px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="css/estilo-usuario.css" rel="stylesheet" />
    <form id="form1" runat="server" class="auto-style12">
        <div class="row auto-style9" style="height: 262px">
                <div class="auto-style4">
                <div class="auto-style3">
                    <asp:Image ID="imgFoto" runat="server" CssClass="fa-arrow-circle-o-up" Height="163px" Width="230px" ImageUrl="~/img/avatar.png" /><br />
                    <asp:FileUpload ID="file_foto" runat="server" Width="230px" />
                </div>
            </div>
            <script>
                            function readURL(input) {
                                if (input.files && input.files[0]) {
                                    var reader = new FileReader();

                                    reader.onload = function (e) {
                                        $('#<%=this.imgFoto.ClientID%>').attr('src', e.target.result);
                                    }

                                    reader.readAsDataURL(input.files[0]);
                                }
                            }

                            $('#<%=this.file_foto.ClientID%>').change(function () {
                                readURL(this);
                            });
                        </script>
            <div class="auto-style6">
                <div class="auto-style5">
                    <asp:Label ID="label1" Text="ID:" runat="server" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control"  Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Apellido(s):" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                </div>
            </div>
            <div class="auto-style7">
                <div class="form-group">
                    <asp:Label ID="lblFecha" runat="server" CssClass="text-blue" Text="Fecha de Nacimiento"></asp:Label>
                    <asp:TextBox ID="txtfecha" runat="server" CssClass="form-control" type="date" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblTelefono" runat="server" CssClass="text-blue" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblCorreo" runat="server" CssClass="text-blue" Text="Correo"></asp:Label>
                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                </div>
            </div>

        </div>
        <div class="auto-style10">
            <div class="auto-style7">
                <div class="form-group">
                    <asp:Label ID="lblTipoUsuario" runat="server" Text="Tipo de Usuario" CssClass="text-blue"></asp:Label>
                    <asp:DropDownList ID="ddlTipousuario" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:DropDownList>
                    <asp:Label ID="lblUsuario" runat="server" CssClass="text-blue" Text="Usuario:"></asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblContraseña" runat="server" CssClass="text-blue" Text="Contraseña:"></asp:Label>
                    <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                </div>
            </div>
            <div class="auto-style7">
                <div class="form-group">
                    <asp:Label ID="lblMunicipio" runat="server" Text="Municipio:" CssClass="text-blue"></asp:Label>
                    <asp:DropDownList ID="ddlMunicipio" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:DropDownList>
                    <asp:Label ID="lblColonia" runat="server" Text="Colonia:" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtColonia" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblCodigoPostal" runat="server" CssClass="text-blue" Text="Codigo Postal:"></asp:Label>
                    <asp:TextBox ID="txtCodigoPostal" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                </div>

            </div>
            <div class="auto-style11">
                <div class="form-group">
                    <asp:Label ID="lblCruzamiento" runat="server" Text="Cruzamiento" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtCruzamiento" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblNumeroInterio" runat="server" Text="Numero Interior" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtNumeroInterior" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>
                    <asp:Label ID="lblNumeroExterior" runat="server" Text="Numero Exterior" CssClass="text-blue"></asp:Label>
                    <asp:TextBox ID="txtNumeroExteriror" runat="server" CssClass="form-control" Width="300px" Height="32px"></asp:TextBox>

                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="form-group">
                 <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-dropbox" Width="100px" Height="50px"  /> <asp:Button ID="btnModificar" Text="Modificar" runat="server" CssClass="btn btn-dropbox" Width="100px" Height="50px" /> <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" CssClass="btn btn-dropbox" Width="100px" Height="50px" /> <asp:Button ID="btnNuevo" Text="Nuevo" runat="server" CssClass="btn btn-dropbox" Width="100px" Height="50px" /> <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-dropbox" Width="100px" Height="50px" />
                </div>

            </div>

        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="form-group">
                    <asp:GridView ID="dtgDatos" runat="server" CssClass="fc-grid"></asp:GridView>
                </div>

            </div>
        </div>
    </form>
</asp:Content>