<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_teatroo.aspx.cs" Inherits="GUI.frm_teatroo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3>
			EVENTOS DE TEATRO
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<div class="row">
				
				 <asp:Repeater ID="rpt_teatro" runat="server" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" src="~/img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>" />
						<div class="caption">
							<h3>
                              <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>	
							</h3>
							<p>
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
							<asp:Button ID="btn_vermas1" runat="server" Text="Ver Más" class="btn btn-primary" href="#" />
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
