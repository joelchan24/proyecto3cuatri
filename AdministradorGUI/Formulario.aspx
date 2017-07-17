<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AdministradorGUI.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 721px;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            width: 100%;
            top: 17px;
            left: 0px;
            height: 70px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server" class="auto-style1">
        <div class="row">
            <div class="auto-style2">
                 <h1>Municipios</h1>
            <div class="col-xs-8">
                <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="410px" Height="30px" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="País:"></asp:Label><br />
                <asp:DropDownList ID="ddl_Pais" runat="server" Width="410px" Height="30px"></asp:DropDownList><br />
                <asp:Label ID="Label2" runat="server" Text="Estado:"></asp:Label><br />
                <asp:DropDownList ID="ddl_Estado" runat="server" Width="410px" Height="30px"></asp:DropDownList><br />
                <asp:Label ID="Label3" runat="server" Text="Nombre del Municipio:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="410px" Height="30px" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                            <asp:Button runat="server" Text="Agregar" CssClass="btn btn-success btn-lg" ID="btnAgregar"/>
                            &nbsp;&nbsp;
                            <asp:Button runat="server" Text="Modificar" CssClass="btn btn-warning btn-lg" ID="btnModificar" />
                            &nbsp;&nbsp;
                            <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger btn-lg" ID="btnEliminar"/>
                            &nbsp;&nbsp;
                            <asp:Button runat="server" Text="Buscar" CssClass="btn btn-info btn-lg" ID="btnBuscar" />

                </div>
                <div class="col-xs-12">
                <div class="form-group">
                <asp:GridView ID="dgvMunicipios" CssClass="table table-striped table-bordered table-hover" runat="server">
                    <Columns>
                        <asp:ButtonField Text="Seleccionar" />
                    </Columns>
                    </asp:GridView>
            </div>
            </div>
                </div>
            </div>
                </div>
    </form>
</asp:Content>
