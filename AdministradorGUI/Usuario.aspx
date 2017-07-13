<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="AdministradorGUI.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 1235px;
            width: 1080px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="col-md-12">
        <asp:Image ID="Image1" runat="server" Height="110px" Width="160px" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" Width="160px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="584px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre(s):"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="585px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Apellido(s):"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="586px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Telefono:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Width="588px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Fecha de nacimiento:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox5" TextMode="DateTime" runat="server" Width="587px"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Correo:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox8" runat="server" Width="590px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Usuario:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" Width="590px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox7" runat="server" Width="584px"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Colonia:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="TextBox9" runat="server" Width="588px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label11" runat="server" Text="Codigo postal:"></asp:Label>
&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="TextBox10" runat="server" Width="586px"></asp:TextBox>
&nbsp;<br />
            <asp:Label ID="Label12" runat="server" Text="Cruzamiento:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="TextBox11" runat="server" Width="586px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label13" runat="server" Text="Numero interior:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox12" runat="server" Width="583px"></asp:TextBox>
            <br />
            <asp:Label ID="Label14" runat="server" Text="Numero exterior:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox13" runat="server" Width="582px"></asp:TextBox>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Municipio:"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="32px" Width="586px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Agregar" Width="110px" BorderColor="DeepSkyBlue" />
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Modificar" Width="110px" BorderColor="DeepSkyBlue" />
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Eliminar" Width="110px" BorderColor="DeepSkyBlue" />
&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Nuevo" Width="110px" BorderColor="DeepSkyBlue" />
&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="Reporte" Width="110px" BorderColor="DeepSkyBlue" />
            <br />
            <br />
            <asp:TextBox ID="TextBox14" runat="server" Width="460px"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button7" runat="server" Text="Buscar" Width="110px" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="590px">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
