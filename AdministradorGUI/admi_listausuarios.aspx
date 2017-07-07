<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admi_listausuarios.aspx.cs" Inherits="GUI.admi_listausuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="css/estilo-usuario.css" rel="stylesheet" />
     <h1>REGITRO DE USUARIO</h1>
    <form  id="form1" runat="server">
      

        <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Button" type="submit" value="agregar" class="btt" />
            <asp:Button ID="Button6" runat="server" Text="Button"  type="subimt" value="agregar" Class="btt" />
            <asp:Button ID="Button7" runat="server" Text="Button" />
            <asp:Button ID="Button8" runat="server" Text="Button" />
            <br />
            <br />
     <asp:GridView ID="GridView1" runat="server" Height="236px" Width="811px">
            <Columns>
                <asp:ButtonField Text="Botón" />
            </Columns>
        </asp:GridView>
           



</form>
   
</asp:Content>
