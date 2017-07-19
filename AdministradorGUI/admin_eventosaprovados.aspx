<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_eventosaprovados.aspx.cs" Inherits="AdministradorGUI.admin_eventosaprovados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form5" runat="server">
    <div class="row">
		<div class="col-md-12">
            <div class="alert alert-success" role="alert">
  <a href="#" class="alert-link">EVENTOS APROVADOS</a>
</div>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
            <asp:gridview runat="server" ID="dgv_desaprovados" CssClass="table-responsive" OnRowCommand="desaprovar">
                <Columns>
                    <asp:ButtonField CommandName="btn_desaprovar" Text="Desaprovar ">
                    <ControlStyle CssClass="btn btn-danger" />
                    </asp:ButtonField>
                </Columns>
            </asp:gridview>
		</div>
        
	</div>
        </form>
</asp:Content>
