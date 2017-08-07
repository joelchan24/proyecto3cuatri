<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Estado.aspx.cs" Inherits="AdministradorGUI.Estado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            height: 483px;
            width: 667px;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            width: 55%;
            top: 17px;
            left: 126px;
            height: 213px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            width: 77%;
            top: 6px;
            left: 75px;
            height: 81px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style4 {
            margin-left: 14px;
        }
        .auto-style5 {
            width: 586px;
            margin-left: 62px;
            margin-right: -15px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="panel panel-primary" style="width:1160px !important;height:1000px;">
         <div class="panel-heading " style="text-align:center !important; ">Registro De Estados</div>
  
    <form id="form1" runat="server" class="auto-style1">
       <div class="row">

			<div role="form" class="form-group" >
                		<div class="row" >
                 <div class="col-md-6">
                    <div class="form-group">
                       <asp:Label ID="Label3" runat="server" Text="País" CssClass="text-primary"></asp:Label><br />
                      <asp:DropDownList ID="ddl_pais" runat="server" Width="300px" Height="30px"></asp:DropDownList>
                        </div>
                        </div>
				 <div class="col-md-6">
				<div class="form-group">
					 <asp:Label ID="Label2" runat="server" Text="Nombre del Estado" CssClass="text-primary"></asp:Label><br />
                    <asp:TextBox ID="txtNombre" runat="server" Width="305px" Height="30px"></asp:TextBox>
                   </div>
                   
				</div>
                            </div>
                <div class="form-group" style="display:none">
					<asp:Label ID="Label1" runat="server" Text="ID" CssClass="text-primary"  ></asp:Label><br />
                    <asp:TextBox ID="txtID" runat="server" Width="505px" Height="30px" Enabled="False"></asp:TextBox>
				</div><br />
			</div>
		
	<div class="row">
		<div class="col-lg-12">
			<asp:Button ID="btnAgregar" Text="Agregar" runat="server" CssClass="btn btn-dropbox"  OnClick="Accion" /> 
            <asp:Button ID="btnModificar" Text="Modificar" runat="server" CssClass="btn btn-dropbox"  OnClick="Accion"  />
            <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" CssClass="btn btn-dropbox"  OnClick="Accion" />
            <asp:Button ID="btnNuevo" Text="Reporte" runat="server" CssClass="btn btn-dropbox"  OnClick="Accion" CausesValidation="False" />
       <div style="display:none"><asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-dropbox" Width="100px" OnClick="btn_Buscar_Click" /></div>

		</div>
	</div><br />
           <div class="row">
           <div class="auto-style5">
               <div class="form-group">
                   <asp:GridView ID="dgv_Estados" runat="server" CssClass="table-resposive table table-bordered" Width="590px" OnRowCommand="Seleccionar" OnRowCreated="dgv_Estados_RowCreated">
                       <Columns>
                           <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" >

                           <ControlStyle CssClass="btn btn-primary" />
                           </asp:ButtonField>

                       </Columns>
                   </asp:GridView>
               </div>
           </div>
               </div>
    </div>
    </form>
          </div>
</asp:Content>
