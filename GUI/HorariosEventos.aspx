<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="HorariosEventos.aspx.cs" Inherits="GUI.HorariosEventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title">DATOS PERSONALES</div>

                        </div> 
                <div class="row">
                    <div class="form-group col-lg-6">
                        <asp:label ID="Label1" runat="server" text="Label" for="email"></asp:label>
                        <asp:dropdownlist ID="Dropdownlist1" runat="server" with="400px" heigh="50px"></asp:dropdownlist><br />
                        <asp:label ID="lblHoraInicio" runat="server" text="Label" for="email"></asp:label><br />
                        <asp:textbox ID="txtHorainicio" runat="server" class="form-control" type="text" placeholder="Digite(10 digitos)"></asp:textbox>
                    </div>
                    <div class="form-group col-lg-6">
                        <asp:label ID="lblHoraFin" runat="server" text="Label" for="email"></asp:label><br />
                        <asp:textbox ID="txtHoraFin" runat="server" class="form-control" type="text" placeholder="Digite(10 digitos)"></asp:textbox>
                    </div>
                </div>
                </div>

        </div>
        <div class="row">
            <asp:hiddenfield runat="server"></asp:hiddenfield>
        </div>
    </div>
</asp:Content>
