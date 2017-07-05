<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GUI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="css/bootstrap.min.css" type="text/css" rel="stylesheet" />
   <link href="css/bootstrap-theme.css" type="text/css" rel="stylesheet" />
    <link href="css/login.css" type="text/css" rel="stylesheet" />

    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.mi.js"></script>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server" >
         <div class="container ">

<div class="row" style="margin-top:4px">
    <div class= "login col-lg-12 col-lg-8">
		
			<fieldset>
				<h2>Please Sign n</h2>
				
				<hr class="colorgraph"/>
				<div class="form-group">
                    
                    <asp:TextBox ID="txt_nombre" runat="server"   class="form-control input-lg" placeholder="Correo"></asp:TextBox>
				</div>
				<div class="form-group">
                   
                    <asp:TextBox ID="txt_contraeña" runat="server" type="password" name="password"  class="form-control input-lg" placeholder="Contraseña"></asp:TextBox>
				</div>
				<span class="button-checkbox">
                   
                    
               <asp:CheckBox ID="CheckBox1" runat="server" type="checkbox"  name="remember_me"  class="btn btn-link pull-right" />
					<a href="#" class="btn btn-link pull-right">Recordar contraseña </a>
				
				</span>
                <BR>
				
				<hr class="colorgraph"/>
				<div class="row">
					<div class="col-xs-10 col-sm-6 col-md-6">
                
                       <asp:Button ID="Button4" runat="server" Text="Registrarse" href="#" class="btn btn-lg btn-success btn-block" />
						
                       
					</div>
					<div class="col-xs-6 col-sm-6 col-md-6">
                         <asp:Button ID="Button3" runat="server" Text="INGRESAR" href="#" class="btn btn-lg btn-primary btn-block" OnClick="Button3_Click" />
						
					</div>
				</div>
			</fieldset>
		
	</div>
</div>

</div>
       
    <div>
    
    </div>
    </form>
</body>
</html>
