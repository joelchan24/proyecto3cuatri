<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_topvisitados.aspx.cs" Inherits="GUI.frm_topvisitados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3>
				TOP EVENTOS VISITADOS
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<div class="row">
                <asp:ListView ID="ListView1" runat="server">
			 
                

                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" width="400" height="400" src="img/<%# Eval("FOTOPROMOCION")%>.jpg" />
						<div class="caption">
							<h3>
                              <%# Eval("NOMBRE")%>	
							</h3>
                             <asp:Label ID="id" runat="server" Text=""><%# Eval("CODIGO")%></asp:Label>
                            <p>
								<%# Eval("DESCRIPCION")%>	
							<p>
                               
                               <a href="frm_eventos.aspx?id=<%#Eval("CODIGO")%>">ir</a>
							</p>
						</div>
					</div>
				</div>
                                           </ItemTemplate>
   </asp:ListView>
                    
					
				
			</div>
		</div>
      
	</div>
</div>
</asp:Content>
