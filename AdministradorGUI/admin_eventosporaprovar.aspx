<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_eventosporaprovar.aspx.cs" Inherits="AdministradorGUI.admin_eventosporaprovar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form5" runat="server">
    <div class="row">
		<div class="col-md-12">
			<div class="alert alert-warning align=text-center" role="alert">
  <a href="#" class="alert-link">USTED TIENE EVENTOD POR APROVAR</a>
</div>
		</div>
	</div>
	<div class="row">
        
		<div class="col-md-12">
            <asp:GridView ID="dgb_porconfirmar" runat="server" CssClass="table-resposive table table-bordered" OnRowCommand="eventosporaprovar">
                <Columns>
                    <asp:ButtonField CommandName="btn_aprovar" Text="Aprovar">
                    <ControlStyle CssClass="btn btn-success" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
		</div>
	</div>
        </form>



</asp:Content>
