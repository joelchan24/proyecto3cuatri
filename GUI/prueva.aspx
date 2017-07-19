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
        <asp:Button ID="btn_loguat" runat="server" Text="cerrar secion" OnClick="btn_loguat_Click" />
       
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
    </div>
        
    </form>
</body>
</html>
