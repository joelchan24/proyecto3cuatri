<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="adm_Usuario.aspx.cs" Inherits="AdministradorGUI.adm_Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 534px;
        }
        .auto-style2 {
            height: 346px;
            margin-left: -15px;
            margin-right: -15px;
        }
        .auto-style3 {
            height: 139px;
            margin-left: -15px;
            margin-right: -15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <form  id="form1" runat="server" class="auto-style1" >
             <div class="row">
              <h1 > control</h1>
                 <div class="auto-style3">
                           <div class="col-lg-4">
                            <div class="form-group">
                           <asp:Image ID="Image1" CssClass="img-thumbnail" runat="server" ImageUrl="~/img/avatar.png" width="70px"/> 
                            <asp:Button ID="Button5" CssClass="btn btn-info" runat="server" Text="Seleccionar" Width="100px" />
                            <asp:FileUpload ID="FileUploadFoto" runat="server" Height="24px" Width="263px" />
                        </div>
                        <script>
                            function readURL(input) {
                                if (input.files && input.files[0]) {
                                    var reader = new FileReader();

                                    reader.onload = function (e) {
                                        $('#<%=this.Image1.ClientID%>').attr('src', e.target.result);
                                    }

                                    reader.readAsDataURL(input.files[0]);
                                }
                            }

                            $('#<%=this.FileUploadFoto.ClientID%>').change(function () {
                                readURL(this);
                            });
                        </script>
                         </div>
                     </div>
                 <br />
            <div class="auto-style2">
              <div class="col-xs-4" >
                  <div class="form-group">
                      <label for="exampleinput">Nombre(s):</label>
                      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                      <label for="exampleinput">Apellido(s):</label>
                      <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Fecha de Nacimiento:</label>
                      <asp:TextBox ID="txt_aperura" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                        </div>
              </div>
             </div>
             
          </div>
       </form>
</asp:Content>
