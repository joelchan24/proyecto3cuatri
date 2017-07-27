<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admi_de eventosGUI.aspx.cs" Inherits="AdministradorGUI.admi_de_eventosGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 2500px;
            width:100%
       
}
        

    
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="https://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    <script src="js/locationpicker.jquery.js"></script>
    <form  id="form1" runat="server" >
      
          <div class="row">
              <h1 > control</h1>
               <asp:HiddenField  ID="txtid" runat="server" />
              <asp:HiddenField ID="txt_codir" runat="server" OnValueChanged="txt_codir_ValueChanged" />
              <asp:HiddenField ID="txt_usuariop" runat="server" OnValueChanged="HiddenField1_ValueChanged" />
              <div class="col-xs-4" >
                  <div class="form-group">
                      <label for="exampleinput">nombre</label>
                      <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Fecha Apertura</label>
                      <asp:TextBox ID="txt_aperura" runat="server" CssClass="form-control" type="date" OnTextChanged="txt_aperura_TextChanged"></asp:TextBox>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput" >Fecha De Cierre</label>
                        <asp:TextBox ID="txt_fecha_cierre" runat="server" CssClass="form-control " type="date" OnTextChanged="txt_fecha_cierre_TextChanged"></asp:TextBox>
                    </div>
                   
               </div>
             
          </div>
        

              <div class="row" >
              
              <div class="col-xs-4" >
                  <br />
                  <div class="form-group input-group">
                      <label for="exampleinput" >Precio</label>
                     
                       <span class="input-group-addon "><i   >$</i></span>
                      <asp:TextBox ID="txt_precio" runat="server" CssClass="form-control"></asp:TextBox>
                       
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Categoria</label>
                      <asp:DropDownList ID="ddl_categoria" runat="server" Width="100%"></asp:DropDownList>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput">Municipio</label>
                       <asp:DropDownList ID="ddl_municipio" runat="server" Width="100%"></asp:DropDownList>  

                    </div>
                   
               </div>
      

          </div>
         <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="exampleinput" >Ubicacion</label>
                   
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
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Colonia</label>
                      <asp:TextBox ID="txt_colonia" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Número Interior</label>
                        <asp:TextBox ID="txt_numint" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                 <div class="form-group">
                      <label for="exampleinput">Número Exterior</label>
                      <asp:TextBox ID="txt_numexter" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Cruzamientos</label>
                      <asp:TextBox ID="txt_crizamiento" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
                <br />
                <div class="form-group">
                      <label for="exampleinput">c.postal</label>
                     
                        <asp:Image ID="Image1" runat="server" witdh="100px"  Height="100"/>
                    <asp:FileUpload ID="file_foto" runat="server"  witdh="100px" />

                     
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
                     <asp:TextBox id="txt_descrip" TextMode="multiline" Columns="50" Rows="5" runat="server" CssClass="form-control " width="349px" height=350px                  />
                     
                  </div>

              
            
                   
                   
                   

              
            
                    <div class="form-group">
                       <label for="exampleinput" >aprovacion</label><br />
                      <label class="radio-inline" >
                          <asp:RadioButton ID="rbt_aprovado" runat="server" type="radio" name="aprovado" OnCheckedChanged="rbt_aprovado_CheckedChanged"  />  Aprovado
      
    </label>
                        
    <label class="radio-inline">
      <input type="radio" name="optradio">

        <asp:RadioButton ID="rbt_noapro" runat="server" type="radio" name="optradio" OnCheckedChanged="rbt_noapro_CheckedChanged" />  No aprovado
    </label>
                       
              &nbsp;</div>
                  
                    <div class="form-group">
                       <label for="exampleinput">Usuariol</label>
                      <asp:TextBox ID="txt_usuario" runat="server" CssClass="form-control"></asp:TextBox>
                         
              </div>
                   <div class="form-group">
                       <label for="exampleinput">VISITAS</label>
                      <asp:TextBox ID="txt_visitas" runat="server" CssClass="form-control"></asp:TextBox>
                         
              </div>
               
                  
        </div>

               
    
</div>

       <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
           <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        
        <div class="row"  >
           
               
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger  col-sm-1 " OnClick="accion" />
         
        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" CssClass="btn btn-success col-sm-1" OnClick="accion"   />
 
         <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass=" btn btn-primary  col-sm-1 " OnClick="accion" />
        
        <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar" CssClass="btn btn-warning  col-sm-1 " />
        <asp:Button ID="btn_nuevo" runat="server" Text="nuevo" CssClass="btn btn-warning  col-sm-1 " OnClick="accion"  />
          </div>
            <div class="row">
  <div class="col-md-12">
      <asp:GridView ID="dgb_eventos" runat="server" CssClass=" table-resposive table table-bordered" OnSelectedIndexChanged="dgb_eventos_SelectedIndexChanged" OnRowCommand="mandaraltexvo" OnRowCreated="dgb_eventos_RowCreated">
          <Columns>
              <asp:ButtonField CommandName="btn_seleccionar" Text="Seleccionar">
              <ControlStyle CssClass="btn btn-primary" />
              </asp:ButtonField>
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
         
</form>
       
</asp:Content>
