<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GUI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    
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
        <div class="container-fluid">
            <div class="row">
            	<div class="col-xs-12 col-sm-12 col-md-offset-1 col-md-7">
        			<div class="panel panel-default">
                        <div class="bs-callout bs-callout-danger">
        					<h4>eventos mas recientes</h4>
        					<p>
        					   aqui los eventos
                            </p>
                         
                                
            
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="bs-callout bs-callout-danger">
                            <h4>otros eventos</h4>
                            
                            <p>
                           
                              </p><pre class="prettyprint linenums:1">        <a id="menu-toggle" href="#" class="btn btn-dark btn-lg toggle"><i class="fa fa-bars"></i></a>
        <a id="to-top" class="btn btn-lg btn-dark" href="#top">
            <span class="sr-only">Toggle to Top Navigation</span>
            <i class="fa fa-chevron-up"></i>
        </a></pre>
           
       
            
                            <p></p>
                          
                        </div>
                    </div>
                </div>
                <div class="col-md-4 hidden-xs hidden-sm">
    				
					<div class="panel panel-default">
						
					</div>
					<div class=" col-lg-4">
						<div class="container ">
							<div class="row hidden-xs hidden-sm" >
                            
	
                                -->
 <div style="overflow:hidden;">
    <div class="form-group">
        <div class="row">
            <div class="col-md-2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
      <DayHeaderStyle Font-Bold="True" Font-Size="8pt" CssClass="col-lg-4" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
        <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            $('#Calendar1').fullCalendar({
                inline: true,
                sideBySide: true
            });
        });
    </script>
</div>-->
          
							
							</div>
							   <div class="container  ">
							<p>kjhjkjkh</p>	
							</div>
						</div>
					</div>
                 
				</div>

            </div>

            </div>
    
</asp:Content>
