<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_mensaje.aspx.cs" Inherits="GUI.frm_mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div class="container">
        <div class="row">
		<div class="col-md-6">
            <asp:TextBox id="txt_mensaje" TextMode="multiline" Rows="3" cols="500" runat="server">           
            </asp:TextBox>
            <button type="button" class="btn btn-block btn-xs btn-info">
		</div>
		<div class="col-md-6">
             
		</div>

	</div>
      
                
</div>
        
        
                 
       
</asp:Content>
