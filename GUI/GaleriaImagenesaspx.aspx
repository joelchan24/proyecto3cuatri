<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="GaleriaImagenesaspx.aspx.cs" Inherits="GUI.GaleriaImagenesaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
     .borde
    {
     border-radius: 15px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-lg-3">

        </div>
        <div class="col-lg-6">
        <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">GALERIA</div>

                        </div> 
            <div class="row">
            <div class="form-group col-lg-6">
               <asp:Image ID="imgFoto" runat="server" CssClass="fa-arrow-circle-o-up" Height="80px" Width="140px" ImageUrl="~/img/avatar.png" />
                <asp:fileupload ID="fileFoto" runat="server"  width="145px" heigh="50px"></asp:fileupload>
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

                            $('#<%=this.fileFoto.ClientID%>').change(function () {
                                readURL(this);
                            });
                        </script>
            <div class="form-group col-lg-6">
                <asp:label ID="lblEvento" runat="server" text="Seleccionar Evento"></asp:label><br />
                <asp:dropdownlist ID="ddlEventos" CssClass="btn btn-default dropdown-toggle form-control"  data-toggle="dropdown" runat="server" width="150px" heigh="30px"></asp:dropdownlist>
                <asp:hiddenfield ID="txtID"  runat="server"></asp:hiddenfield>
            </div>
            </div><br />
            <div class="row">
                <div class="col-lg-12">
                    <div class="col-lg-4">

                    </div>
                     <div class="panel panel-primary">
                    <div class="col-lg-10"><br />
                        <div class="btn-group-sm">
                        <asp:button ID="btnAgregar" runat="server" text="Agregar" width="80px" CssClass="btn btn-sm btn-danger" />
                        <asp:button ID="btnModificar" runat="server" text="Modificar" width="80px" CssClass="btn btn-sm btn-warning" />
                        <asp:button ID="btnEliminar" runat="server" text="Eliminar" width="80px" CssClass="btn btn-sm btn-info" />
                        <asp:button ID="btnBuscar" runat="server" text="Buscar" width="80px" CssClass="btn btn-sm btn-success" />
                        <asp:button ID="btnLimpiar" runat="server" text="Limpiar" width="80px" CssClass="btn btn-sm btn-primary" />
                        </div>
                    </div>
                </div>
                        </div>
            </div><br />
            <div class="row">
                <div class="col-lg-12">
                    <div class="col-lg-2">

                    </div>
                    <div class="panel-info">
                        <div class="col-lg-8">

                        </div>
                    </div>
                    <div class="col-lg-2"></div>
                </div>
            </div>
            </div>
            </div>
        <div class="col-lg-2">

        </div>
    </div>
    </div>
</asp:Content>
