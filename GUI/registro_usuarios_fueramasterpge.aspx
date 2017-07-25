<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_usuarios_fueramasterpge.aspx.cs" Inherits="GUI.registro_usuarios_fueramasterpge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/jquery-2.2.3.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- gerardo ignora lo que aqrrib es que si no se pongo lo tira feo nose por que de todos modos lo checas -->
        <div id="signupbox" style=" margin-top:50px" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title">Registrame</div>
                            <div style="float:right; font-size: 85%; position: relative; top:-10px"><a id="hop" href="WebForm1.aspx" >Regresar al Inicio</a>&nbsp;&nbsp;<a id="signinlink" href="loggin_fuerademasterpage.aspx" >Ingresar</a></div>

                        </div>  
                        <div class="panel-body col-lg-12" >
                                
                                <div id="signupalert" style="display:none" class="alert alert-danger">
                                    <p>Error:</p>
                                    <span></span>
                                </div>
                                    
                                <!--ESTE DIVI ES PARA CARGAR LA FOTO-->
                            <div class="row">
                                   <div class="form-group col-lg-6">
                                    <asp:Image ID="imgFoto" runat="server" CssClass="fa-arrow-circle-o-up" Height="80px" Width="140px" ImageUrl="~/img/avatar.png" /><br />
                                    <asp:FileUpload ID="file_foto" runat="server" Width="140px"/>
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
                                <div class="form-group col-lg-6">
                                    <asp:Label ID="Label1"  runat="server" Text="Nombre(s)" for="email"></asp:Label>
                                        &nbsp;<asp:TextBox ID="txtNombre" runat="server" type="text" class="form-control" placeholder="Nombre"></asp:TextBox>
                                    <asp:Label ID="Label2" runat="server" Text="Apellido(s):" for="email"></asp:Label><br />
                                   <asp:TextBox ID="txtapellidos" runat="server" type="text" class="form-control" placeholder="Apellido"></asp:TextBox>

                                    </div>
                                </div>
                            <div class="row">
                              <div class="form-group col-lg-6">
                                       <asp:Label ID="Telefono" runat="server" Text="Telefono:" for="email" ></asp:Label>
                                       <asp:TextBox ID="TxtTelefono" runat="server" type="text" class="form-control" placeholder="Digite(10 digitos)" MaxLength="10"></asp:TextBox>
                                       <asp:Label ID="lblFecha" runat="server" Text="Fecha de Nacimiento:" for="email"></asp:Label>
                                       <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" class="form-control"></asp:TextBox>
                                      <asp:Label ID="lblCorreo" runat="server" Text="Correo:" for="email" ></asp:Label>
                                       <asp:TextBox ID="txtCorreo" runat="server" type="text" class="form-control" placeholder="Correo" ></asp:TextBox>
                              </div>
                                <div class="form-group col-lg-6">
                                  <asp:Label ID="Label3" runat="server" Text="Tipo de usuario" for="email"></asp:Label>
                                  <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="form-control"></asp:DropDownList>
                                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario" for="email"></asp:Label>
                                    <asp:TextBox ID="txtUsuario" runat="server" type="text" class="form-control" placeholder="Usuario..."></asp:TextBox>
                                    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" for="email"></asp:Label>
                                    <asp:TextBox ID="txtContraseña" runat="server" type="password" class="form-control" placeholder="Contraseña"></asp:TextBox>
                                </div>
                                </div>
                            <div class="row">
                                <div class="form-group col-lg-6">
                                     <asp:Label ID="lblMunicipio" runat="server" Text="Municipio:" for="email"></asp:Label>
                                  <asp:DropDownList ID="ddlMunicipio" runat="server" CssClass="form-control"></asp:DropDownList>
                                    <asp:Label ID="lblColonia" runat="server" Text="Colonia:" for="email"></asp:Label>
                                    <asp:TextBox ID="txtColonia" runat="server" type="text" class="form-control" placeholder="Colonia"></asp:TextBox>
                                    <asp:Label ID="lblCodigoPostal" runat="server" Text="Codigo Postal:" for="email"></asp:Label>
                                    <asp:TextBox ID="txtCOdigoPostal" runat="server" type="text" class="form-control" placeholder="Digite (5 digitos)" MaxLength="5"></asp:TextBox>

                                </div>
                                <div class="form-group col-lg-6">
                                     <asp:Label ID="lblCruzamiento" runat="server" Text="Cruzamiento:" for="email"></asp:Label>
                                     <asp:TextBox ID="txtCruzamiento" runat="server" CssClass="form-control" placeholder="Cruzamiento"></asp:TextBox>
                                     <asp:Label ID="lblNumeroInterio" runat="server" Text="Numero Interior" for="email"></asp:Label>
                                     <asp:TextBox ID="txtNumeroInterior" runat="server" CssClass="form-control" placeholder="Numero Interior"></asp:TextBox>
                                     <asp:Label ID="lblNumeroExterior" runat="server" Text="Numero Exterior" for="email"></asp:Label>
                                     <asp:TextBox ID="txtNumeroExteriror" runat="server" CssClass="form-control"  placeholder="Numero Exterior"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-5"></div>
                                <div class="form-group col-lg-5">
                                    <!-- Button -->   <asp:Button ID="btnAgregar" runat="server" Text="Registrarme" CssClass="btn btn-info" OnClick="accion1"/>                                        
                                </div>
                                <div class="col-lg-2"><asp:HiddenField ID="txtID" runat="server" /></div>
                                </div>
                                
                               
                                
                                
                         </div>
                    

               
               
                </div>
      
  
    </div>
        </form>
</body>
</html>
