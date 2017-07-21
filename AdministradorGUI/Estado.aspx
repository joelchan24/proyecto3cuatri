<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Estado.aspx.cs" Inherits="AdministradorGUI.Estado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txt_Id" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo País&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_Pais" runat="server"></asp:TextBox>
            <br />
        </p>
        <p>
     <div class="col-md-12">
            <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion"/>

            <asp:Button ID="btn_Modificar" runat="server" Text="Modificar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion"/>

            <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion" />

            <asp:Button ID="btn_Buscar" runat="server" Text="Buscar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="btn_Buscar_Click" />
            </div>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:GridView ID="dgv_Estados" runat="server" OnRowCommand="Seleccionar">
                <Columns>
                    <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" />
                </Columns>
            </asp:GridView>
        </p>
    </form>
</asp:Content>
