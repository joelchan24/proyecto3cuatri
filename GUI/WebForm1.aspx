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
                         <img class="slide-1" src="img/Orquesta-Sinfonica-Colegio-Bilbao16.jpg" alt="slide-1"  />
                            <div class="hero">
                                <hgroup>
                                    <h1>EVENTOS DE MÚSICA</h1>        
                                    <h3>AQUÍ LOS EVENTOS DE MÚSICA</h3>
                                </hgroup>
                         <button class="btn btn-hero btn-lg" role="button"> <a href="frm_musica.aspx">IR A LOS EVENTOS</a>  </button>  
                        </div>

                       
                    </div>
                    <div class="item slides">
                       <!--    <div class="slide-2"></div>-->
                      <img class="slide-2" src="img/escuela-teatro-2013-06-29-181304.jpg" alt="slide-2"/>
                            <div class="hero">        
                                <hgroup>
                                    <h1>EVENTOS DE TEATRO</h1>        
                                    <h3>AQUÍ LOS EVENTOS DE TEATRO</h3>
                                </hgroup>       
                      <button class="btn btn-hero btn-lg" role="button"> <a href="frm_teatroo.aspx">IR A LOS EVENTOS</a>  </button>  
                            </div>

                        </div>
                        <div class="item slides">
                          <!-- <div class="slide-3"></div>-->
                            <img class="slide-3" src="img/ja (2).jpg" />
                                <div class="hero">        
                                    <hgroup>
                              <h1>EVENTOS DE DANZA</h1>        
                                    <h3>AQUÍ LOS EVENTOS DE DANZA</h3>
                                    </hgroup>
                       <button class="btn btn-hero btn-lg" role="button"> <a href="frm_danza.aspx">IR A LOS EVENTOS</a>  </button>  
                                </div>

                            </div>
                        </div> 
                    </div>
		        </div>
            </div>
        </div>

    <!---->

			
    <div class="container"><br />
	
	<div class="row">
		<div class="col-md-12">
             <h3 class="text-center" style="color:#b69da8">
			MÁS RECIENTES
			</h3>
        <div class="panel panel-primary">
                       <div class="panel-heading">
                            <div class="panel-title text-center"></div>

                        </div>
			<div class="row">
				 <asp:Repeater ID="rpt_uno" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4"><br />
                  <div class="panel panel-danger">
                       <div class="panel-heading">
                            <div class="panel-title text-center"> <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>	</div>

                        </div>
					<div class="thumbnail">
           
                        
						<img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg"/>
						<div class="caption">
							
							<p>
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
						 <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>" class="btn-group-lg btn-sm btn-success"><span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>Ver Más </a>
							</p>
						</div>
					</div>
				</div>
                  </div>
                                           </ItemTemplate>
      </asp:Repeater>
                
                
				<!--<div class="col-md-4">
					
				</div>
				<div class="col-md-4">
					
				</div>
			</div>-->
            <br />
            
            <div class="clearfix"></div>
                	</div><br />
            <div class="row">
            <div class="col-md-12 text-center">
                <asp:HiddenField ID="txt" runat="server" />

                 <asp:Button ID="btn_vermas" runat="server"  Text="Ver Más Eventos" CssClass="btn-group-lg btn-sm btn-info "  OnClick="mandar" />
            </div>
                    </div><br />
            </div>
			<h3 class="text-center" style="color:#b69da8">
			MÁS VISITADOS
			</h3>
             <div class="panel panel-primary">
                       <div class="panel-heading">
                            <div class="panel-title text-center"></div>

                        </div>
                     <div class="row">
              
				
              
				 <asp:Repeater ID="Repeater1" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4"><br />
                  <div class="panel panel-danger">
                       <div class="panel-heading"> <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%></div>
					<div class="thumbnail">
                      <img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg" />
						<div class="caption">
                              	
                           <p>
                                
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
				        <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>"class="btn-group-lg btn-sm btn-success"><span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>Ver Más </a>
							</p>
						</div>
					</div>
				</div>
                  </div>
                                           </ItemTemplate>
      </asp:Repeater>

            </div><br />
                      <div class="row">
            <div class="col-md-12 text-center">
               
                  <asp:Button ID="btn_masvisi" runat="server" Text="Ver Más Eventos Visitados" CssClass="btn-group-lg btn-sm btn-info" OnClick="mandarar"  />
                </div>
               </div><br />
                     </div>
            </div>
</div>
</asp:Content>
