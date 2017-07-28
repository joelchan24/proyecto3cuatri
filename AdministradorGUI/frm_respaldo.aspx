<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="frm_respaldo.aspx.cs" Inherits="AdministradorGUI.frm_respaldo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="panel panel-danger">
        <asp:Button ID="Button1" runat="server" Text="Hacer Bakup" OnClick="seleccionar"/>
            </div>
    </form>
</asp:Content>