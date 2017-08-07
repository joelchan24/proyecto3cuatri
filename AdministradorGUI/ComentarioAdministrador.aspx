<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="ComentarioAdministrador.aspx.cs" Inherits="AdministradorGUI.ComentarioAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 33.33333333333333%;
            top: 17px;
            left: 1px;
            height: 137px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 52%;
            top: 17px;
            left: 1px;
            height: 136px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style3 {
            display: block;
            font-size: 14px;
            line-height: 1.428571429;
            color: #555;
            vertical-align: middle;
            border-radius: 0;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            box-shadow: none;
            -webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            border: 1px solid #d2d6de;
            padding: 6px 12px;
            background-color: #fff;
        }
        .auto-style4 {
            height: 754px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server" class="auto-style4">
        <div class="panel panel-primary" style="height: 191px">
            <div class="auto-style1">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="41px" Width="139px">
        </asp:DropDownList>
            </div>
            <div class="auto-style2">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
         <asp:TextBox ID="txtComentario" TextMode="multiline" Rows="3" cols="20" style="margin: 0px; " CssClass="auto-style3" runat="server" Height="91px" Width="535px"></asp:TextBox>
            </div>
            </div>
    </form>
</asp:Content>
