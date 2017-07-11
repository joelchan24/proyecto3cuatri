<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="AdministradorGUI.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 315px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</asp:Content>
