<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="GaleriaImagenesaspx.aspx.cs" Inherits="GUI.GaleriaImagenesaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
     .borde
    {
     border-radius: 15px;
    }
         .auto-style1 {
             position: relative;
             min-height: 1px;
             float: left;
             width: 16.666666666666664%;
             left: 2px;
             top: -2px;
             padding-left: 15px;
             padding-right: 15px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-2">

        </div>
        <div class="col-md-8">
        <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">GALERIA</div>

                        </div> 
            <div class="row">
            <div class="form-group col-lg-6"><br />
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
                        </script><br />
            <div class="form-group col-lg-6" style="left: 0px; top: 0px">
                <asp:label ID="lblEvento" runat="server" text="Seleccionar Evento"></asp:label><br />
                <asp:dropdownlist ID="ddlEventos" CssClass="btn btn-default dropdown-toggle form-control"  data-toggle="dropdown" runat="server" width="150px" heigh="30px"></asp:dropdownlist>
                <asp:hiddenfield ID="txtID"  runat="server"></asp:hiddenfield>
            </div>
            </div><br />
                            <div class="panel panel-danger">
                        <div class="panel-heading">
                    <div class="col-md-12"><br />
                        <div class="btn-group-sm">
                        <asp:button ID="btnAgregar" runat="server" text="Agregar" width="80px" CssClass="btn btn-sm btn-info" OnClick="seleccionar" />
                        <asp:button ID="btnModificar" runat="server" text="Modificar" width="80px" CssClass="btn btn-sm btn-warning" OnClick="seleccionar" />
                        <asp:button ID="btnEliminar" runat="server" text="Eliminar" width="80px" CssClass="btn btn-sm btn-danger" OnClick="seleccionar" />
                        <asp:button ID="btnBuscar" runat="server" text="Buscar" width="80px" CssClass="btn btn-sm btn-success" />
                        <asp:button ID="btnLimpiar" runat="server" text="Limpiar" width="80px" CssClass="btn btn-sm btn-primary" />
                        </div>
                    </div>
                            </div>
            <br />
            <div class="row">
                <div class="col-md-12">
                    <div class="col-md-4">
                        <asp:GridView ID="dgvGaleria" runat="server" OnRowCreated="esconder" CssClass="table-resposive table table-bordered " OnRowCommand="se">
                            <Columns>
                                <asp:ButtonField CommandName="btnSeleccionar" ControlStyle-CssClass="btn btn-sm btn-success" Text="Seleccionar" />
                            </Columns>
                        </asp:GridView>
                    </div></div>
                </div>
            </div>
                    </div>
            </div>
        <div class="auto-style1">

        </div>
    </div>
        </div>
</asp:Content>
