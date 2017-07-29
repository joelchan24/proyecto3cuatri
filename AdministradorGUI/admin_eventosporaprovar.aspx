<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_eventosporaprovar.aspx.cs" Inherits="AdministradorGUI.admin_eventosporaprovar" %>
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
         <div class="panel-heading " style="text-align:center !important; ">Eventos Por Aprovar</div>
    <form id="form5" runat="server">
    <div class="row">
		<div class="col-md-12">
		
</div>
		</div>

      
        <div class="row">
		<div class="auto-style3">
			<asp:TextBox ID="txtBuscar" runat="server" Width="705px" Height="30px"></asp:TextBox>
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-dropbox" Width="100px" OnClick="btnBuscar_Click"  />

		</div>
	</div><br />

	<div class="row">
        
		<div class="col-md-12">
            <asp:GridView ID="dgb_porconfirmar" runat="server" CssClass="table-resposive table table-bordered" OnRowCommand="eventosporaprovar">
                <Columns>
                    <asp:ButtonField CommandName="btn_aprovar" Text="Aprobar">
                    <ControlStyle CssClass="btn btn-success" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
		</div>
	</div>
        </form>

    </div>

</asp:Content>
