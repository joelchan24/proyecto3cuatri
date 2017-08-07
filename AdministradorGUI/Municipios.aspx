<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Municipios.aspx.cs" Inherits="AdministradorGUI.Municipios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
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
    </style>
     <div class="panel panel-primary" style="width:1160px !important">
         <div class="panel-heading " style="text-align:center !important">Registro de Municipios</div>
     <form id="form1" runat="server">
         <div class="row">
             <div class="col-md-4">
            <div class="form-group">
                       <label for="exampleinput" Class="text-primary">Nombre Municipio</label>
                <asp:TextBox ID="txt_NombreMunicipio" runat="server" CssClass="form-control" ></asp:TextBox>
                        </div>
		</div>
             <div class="col-md-4">
            <div class="form-group">
                       <label for="exampleinput" Class="text-primary">Estado</label><br />
              
                <asp:DropDownList ID="DropDownList1" Width="300px" Height="30px" runat="server"></asp:DropDownList>
                        </div>
		</div>
		<div class="col-md-4">
          <div class="form-group" style="display:none">
                       <label for="exampleinput" class="text-primary">ID Municipio</label>
              <asp:TextBox ID="txt_IdMunicipio" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
		</div>
		
		
		
             </div>
		
	
      <div class="clearfix"></div>
           
      <br />
           <br />
           <br />
           <br />
        <div class="row">
		<div class="col-lg-12">
            
             <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="btn btn-dropbox   " OnClick="Accion" />
		
		
             <asp:Button ID="btn_Modificar" runat="server" Text="Modificar"  CssClass=" btn btn-dropbox  " OnClick="Accion" />
		
		
             <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar"  CssClass="btn btn-dropbox   " OnClick="Accion" />


	
               
                    <asp:Button ID="btnreporte" runat="server" Text="Reporte"  CssClass="btn btn-dropbox   " OnClick="Accion" CausesValidation="False" />
          
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
