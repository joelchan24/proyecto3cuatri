<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="registroevento.aspx.cs" Inherits="GUI.registroevento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title"><h3 style="text-align:center">CONTROL DE REGISTRO DE EVENTOS</h3></div>

                        </div> 
    <div class="container">
       
        
    <script src="https://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    <script src="js/locationpicker.jquery.js"></script>

          <div class="row">

              <h1 > control</h1>
               <asp:HiddenField  ID="txtid" runat="server" />
              <asp:HiddenField ID="txtx_usuariop" runat="server" />
              <asp:HiddenField ID="txt_codir" runat="server"  />
              <div class="col-xs-4" >
                  <div class="form-group">
                      <label for="exampleinput">nombre</label>
                      <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control" OnTextChanged="txt_nombre_TextChanged"></asp:TextBox>
                      <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
  ControlToValidate="txt_nombre"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Fecha Apertura</label>
                      <asp:TextBox ID="txt_aperura" runat="server" CssClass="form-control" type="date" ></asp:TextBox>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput" >Fecha De Cierre</label>
                        <asp:TextBox ID="txt_fecha_cierre" runat="server" CssClass="form-control " type="date" ></asp:TextBox>
                    </div>
                   
               </div>
             
          </div>
        

              <div class="row" >
              
              <div class="col-xs-4" >
                  <br />
                  <div class="form-group input-group">
                      <label for="exampleinput" >Precio</label>
                     
                       <span class="input-group-addon "><i   >$</i></span>
                      <asp:TextBox ID="txt_precio" runat="server" CssClass="form-control " style="width:70%"></asp:TextBox>
                       <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
  ControlToValidate="txt_precio"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="txt_precio" ErrorMessage="*Ingrese Valores Numericos"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]*">
</asp:RegularExpressionValidator>
                      <br />
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Categoria</label><br />
                      <asp:DropDownList ID="ddl_categoria" runat="server" Width="100%"></asp:DropDownList>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput" >Municipio</label><br />
                       <asp:DropDownList ID="ddl_municipio" runat="server" Width="100%"></asp:DropDownList>  

                    </div>
                   
               </div>
      

          </div>
         <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="exampleinput">Ubicacion</label>
                   
                    <asp:TextBox ID="txt_ubicar" runat="server" CssClass="form-control"></asp:TextBox>


                </div>
                <div class="form-group">
                    <div id="ModalMapPreview" style="width:100%; height:300px;"></div>
                </div>
                <!--altitud y lon-->
               
                <div class="form-group">
                    <label for="exampleinput">lat:</label>
                    <asp:TextBox ID="txtlat" runat="server" Text="20.938297181414647" CssClass="form-control"></asp:TextBox>
                     <label for="exampleinput">log:</label>
                    <asp:TextBox ID="txt_lo" runat="server" Text="-89.61501516379462" CssClass="form-control"></asp:TextBox>
                </div>
                <!--altasb  , bjaas y ca,mbios botonos-->
                <div>
                         </div>
            </div>
            <div class="col-md-4">

                
                  <div class="form-group">
                      <label for="exampleinput">C.P</label>
                      <asp:TextBox ID="txt_postal" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
  ControlToValidate="txt_postal"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txt_postal" ErrorMessage="*Ingrese Valores Numericos"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]*">
</asp:RegularExpressionValidator>
                      <br />
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Colonia</label>
                      <asp:TextBox ID="txt_colonia" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
  ControlToValidate="txt_colonia"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Número Interior</label>
                        <asp:TextBox ID="txt_numint" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
  ControlToValidate="txt_numint"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                            ControlToValidate="txt_numint" ErrorMessage="*Ingrese Valores Numericos"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]*">
</asp:RegularExpressionValidator>
                        <br />
                    </div>
                 <div class="form-group">
                      <label for="exampleinput">Número Exterior</label>
                      <asp:TextBox ID="txt_numexter" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
  ControlToValidate="txt_numexter"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
                      <br />
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                            ControlToValidate="txt_numexter" ErrorMessage="*Ingrese Valores Numericos"
                            ForeColor="Red"
                            ValidationExpression="^[0-9]*">
