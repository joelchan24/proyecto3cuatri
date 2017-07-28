<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_musica.aspx.cs" Inherits="GUI.frm_musica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3 class="text-center" style="color:#b69da8">
			EVENTOS DE TEATRO
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
            <div class="panel panel-primary">
                       <div class="panel-heading">
                            <div class="panel-title text-center"></div>

                        </div>
			<div class="row">
				
				 <asp:Repeater ID="rpt_musica" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4"><br />
                  <div class="panel panel-danger">
                       <div class="panel-heading">
                            <div class="panel-title text-center"> <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%></div>

                        </div>
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
				<div class="col-md-4">
					
				</div>
				<div class="col-md-4">
					
				</div>
			</div>
		</div>
	</div>
</div>
        </div>
</asp:Content>
