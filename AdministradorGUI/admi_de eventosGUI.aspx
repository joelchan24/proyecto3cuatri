<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admi_de eventosGUI.aspx.cs" Inherits="AdministradorGUI.admi_de_eventosGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 275px;
            width:100%
       
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
                      <label for="exampleinput">c.postal</label>
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">colonia</label>
                      <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">numero interio</label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                 <div class="form-group">
                      <label for="exampleinput">c.postal</label>
                      <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">colonia</label>
                      <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">numero interio</label>
                        <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
              
        </div>
              <div class="col-md-4">

                
                  <div class="form-group">
                      <label for="exampleinput">c.postal</label>
                      <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">colonia</label>
                      <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">numero interio</label>
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                      <label for="exampleinput">c.postal</label>
                     
                        <asp:Image ID="Image1" runat="server" />
                     
                  </div>

              
            
                    <div class="form-group">
                       <label for="exampleinput">colonia</label>
                      <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control"></asp:TextBox>
                       
              </div>
               
                    <div class="form-group">
                         <label for="exampleinput">numero interio</label>
                        <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
              
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
