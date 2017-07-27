<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_eventos.aspx.cs" Inherits="GUI.frm_eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script src="https://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    <script src="js/locationpicker.jquery.js"></script>
  <div class="container">
        <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">GALERIA</div>

                        </div> 
	<div class="row">
        <asp:Repeater ID="rpt" runat="server">
            <ItemTemplate>
                <div class="col-md-12">
                   
			<h3 class="text-center text-primary" >
				<%# DataBinder.Eval(Container.DataItem,"NOMBRE") %>
			</h3>
			<h3 class="text-info">
				FOTO PRINCIPAL
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-6">
			<img alt="Bootstrap Image Preview" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg" class="img-rounded" style="width:500px;height:370px" /><!-- aqui iria la foro promocialan-->
		</div>
		<div class="col-md-6">
			 <h3>
				DATOS DEL EVENTO
			</h3>
			<h2>
				YUCATÁN
			</h2>
            <div class="form-group">
                      <label for="exampleinput">Descripción</label>
                    <p><%# DataBinder.Eval(Container.DataItem,"DESCRIPCION") %></p>
                     
                  </div>
			
                  <div class="form-group">
                      <label for="exampleinput">Fecha De  Inicio</label>
                    <p ><%# DataBinder.Eval(Container.DataItem,"FECHAAPERTURA") %></p>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Fecha De Cierre</label>
                    <p ><%# DataBinder.Eval(Container.DataItem,"FECHACIERRE") %></p>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Cantegoria</label>
                      <p><%# DataBinder.Eval(Container.DataItem,"nombrecat") %></p>
                    </div>
                

              
            
            
			
		</div>
	</div>
	<div class="row">
		<div class="col-md-6">
			<h3>
				DIRRECION
			</h3>
		
			 <div class="form-group">
                      <label for="exampleinput">Colonia</label>
                    <p><%# DataBinder.Eval(Container.DataItem,"NOMBRE") %></p>
                     
                  </div>
			
                  <div class="form-group">
                      <label for="exampleinput">Municipio</label>
                    <p><%# DataBinder.Eval(Container.DataItem,"muni") %></p>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">C.P</label>
                    <p><%# DataBinder.Eval(Container.DataItem,"CODIGOPOSTAL") %></p>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Cruzamientos</label>
                      <p><%# DataBinder.Eval(Container.DataItem,"CRUZAMIENTO") %></p>
                    </div>
                

              
			
		</div>
        <!-- mapa gay-->
		<div class="col-md-6">
			    <div class="form-group">
                    <label for="exampleinput" >Ubicación</label>
                    
             
                    


                </div>
                <div class="form-group">
                    <div id="ModalMapPreview" style="width:100%; height:300px;"></div>
                </div>
                <!--altitud y lon-->
               
                <div class="form-group" style="display:none;">
                    
                    <input type="text" id="a" value="<%# DataBinder.Eval(Container.DataItem,"UBICACIONGEOGRAFICA") %>" />
                <input   type="text" id="b" value="<%# DataBinder.Eval(Container.DataItem,"LONGITUD") %>" />
                   <input  type="text" id="c" value="<%# DataBinder.Eval(Container.DataItem,"LATITUD") %>"/>
                  
           
                </div>
                <!--altasb  , bjaas y ca,mbios botonos-->
                <div>
                         </div>
             <script>
       $('#ModalMapPreview').locationpicker({
            radius: 0,
            location: {
                latitude: $('#c').val(),
                longitude: $('#b').val()
            },
            inputBinding: {
                latitudeInput: $('#c'),
                longitudeInput: $('#b'),
                locationNameInput: $('#a')
            },
            enableAutocomplete: true


        });
                            



    </script>
		</div>
        <div class="row">
		<div class="col-md-6">
            <p class="text-right"><strong>Para Más Infromación Del Evento </strong></p>
		</div>
		<div class="col-md-6">
  
            <asp:Button ID="btn_mas" runat="server" Text="Más información" class="btn btn-outline-info" OnClick="mandar"  />
		</div>
	</div>
	</div>

	<div class="row">
		<div class="col-md-12">
			<h3>
				GALERIA EVENTO
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<div class="row">
			</div>
		</div>
        </ItemTemplate>
		
       </asp:Repeater>
	</div>
            </div>
      <div class="row">
         <div class="col-md-12">
         <asp:Repeater ID="rpiter" runat="server">
        <ItemTemplate>
              <div class="col-md-4">
                  <div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTO")%>.jpg"/>
					</div>
              </div>
          </div>

                  </ItemTemplate>
              </asp:Repeater>
          </div>
          </div>
      <div class="row">
          <div class="col-lg-1">

          </div>
          <div class="col-lg-10">
    <textarea id="TextArea1" cols="200" rows="2"></textarea>
    <input type="button" id="Button1" runat="server" value="Enviar Comentario " text="Enviar" onclick="AgregarComentario()"/>
      </div>
          </div>
      <div id="Mensajes">
          
      </div>
      </div>
    
    <script>

        function AgregarComentario() {
            var texto = $("#TextArea1").val();

            //alert(texto);

            $.ajax({
                type: "POST",
                url: "frm_eventos.aspx/AgregarMensaje",
                data: '{Texto:"'+ texto+'"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var r = JSON.parse(JSON.stringify(response));
                    //var r = JSON.parse(JSON.stringify(d));

                    var Usuario = "<label>" + r.d.Usuario + "</label>"
                    var Comentario = "<p>" + r.d.Mensaje + "</p><hr />"
                  
                    $("#Mensajes").append(Usuario);
                    $("#Mensajes").append(Comentario);
                },
                failure: function (response) {
                    alert("Error");
                }
            });
        }
        function OnSuccess(response) {
            var Comentario="<label>"+response+"</label>"
            $("#Mensajes").html(Comentario);
        }
</script>
    
</asp:Content>
