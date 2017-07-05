<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar_usuario.aspx.cs" Inherits="GUI.registrar_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/estilo-usuario.css" rel="stylesheet" />
    <title></title>
</head>
<body>
       <h1>REGITRO DE USUARIO</h1>
    <form class="formulario" id="form1" runat="server">
        <h2 class="tit">informacion del usuario</h2>
        <div class="cont-bonetes">
            <input type="text" name="cod" placeholder="codigo" class="input-48"/>
            <input  type="text" name="nombre" placeholder="Nombre" class="input-48" required="required"/>
            <input type="text"  name="apellido" placeholder="Apellido"class="input-48" required="required"/>
            <input  type="tel" name ="telefono" placeholder="Telefono" class="input-48" required="required" />
            <label  class="lavel" >fecha</label>
            <input type="date" name="fecha de nacimiento " class="input-100" required="required"/>
            <input  type="email" name="corre" placeholder="Correo" class="input-100" required="required"/>
            <input  type="text" name="usuario" placeholder="nombre de usuario" class="input-48" required="required"/>
            <input type="password" name="contraseña" placeholder="constraseña"class="input-48"  required="required"/>
           <!-- <input  type="text" name="foto" placeholder="ruta" class="input-48" required="required"/>-->
            <input type="submit"  value="ingresar dirrecion"  class="bt"/><br /><br /><br />
            <input   type="text" name="diirecoom " placeholder="dirrecion" class="input-100" disabled="disabled" required="required"/>
                <input type="submit" value="agregar" class="btt"   />



        </div>

              
    
    </form>
</body>
</html>
