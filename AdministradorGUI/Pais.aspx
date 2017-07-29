<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Pais.aspx.cs" Inherits="AdministradorGUI.Pais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="panel panel-primary" style="width:1160px !important">
         <div class="panel-heading " style="text-align:center !important">Registro de Paises</div>
    <form id="form1" runat="server">
         <div class="row">
		<div class="col-md-4">
          <div class="form-group">
                       <label for="exampleinput">ID País</label>
                <asp:TextBox ID="txt_IdPais" runat="server" CssClass="form-control"></asp:TextBox>
              
                        </div>
		</div>
		<div class="col-md-4">
            <div class="form-group">
                       <label for="exampleinput">Nombre País</label>
                <asp:TextBox ID="txt_NombrePais" runat="server" CssClass="form-control"></asp:TextBox>
                
                        </div>
		</div>
		
		<div class="col-md-4">
            
                     
		</div>
             </div>
		
	
      <div class="clearfix"></div>
        <br />
        <br />
     
       <div class="col-lg-4">
            
       
          
       
    
            <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="btn-primary " OnClick="Accion" />

            <asp:Button ID="btn_Modificar" runat="server" Text="Modificar"  CssClass="btn-primary " OnClick="Accion" />

            <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar"  CssClass="btn-primary " OnClick="Accion"  />
                    <asp:Button ID="btn_Buscar" runat="server" Text="Buscar"  CssClass="btn-primary " OnClick="Accion" /></div>

           
        <div>
            <br />
            <br />
            <br />
        <asp:GridView ID="dgv_Pais" runat="server" OnRowCommand="Seleccionar" CssClass="table-resposive table table-bordered" >
                <Columns>
                    <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" >
                    <ControlStyle CssClass="btn btn-primary" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            </div>
        </form>
         </div>
    
</asp:Content>
