<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_UsuarioGUI.aspx.cs" Inherits="AdministradorGUI.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 1235px;
            width: 1080px;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 250px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <link href="css/estilo-usuario.css" rel="stylesheet" />
    <form id="form1" runat="server">
        <div class="row">
                <div class="col-lg-4">
                <div class="form-group">
                    <asp:Image ID="imgFoto" runat="server" CssClass="fa-arrow-circle-o-up" Height="163px" Width="230px" /><br />
                    <asp:FileUpload ID="file_foto" runat="server" Width="230px" />
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Label ID="label1" Text="ID:" runat="server" CssClass="text-blue"></asp:Label><br />
                    <asp:TextBox ID="txtID" runat="server"  Width="300px" Height="10px"></asp:TextBox><br />
                    <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="text-blue"></asp:Label><br />
                    <asp:TextBox ID="txtNombre" runat="server" Width="300px" Height="10px"></asp:TextBox><br />
                    <asp:Label ID="Label3" runat="server" Text="Apellido(s):" CssClass="text-blue"></asp:Label><br />
                    <asp:TextBox ID="txtApellido" runat="server" Width="300px" Height="10px"></asp:TextBox>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Label ID="lblFecha" runat="server" CssClass="text-blue" Text="Fecha de Nacimiento"></asp:Label><br />
                    <asp:TextBox ID="txtfecha" runat="server" CssClass="form-control" type="date" Width="300px" Height="32px"></asp:TextBox>
                </div>
            </div>

        </div>
    </form>
</asp:Content>
