﻿<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admi_de eventosGUI.aspx.cs" Inherits="AdministradorGUI.admi_de_eventosGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 275px;
            width:100%
       
}
       

    
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
    <form  id="form1" runat="server" >
      
          <div class="row">
              <h1 > control</h1>
              <div class="col-xs-3" >
                  <div class="form-group">
                      <label for="exampleinput">nombre</label>
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              </div>
                <div class="col-xs-3">
                    <div class="form-group">
                       <label for="exampleinput">apellido</label>
                      <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
              </div>
               <div class="col-xs-3">
                    <div class="form-group">
                         <label for="exampleinput">calle</label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
               </div>
              <div class="col-xs-3">
                    <div class="form-group">
                         <label for="exampleinput">calle</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>

                   
               </div>

          </div>
        

              <div class="row" >
              
              <div class="col-xs-3" >
                  <div class="form-group">
                      <label for="exampleinput">nombre</label>
                      <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                     
                  </div>

              </div>
                <div class="col-xs-3">
                    <div class="form-group">
                       <label for="exampleinput">apellido</label>
                      <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
              </div>
               <div class="col-xs-3">
                    <div class="form-group">
                         <label for="exampleinput">calle</label>
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
               </div>
              <div class="col-xs-3">
                    <div class="form-group">
                         <label for="exampleinput">calle</label>
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
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
      
         

         
</form>
       
</asp:Content>
