<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_mensaje.aspx.cs" Inherits="GUI.frm_mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div class="container">
        <div class="row">



            <br />
            <br />
             <br />
            <br />
             <br />
            <br />
		<div class="col-md-6">
            <div class="form-group">
             <label for="exampleinput">Escriba Su Mensaje</label><br />
            <asp:TextBox id="txt_mensaje" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; width: 999px" runat="server">           
            </asp:TextBox>
            <button type="button" class="btn  btn-xs btn-info">
				Default
			</button>
                </div>
		</div>
		<div class="col-md-6">
            
		</div>

	</div>
      
                
</div>
        
        
                 
       
</asp:Content>