</asp:RegularExpressionValidator>
                     <br />
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Cruzamientos</label>
                      <asp:TextBox ID="txt_crizamiento" runat="server" CssClass="form-control"></asp:TextBox>
                       <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server"
  ControlToValidate="txt_crizamiento"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
              </div>
                <br />
                <div class="form-group">
                      <label for="exampleinput">Subir Imagen</label>
                     
                        <asp:Image ID="Image1" runat="server" Width="100px" Height="50px"/>
                    <asp:FileUpload ID="file_foto" runat="server" />
                     
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

                            $('#<%=this.file_foto.ClientID%>').change(function () {
                                readURL(this);
                            });
                        </script>
               
              
        </div>
              <div class="col-md-4">

                
                  <div class="form-group">
                      <label for="exampleinput">Descripcion</label>
                     <asp:TextBox id="txt_descrip" TextMode="multiline" Columns="50" Rows="5" runat="server" CssClass="form-control " width="349px" height="350px"></asp:TextBox>                 />
                     
                  </div>

              
            
                   
                   
                   

              
            
                    <div class="form-group">
                       <label for="exampleinput" >aprovacion</label><br />
                      <label class="radio-inline" >
                          <asp:RadioButton ID="rbt_aprovado" runat="server" type="radio" name="aprovado"  />  Aprovado
      
    </label>
                        
    <label class="radio-inline">
      <input type="radio" name="optradio">

        <asp:RadioButton ID="rbt_noapro" runat="server" type="radio" name="optradio" />  No aprovado
    </label>
                       
              &nbsp;</div>
                  
                    <div class="form-group">
                       <label for="exampleinput">Usuariol</label>
                      <asp:TextBox ID="txt_usuario" runat="server" CssClass="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server"
  ControlToValidate="txt_usuario"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
              </div>
                    <div class="form-group">
                       <label for="exampleinput">VISITAS</label>
                      <asp:Label ID="txt_visitas" runat="server" Text="Label"></asp:Label>
                         
              </div>
               
                  
        </div>

               
    
</div>

       <br/>
        <br/>
        <br/>
        <br/>
     
            <div class="row">
		<div class="col-md-3">
              <asp:Button ID="btn_agregar" runat="server" Text="agregar" CssClass=" btn btn-primary  " OnClick="accion" style="text-align:right" /> 
             <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/GaleriaImagenesaspx.aspx" CssClass="btn btn-danger">LinkButton</asp:LinkButton>
      
		</div>
		<div class="col-md-3">
             
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger   " OnClick="accion" style="text-align:right" />
         
		</div>
		<div class="col-md-3">
              <asp:Button ID="btn_modificar" runat="server" Text="Modificar" CssClass="btn btn-success  " OnClick="accion" style="text-align:right"  />
 
      
		</div>
		<div class="col-md-3">
              
        <asp:Button ID="btn_nuevo" runat="server" Text="nuevo" CssClass="btn btn-warning   " OnClick="accion" style="text-align:right"/> 
		</div>
	</div>
       
           
              
         
         
        <br/>
        <br/>
            <div class="row">
  <div class="col-md-12">
      <asp:GridView ID="dgb_todos" runat="server" OnRowCommand="mandar">
          <Columns>
              <asp:ButtonField CommandName="btn_seleccionar" Text="seleccionar" />
          </Columns>
      </asp:GridView>
                </div>
                  </div>
        
           
        
 <script>
        $('#ModalMapPreview').locationpicker({
            radius: 0,
            location: {
                latitude: $('#<%=txtlat.ClientID%>').val(),
                longitude: $('#<%=txt_lo.ClientID%>').val()
            },
            inputBinding: {
                latitudeInput: $('#<%=txtlat.ClientID%>'),
                longitudeInput: $('#<%=txt_lo.ClientID%>'),
                locationNameInput: $('#<%=txt_ubicar.ClientID%>')
            },
            enableAutocomplete: true


        });



            



    </script>
       
</div>
        </div>

    






</asp:Content>

    

