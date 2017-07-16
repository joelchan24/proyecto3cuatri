<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admi_de eventosGUI.aspx.cs" Inherits="AdministradorGUI.admi_de_eventosGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 275px;
            width:100%
       
}
        .style {
            margin: 0px;
            width: 349px;
            height: 404px;
        }

    
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <script src="https://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src='https://maps.google.com/maps/api/js?sensor=false&libraries=places&key=AIzaSyCuiUJxL3eVPwCyGdf1P6g9TUQ4KW95YtA'></script>
    <script src="js/locationpicker.jquery.js"></script>
    <form  id="form1" runat="server" >
      
          <div class="row">
              <h1 > control</h1>
               <asp:HiddenField  ID="txtid" runat="server" />
              <asp:HiddenField ID="txt_codir" runat="server" />
              <div class="col-xs-4" >
                  <div class="form-group">
                      <label for="exampleinput">nombre</label>
                      <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Fecha Apertura</label>
                      <asp:TextBox ID="txt_aperura" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput">Fecha De Cierre</label>
                        <asp:TextBox ID="txt_fecha_cierre" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                    </div>
                   
               </div>
             
          </div>
        

              <div class="row" >
              
              <div class="col-xs-4" >
                  <div class="form-group">
                      <label for="exampleinput">Precio</label>
                      <asp:TextBox ID="txt_precio" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              </div>
                <div class="col-xs-4">
                    <div class="form-group">
                       <label for="exampleinput">Categoria</label>
                      <asp:DropDownList ID="DropDownList1" runat="server" Width="100%"></asp:DropDownList>
                        </div>
              </div>
               <div class="col-xs-4">
                    <div class="form-group">
                         <label for="exampleinput">Municipio</label>
                       <asp:DropDownList ID="DropDownList2" runat="server" Width="100%"></asp:DropDownList>  

                    </div>
                   
               </div>
      

          </div>
         <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label for="exampleinput">Ubicacion</label>
                   
                    <asp:TextBox ID="txt_ubicar" runat="server" CssClass="form-control"></asp:TextBox>


                </div>
                <div class="form-group">
                    <div id="ModalMapPreview" style="width:100%; height:300px;"></div>
                </div>
                <!--altitud y lon-->
               
                <div class="form-group">
                    <label for="exampleinput">lat:</label>
                    <asp:TextBox ID="txtlat" runat="server" Text="20.938297181414647" CssClass="form-control"></asp:TextBox>
                     <label for="exampleinput">log:</label>
                    <asp:TextBox ID="txt_lo" runat="server" Text="-89.61501516379462" CssClass="form-control"></asp:TextBox>
                </div>
                <!--altasb  , bjaas y ca,mbios botonos-->
                <div>
                         </div>
            </div>
            <div class="col-md-4">

                
                  <div class="form-group">
                      <label for="exampleinput">C.P</label>
                      <asp:TextBox ID="txt_postal" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Colonia</label>
                      <asp:TextBox ID="txt_colonia" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">Número Interior</label>
                        <asp:TextBox ID="txt_numint" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                 <div class="form-group">
                      <label for="exampleinput">Número Exterior</label>
                      <asp:TextBox ID="txt_numexter" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">Cruzamientos</label>
                      <asp:TextBox ID="txt_crizamiento" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
                <br />
                <div class="form-group">
                      <label for="exampleinput">c.postal</label>
                     
                        <asp:Image ID="Image1" runat="server" />
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                     
                  </div>
               
              
        </div>
              <div class="col-md-4">

                
                  <div class="form-group">
                      <label for="exampleinput">Descripcion</label>
                     <asp:TextBox id="TextArea1" TextMode="multiline" Columns="50" Rows="5" runat="server" CssClass="form-control " width="349px" height=350px                  />
                     
                  </div>

              
            
                   
                   
                   

              
            
                    <div class="form-group">
                       <label for="exampleinput" >aprovacion</label><br />
                      <label class="radio-inline" >
                          <asp:RadioButton ID="rbt_aprovado" runat="server" type="radio" name="optradio"  />  Aprovado
      
    </label>
                        
    <label class="radio-inline">
      <input type="radio" name="optradio">

        <asp:RadioButton ID="rbt_noapro" runat="server" type="radio" name="optradio" />  No aprovado
    </label>
                       
              </div>
                  
                    <div class="form-group">
                       <label for="exampleinput">Usuariol</label>
                      <asp:TextBox ID="txt_usuario" runat="server" CssClass="form-control"></asp:TextBox>
                         
              </div>
               
                  
        </div>

               
       <div class="form-group ">
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn-primary   " />
         
        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" CssClass="btn-primary  " />
             <asp:Button ID="btn_agregar" runat="server" Text="agregar" CssClass="btn-primary   " />
         
        <asp:Button ID="btn_nuevo" runat="server" Text="nuevo" CssClass="btn-primary     " />
         </div>

</div>
          

        <asp:GridView ID="dgv_usuarios" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:ButtonField CommandName="dvg_btnSelecinar" Text="Selecionar" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
      
        

 <script>
        $('#ModalMapPreview').locationpicker({
            radius: 0,
            location: {
                latitude: $('#<%=txtlat.ClientID%>').val(),
                longitude: $('#<%=txt_lo.ClientID%>').val()
            },
            inputBinding: {
                latitudeInput: $('#<%=txtlat.ClientID%>'),
                longitudeInput: $('#<%=txt_lo.ClientID%>'),
                locationNameInput: $('#<%=txt_ubicar.ClientID%>')
            },
            enableAutocomplete: true


        });



            



    </script>
         
</form>
       
</asp:Content>
