<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_eventos.aspx.cs" Inherits="GUI.frm_eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script src="https://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>

    <script src="js/locationpicker.jquery.js"></script>
  <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3 class="text-center text-primary">
				NOMBRE DEL EVENTO
			</h3>
			<h3 class="text-info">
				h3. Lorem ipsum dolor sit amet.
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-6">
			<img alt="Bootstrap Image Preview" src="http://lorempixel.com/140/140/" class="img-rounded" /><!-- aqui iria la foro promocialan-->
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
                    <p>danza</p>
                     
                  </div>
			
                  <div class="form-group">
                      <label for="exampleinput">Fecha De  Inicio</label>
                    <p>danza</p>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Fecha De Cierre</label>
                    <p>danza</p>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Cantegoria</label>
                      <p>danza</p>
                    </div>
                

              
            
            
			
		</div>
	</div>
	<div class="row">
		<div class="col-md-6">
			<h3>
				DIRRECION
			</h3>
			<h2>
				Heading
			</h2>
			 <div class="form-group">
                      <label for="exampleinput">Colonia</label>
                    <p>danza</p>
                     
                  </div>
			
                  <div class="form-group">
                      <label for="exampleinput">Municipio</label>
                    <p>danza</p>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">C.P</label>
                    <p>danza</p>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Cruzamientos</label>
                      <p>danza</p>
                    </div>
                

              
			
		</div>
        <!-- mapa gay-->
		<div class="col-md-6">
			    <div class="form-group">
                    <label for="exampleinput" >Ubicación</label>
                    
                    <asp:TextBox ID="txt_ubicar" runat="server" CssClass="form-control"></asp:TextBox>
                    


                </div>
                <div class="form-group">
                    <div id="ModalMapPreview" style="width:100%; height:300px;"></div>
                </div>
                <!--altitud y lon-->
               
                <div class="form-group" style="display:none;">
                    <label for="exampleinput">lat:</label>
                    <asp:TextBox ID="txtlat" runat="server" Text="20.938297181414647" CssClass="form-control"></asp:TextBox>
                     <label for="exampleinput">log:</label>
                    <asp:TextBox ID="txt_lo" runat="server" Text="-89.61501516379462" CssClass="form-control"></asp:TextBox>
                </div>
                <!--altasb  , bjaas y ca,mbios botonos-->
                <div>
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
        <div class="row">
		<div class="col-md-6">
            <p class="text-right"><strong>Para Más Infromación Del Evento </strong></p>
		</div>
		<div class="col-md-6">
           
            <asp:Button ID="btn_mas" runat="server" Text="Más información" class="btn btn-outline-info" OnClick="mandar" />
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
				<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" src="http://lorempixel.com/output/people-q-c-600-200-1.jpg" />
						<div class="caption">
							<h3>
								Thumbnail label
							</h3>
							<p>
								Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
							</p>
							<p>
								<a class="btn btn-primary" href="#">Action</a> <a class="btn" href="#">Action</a>
							</p>
						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail Second" src="http://lorempixel.com/output/city-q-c-600-200-1.jpg" />
						<div class="caption">
							<h3>
								Thumbnail label
							</h3>
							<p>
								Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
							</p>
							<p>
								<a class="btn btn-primary" href="#">Action</a> <a class="btn" href="#">Action</a>
							</p>
						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail Third" src="http://lorempixel.com/output/sports-q-c-600-200-1.jpg" />
						<div class="caption">
							<h3>
								Thumbnail label
							</h3>
							<p>
								Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
							</p>
							<p>
								<a class="btn btn-primary" href="#">Action</a> <a class="btn" href="#">Action</a>
							</p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
      <div>
    <textarea id="TextArea1" cols="200" rows="2"></textarea>
    <input type="button" id="Button1" runat="server" value="Button" onclick="AgregarComentario()"/>
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

