<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_mensaje.aspx.cs" Inherits="GUI.frm_mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container-fluid">
    <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title">Mis Mensajes</div>

                        </div> 
	<div class="row">
		<div class="col-md-2">
            </div>
            <div class="col-lg-10">
			<div class="row"> <br />
				<div class="col-md-4">
                        <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title">Mis Mensajes</div>

                        </div> 
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                      </div>
				</div> <br />
				<div class="col-md-5">
                    <div class="panel panel-info">
                     <label for="exampleinput">Escriba Su Mensaje</label><br />
                  <asp:TextBox id="TextBox2" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; width: 600px" runat="server">           
                  </asp:TextBox>
                     <label for="exampleinput">Escriba Su Mensaje</label><br />
                  <asp:TextBox id="txt_mensaje" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; width:600px" runat="server">           
                  </asp:TextBox>
                 <button type="button" class="btn  btn-xs btn-info">
				  Default
			     </button> 
				</div>
                    </div>
                </div>
		</div>
	</div>
        </div>
    </div>         
</asp:Content>
