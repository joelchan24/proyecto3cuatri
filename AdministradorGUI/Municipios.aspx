<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Municipios.aspx.cs" Inherits="AdministradorGUI.Municipios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="panel panel-primary" style="width:1160px !important">
         <div class="panel-heading " style="text-align:center !important">Registro de Municipios</div>
     <form id="form1" runat="server">
         <div class="row">
		<div class="col-md-4">
          <div class="form-group">
                       <label for="exampleinput">ID Municipio</label>
              <asp:TextBox ID="txt_IdMunicipio" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
		</div>
		<div class="col-md-4">
            <div class="form-group">
                       <label for="exampleinput">Nombre Municipio</label>
                <asp:TextBox ID="txt_NombreMunicipio" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
		</div>
		
		<div class="col-md-4">
            <div class="form-group">
                       <label for="exampleinput">Estado</label>
                   <asp:DropDownList ID="ddl_estado" runat="server" Width="450px" Height="30px"></asp:DropDownList>
                        </div>
		</div>
             </div>
		
	
      <div class="clearfix"></div>
           
      <br />
           <br />
           <br />
           <br />
        <div class="row">
		<div class="col-md-4">
            
             <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="btn-primary  " OnClick="Accion" />
		</div>
		<div class="col-md-4">
             <asp:Button ID="btn_Modificar" runat="server" Text="Modificar"  CssClass="btn-primary  " OnClick="Accion" />
		</div>
		<div class="col-md-4">
             <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar"  CssClass="btn-primary  " OnClick="Accion" />


		</div>
                <div class="col-md-4">
                    <asp:Button ID="btnreporte" runat="server" Text="Reporte"  CssClass="btn-primary  " OnClick="Accion" CausesValidation="False" />
            </div>
	</div>
   
           

           

           <div style="display:none">

            <asp:Button ID="btn_Buscar" runat="server" Text="Reporte"  CssClass="btn-primary  " OnClick="Accion" />
           
       </div>
           <br />
           <br />
           <br />
       
            <asp:GridView ID="dgv_Estados" runat="server" OnRowCommand="Seleccionar" CssClass="table-resposive table table-bordered" OnRowCreated="ocultar" >
                <Columns>
                    <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" >
                    <ControlStyle CssClass="btn btn-primary" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        
    </form>
         </div>
</asp:Content>
