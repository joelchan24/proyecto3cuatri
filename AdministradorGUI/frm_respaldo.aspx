<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="frm_respaldo.aspx.cs" Inherits="AdministradorGUI.frm_respaldo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="panel panel-primary" style="width:1160px !important">
         <div class="panel-heading " style="text-align:center !important">Respaldo de Información</div>
    <form id="form1" runat="server">
        <div class="row">
             <div class="col-md-4">
                
            </div>
            <div class="col-md-4">
                <div class="form-horizontal">
                    <label>Hacer copia de seguuridad</label>
               
                  <asp:Button ID="Button1" runat="server" Text="Hacer Bakup" OnClick="seleccionar" CssClass="btn btn-info" />
                
                    </div>
            </div>
     
         
              <div class="col-md-4">
                
            </div>
 
            </div>
    </form>
          </div>
</asp:Content>