<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="eventos_engeneral.aspx.cs" Inherits="GUI.eventos_engeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
	<div class="row">
        <div class="panel panel-primary">
                       <div class="panel-heading">
                            <div class="panel-title text-center"></div>

                        </div>
		<div class="col-md-12">
			<h3>
				 EVENTOS AGREGADOS
			</h3>
		</div>
            <div class="row">
                <div class="col-md-12">
                <div class="input-group text-center">


<asp:TextBox ID="txt_buscar" runat="server" CssClass="form-control" Width="250px"  type="date"></asp:TextBox>&nbsp;
<asp:LinkButton ID="btn" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="buscar"><span class="glyphicon glyphicon-search"></span>&nbsp;Buscar</asp:LinkButton>
</div>
                    </div>
            </div>
            <br />
	<div class="row">
		<div class="col-md-12">
			<div class="row">
			 
                 <asp:ListView id="list" runat="server" OnItemCommand="mandar" datakeynames="CODIGO" OnSelectedIndexChanged="cerrar">

                       <ItemTemplate>
                
          	<div class="col-md-4"><br />
                  <div class="panel panel-danger">
                        <div class="panel-heading">
                            <div class="panel-title">  <%# Eval("NOMBRE")%>	</div>

                        </div> 
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# Eval("FOTOPROMOCION")%>.jpg" />
						<div class="caption">
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
</div>
</asp:Content>
