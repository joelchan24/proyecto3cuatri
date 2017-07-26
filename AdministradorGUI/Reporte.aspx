<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="AdministradorGUI.Reporte" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script lang="javaScript" type="text/javascript" src="crystalreportviewers13/js/crviewer/crv.js"></script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" Height="500px" Width="350px"  HasCrystalLogo="False" HasToggleGroupTreeButton="False"/>
</asp:Content>
