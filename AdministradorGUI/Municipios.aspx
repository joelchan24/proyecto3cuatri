<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Municipios.aspx.cs" Inherits="AdministradorGUI.Municipios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID Municipio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txt_IdMunicipio" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre Municipio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txt_NombreMunicipio" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txt_Estado" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
  ControlToValidate="txt_Estado"
  ErrorMessage="No se puede dejar los campos vacios"
  ForeColor="Red">
</asp:RequiredFieldValidator>
            <br />
        </p>
        <p>
     <div> class="col-md-12">
            <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion" />

            <asp:Button ID="btn_Modificar" runat="server" Text="Modificar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion" />

            <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion" />

            <asp:Button ID="btn_Buscar" runat="server" Text="Buscar"  CssClass="btn-primary col-md-2 col-lg-offset-1" OnClick="Accion" />
            </div>
        </p>
        <p>
            <asp:GridView ID="dgv_Estados" runat="server" OnRowCommand="Seleccionar" CssClass="table-resposive table table-bordered" OnRowCreated="ocultar" >
                <Columns>
                    <asp:ButtonField CommandName="dgvbtnSeleccionar" Text="Seleccionar" >
                    <ControlStyle CssClass="btn btn-primary" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </p>
    </form>
</asp:Content>
