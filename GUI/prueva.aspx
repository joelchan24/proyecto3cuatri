<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueva.aspx.cs" Inherits="GUI.prueva" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="txt_usuaer" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btn_loguat" runat="server" Text="cerrar secion"  />
       
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       <div class="form-group">
                      <label for="exampleinput">Escriba Su Mensaje</label>
                     <asp:TextBox id="txt_descrip" TextMode="multiline" Columns="50" cols="100" Rows="50"  runat="server" CssClass="form-control form-group-lg " width="100%" height="50px"                   />
                     </div>
    </div>
        
    </form>
</body>
</html>
