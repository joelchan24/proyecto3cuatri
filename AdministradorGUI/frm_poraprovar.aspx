<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="frm_poraprovar.aspx.cs" Inherits="AdministradorGUI.frm_poraprovar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="panel panel-primary" style="width:1160px !important;height:1000px;">
         <div class="panel-heading " style="text-align:center !important; ">Eventos Por Aprovar</div>
         <form id="form90" runat="server">
    <div class="row">
		<div class="col-md-12">
		
            <asp:HiddenField ID="txt" runat="server" />
		
</div>
		</div>

      
        <div class="row">
		<div class="auto-style3">
			<asp:TextBox ID="txtBuscar" runat="server" Width="705px" Height="30px"></asp:TextBox>
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-dropbox" Width="100px"   />

		</div>
	</div><br />
             	<div class="row">
                     <asp:gridview id="gri" runat="server" OnRowCommand="gri_RowCommand" CssClass="table-resposive table table-bordered" >
                         <Columns>
                             <asp:ButtonField CommandName="btn_aprovar" Text="Aprovar">
                             <ControlStyle CssClass="btn btn-primary" />
                             </asp:ButtonField>
                         </Columns>
                     </asp:gridview>


                     </div>
                </form>

    </div>
</asp:Content>
