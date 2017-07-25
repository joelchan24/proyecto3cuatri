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
			 
                 <asp:ListView id="list" runat="server" OnItemCommand="mandar" datakeynames="CODIGO" OnSelectedIndexChanged="cerrar">

                       <ItemTemplate>
                
          	<div class="col-md-4">
					<div class="thumbnail">
						<img alt="Bootstrap Thumbnail First" src="img/<%# Eval("FOTOPROMOCION")%>.jpg" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<% Data Source=DESKTOP-TT12AGM\\SQLEXPRESS; Initial catalog=CULTURA; integrated security=true%>">
                    
                </asp:SqlDataSource>
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
