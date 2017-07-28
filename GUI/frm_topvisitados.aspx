<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_topvisitados.aspx.cs" Inherits="GUI.frm_topvisitados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
	<div class="row">
         <div class="panel panel-primary">
                       <div class="panel-heading">
                            <div class="panel-title text-center">TOP EVENTOS VISITADOS</div>

                        </div>
		<div class="col-md-12">
			<div class="row">
                <asp:ListView ID="ListView1" runat="server">
			 
                

                       <ItemTemplate>
          	<div class="col-md-4">
                  <br />
                   <div class="panel panel-danger">
                       <div class="panel-heading">
                            <div class="panel-title text-center">
                              <%# Eval("NOMBRE")%>	
							</div>

                        </div>
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# Eval("FOTOPROMOCION")%>.jpg" />
						<div class="caption">
                             <asp:Label ID="id" runat="server" Text=""><%# Eval("CODIGO")%></asp:Label>
                            <p>
								<%# Eval("DESCRIPCION")%>	
							<p>
                               
                               <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>"class="btn-group-lg btn-sm btn-success"><span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>Ver Más </a>
							</p>
						</div>
                        </div>
                       </div>
					</div>

                                           </ItemTemplate>
   </asp:ListView>
                    
					
				
			</div>
		</div>
      
	</div>
</div>
         </div>
</asp:Content>
