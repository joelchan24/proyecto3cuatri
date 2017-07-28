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
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" style="height:223px !important; width:350px !important" src="img/<%# Eval("FOTOPROMOCION")%>.jpg" />
						<div class="caption">
							<h3>
                              <%# Eval("NOMBRE")%>	
							</h3>
                          
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
      
	</div>
</div>
</asp:Content>
