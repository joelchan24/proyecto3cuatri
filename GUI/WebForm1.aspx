<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GUI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <link href="css/calendar.css" rel="stylesheet" />
    <script src="js/calendar.js"></script>
    <script src="js/calendar2.js"></script>
    <script src="js/Jquery%202.1.0.js"></script>
        <div class="masthead">
            <div class="carousel fade-carousel slide" data-ride="carousel" data-interval="4000" id="bs-carousel">


                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#bs-carousel" data-slide-to="0" class="active"></li>
                    <li data-target="#bs-carousel" data-slide-to="1"></li>
                    <li data-target="#bs-carousel" data-slide-to="2"></li>
                </ol>
      
                <!-- Wrapper for slides -->
                <div>
                    <div>
                <div class="carousel-inner">
                    <div class="item slides active">
                       <!-- <div class="slide-1"></div>-->
                         <img class="slide-1" src="img/progreso-malecon.jpg" alt="slide-1"  />
                            <div class="hero">
                                <hgroup>
                                    <h1>We are creative</h1>        
                                    <h3>Get start your next awesome project</h3>
                                </hgroup>
                            <button class="btn btn-hero btn-lg" role="button">See all features</button>
                        </div>
                    </div>
                    <div class="item slides">
                       <!--    <div class="slide-2"></div>-->
                      <img class="slide-2" src="img/vaqueria-yucateca-2.jpg" alt="slide-2"/>
                            <div class="hero">        
                                <hgroup>
                                    <h1>We are smart</h1>        
                                    <h3>Get start your next awesome project</h3>
                                </hgroup>       
                                <button class="btn btn-hero btn-lg" role="button">See all features</button>
                            </div>
                        </div>
                        <div class="item slides">
                          <!-- <div class="slide-3"></div>-->
                            <img class="slide-3" src="img/obra-cholo.jpg" />
                                <div class="hero">        
                                    <hgroup>
                                        <h1>We are amazing</h1>        
                                        <h3>Get start your next awesome project</h3>
                                    </hgroup>
                                    <button class="btn btn-hero btn-lg" role="button">See all features</button>
                                </div>
                            </div>
                        </div> 
                    </div>
		        </div>
            </div>
        </div>

    <!---->

			
    <div class="container">
	
	<div class="row">
		<div class="col-md-12">
			<h3 class="text-center" style="color:#b69da8">
				MÁS RECIENTES
			</h3>
			<div class="row">
				 <asp:Repeater ID="rpt_uno" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
           
                        
						<img alt="Bootstrap Thumbnail First" width="400" height="400" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg"/>
						<div class="caption">
							<h3>
                              <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>	
							</h3>
							<p>
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
						 <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>">Ver Más </a>
							</p>
						</div>
					</div>
				</div>
                                           </ItemTemplate>
      </asp:Repeater>
                
                
               
				</div>
				<!--<div class="col-md-4">
					
				</div>
				<div class="col-md-4">
					
				</div>
			</div>-->
            <br />
            
            <div class="clearfix"></div>
            <div class="col-md-12 text-center">
                <asp:HiddenField ID="txt" runat="server" />

                 <asp:Button ID="btn_vermas" runat="server" Text="Ver Más Eventos" CssClass="btn btn-info" OnClick="mandar" />
            </div>
			<h3 class="text-center" style="color:#b69da8">
			MÁS VISITADOS
			</h3>
			<div class="row">

              
				
              
				 <asp:Repeater ID="Repeater1" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
                      <img alt="Bootstrap Thumbnail First" width="400" height="400" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg" />
						<div class="caption">
							<h3>
                              <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>
                              
							</h3>
                              	
                           <p>
                                
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
				        <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>">Ver Más </a>
							</p>
						</div>
					</div>
				</div>
                                           </ItemTemplate>
      </asp:Repeater>

                



			<!--	<div class="col-md-4">
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
				</div>-->
			</div>
		</div>
	</div>
</div>
</asp:Content>
