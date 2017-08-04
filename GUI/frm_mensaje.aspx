<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="frm_mensaje.aspx.cs" Inherits="GUI.frm_mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title"> Mis Mensajes</div>

                        </div> 
		<div class="row">
		<div class="col-md-4">
            <asp:GridView ID="dgb_mismensajes" runat="server" OnRowCommand="dgb_mismensajes_RowCommand" CssClass="table-resposive table table-bordered" OnRowCreated="dgb_mismensajes_RowCreated" OnRowDataBound="dgb_mismensajes_RowDataBound" BorderStyle="Groove">
                <Columns>
                    <asp:ButtonField CommandName="btn_leer" Text="Leer Mensaje">
                    <ControlStyle CssClass="btn btn-warning" />
                    </asp:ButtonField>
                </Columns>
        <HeaderStyle BackColor="#28a4c9" Font-Bold="True" ForeColor="White"></HeaderStyle>
            </asp:GridView>
                                <asp:HiddenField ID="txt_nombre" runat="server" />
                                <asp:HiddenField ID="txt_codigousuarioevento" runat="server" />
                                <asp:HiddenField ID="txt_idusuariooconectado" runat="server" />
		</div>
                                <asp:HiddenField ID="txt_evento" runat="server" /><asp:HiddenField ID="txt_usuairo" runat="server" />
                                <asp:HiddenField ID="txt_id" runat="server" />
		<div class="col-md-8">
            <div class="form-group">           
                     <label for="exampleinput">Destinatario<br />
                 <asp:DropDownList ID="DropDownList1" Width="400px " CssClass="btn btn-default btn-sm" runat="server" >
    
                 </asp:DropDownList>
                     </div>
            <div class="form-group">           
                     <label for="exampleinput">Mensaje Recibido<br />
                  <asp:TextBox id="txt_resivido" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; width: 702px;" runat="server" Enabled="false"> </asp:TextBox>
                </div>
            <div class="form-group">
                     <label for="exampleinput">Escriba Su Mensaje</label><br />
                  <asp:TextBox id="txt_mensaje" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; width: 702px;" runat="server"> </asp:TextBox>
                 
				</div>

            <div class="form-group">
              
                    <asp:Button ID="btn_enviar" runat="server" Text="enviar"  class="btn  btn-xs btn-info" OnClick="enviar"/>&nbsp; &nbsp;
                <asp:Button ID="Button1" runat="server" Text="Borrar"  class="btn  btn-xs  btn-danger" OnClick="borra" />

				 
            </div>



		</div>
	</div>
        </div>
    </div>         
    </label>
    </label>
</asp:Content>
