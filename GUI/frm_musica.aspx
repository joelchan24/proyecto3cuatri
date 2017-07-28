<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_musica.aspx.cs" Inherits="GUI.frm_musica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3>
				EVENTOS DE MUSICA
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<div class="row">
				
				 <asp:Repeater ID="rpt_musica" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg" />
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
				<div class="col-md-4">
					
				</div>
				<div class="col-md-4">
					
				</div>
			</div>
		</div>
	</div>
</div>
</asp:Content>
