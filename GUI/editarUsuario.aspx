<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="editarUsuario.aspx.cs" Inherits="GUI.editarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title"><h3 style="text-align:center">CONTROL DE REGISTRO DE EVENTOS</h3></div>

                        </div> 
         <div class="container">
         <div class="row">
             <div class="form-group">
                 <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                 <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
             </div>
         </div>
             </div>
         </div>
</asp:Content>
