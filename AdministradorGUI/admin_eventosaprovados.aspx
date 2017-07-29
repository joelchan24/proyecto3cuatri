<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_eventosaprovados.aspx.cs" Inherits="AdministradorGUI.admin_eventosaprovados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            position: relative;
            min-height: 1px;
            width: 80%;
            top: 6px;
            left: 75px;
            height: 81px;
            padding-left: 15px;
            padding-right: 15px;
        }
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="panel panel-primary" style="width:1160px !important;height:1000px;">
         <div class="panel-heading " style="text-align:center !important; ">Eventos Aprovados</div>
    <form id="form5" runat="server">
   <!-- <div class="row">
		<div class="col-md-12">
            <div class="alert alert-success" role="alert">
  <a href="#" class="alert-link">EVENTOS APROVADOS</a>
</div>
		</div>
	</div>-->

        <div class="row">
		<div class="auto-style3">
			<asp:TextBox ID="txtBuscar" runat="server" Width="505px" Height="30px" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-dropbox" Width="100px" OnClick="btnBuscar_Click2" />

		</div>
	</div><br />

	<div class="row">
		<div class="col-md-12">
            <asp:gridview runat="server" ID="dgv_desaprovados" CssClass="table-resposive table table-bordered" OnRowCommand="desaprovar">
                <Columns>
                    <asp:ButtonField CommandName="btn_desaprovar" Text="Desaprovar ">
                    <ControlStyle CssClass="btn btn-danger" />
                    </asp:ButtonField>
                </Columns>
            </asp:gridview>
		</div>
        
	</div>
        </form>
         </div>
    
</asp:Content>
