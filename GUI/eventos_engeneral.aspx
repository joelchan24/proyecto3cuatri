<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="eventos_engeneral.aspx.cs" Inherits="GUI.eventos_engeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
	<div class="row">
		<div class="col-md-12">
			<h3>
				h3. Lorem ipsum dolor sit amet.
			</h3>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<div class="row">
			 <asp:Repeater ID="rpt_todos" runat="server" OnItemDataBound="rpt_todos_ItemDataBound" >
            
                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" src="~/img/<%# DataBinder.Eval(Container.DataItem,"FOTOPROMOCION")%>.jpg" />
						<div class="caption">
							<h3>
                              <%# DataBinder.Eval(Container.DataItem,"NOMBRE")%>	
							</h3>
                             <asp:Label ID="id" runat="server" Text=""><%# DataBinder.Eval(Container.DataItem,"CODIGO")%></asp:Label>
                            <p>
								<%# DataBinder.Eval(Container.DataItem,"DESCRIPCION")%>	
							<p>
							<asp:Button ID="btn_vermas1" runat="server" Text="Ver Más" class="btn btn-primary" href="#" OnClick="cerrar" />
                               
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
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
	</div>
</div>
</asp:Content>
