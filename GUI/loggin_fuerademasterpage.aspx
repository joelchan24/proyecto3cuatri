<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loggin_fuerademasterpage.aspx.cs" Inherits="GUI.loggin_fuerademasterpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style>
        body {  
        background:url("img\f57e4fe6f90a9648702d6184a1ceee20--mexico-vacation-mexico-city.jpg") repeat 0 0;                   
 }
        #video1 
        {
            position:fixed;
            left:0;
            top:0;
            min-height:100%;
            min-width:100%;
            width:auto;
            height:auto;
            z-index:-10;
            visibility:visible;

        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server"  >
        
    
    <div class="container cl">    
        <div id="loginbox" style="margin-top:50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
            <div class="panel panel-primary"  style="background-color:transparent;">
                    <div class="panel-heading">
                        <div class="panel-title">Inicio de sesión</div>
                    </div>     

                    <div style="padding-top:30px" class="panel-body" >

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                            
                        <form id="loginform" class="form-horizontal" role="form">
                                    
                                
                            <div style="margin-bottom: 25px " class="input-group col-lg-offset-2 ">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:TextBox ID="txt_usuario" runat="server" type="text" CssClass="form-control " name="username" value="" placeholder="Username or Email"></asp:TextBox>
                                        </div>
                                
                            <div style="margin-bottom: 25px" class="input-group col-lg-offset-2 ">
                                        <span class="input-group-addon "><i class="glyphicon glyphicon-lock " ></i></span>
        <asp:TextBox ID="txt_contraseña" runat="server" CssClass="form-group form-control" type="password" class="form-control " name="password" placeholder="Password"></asp:TextBox>
                                              </div>
                                    

                                
                            <div class="input-group col-lg-offset-2">
                                      <div class="checkbox">
                                        <label>
                                          <input id="login-remember" type="checkbox" name="remember" value="1" > Recordar Contraseña
                                        </label>
                                      </div>
                                    </div>


                                <div style="margin-top:10px" class="form-group col-lg-offset-3">
                                    <!-- Button -->

                                    <div class="col-sm-12 controls">
        <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar"  href="#" class="btn btn-sm  btn-primary " Width="90px" OnClick="condicion_de_login" />
                                        <!--<asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-sm  btn-success" Height="35px" Width="80px" PostBackUrl="registro_usuarios_fueramasterpge.aspx">Registrarme</asp:LinkButton>
                                         <!--<asp:Button ID="btnRegistrarme" runat="server" Text="Ingresar"   class="btn btn-sm  btn-success" />-->
                                      <asp:Button ID="Button1" runat="server" CssClass="btn btn-sm  btn-success " Text="Registrarme" OnClick="Button1_Click" />

                                    </div>
                                </div>


                                <div class="form-group col-lg-offset-1">
                                    <div class="col-md-12 control">
                                        <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%" >
                                            No te has Registrado?
                                        <a href="registro_usuarios_fueramasterpge.aspx" >
                                            Registrate Aqui
                                        </a>
                                        </div>
                                    </div>
                                </div>    
                            </form>     



                        </div>                     
                    </div>  
        </div>
        <div id="signupbox" style="display:none; margin-top:50px" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <div class="panel-title">Sign Up</div>
                            <div style="float:right; font-size: 85%; position: relative; top:-10px"><a id="signinlink" href="#" onclick="$('#signupbox').hide(); $('#loginbox').show()">Ingresar</a></div>
                        </div>  
                        <div class="panel-body" >
                            <form id="signupform" class="form-horizontal" role="form">
                                
                                <div id="signupalert" style="display:none" class="alert alert-danger">
                                    <p>Error:</p>
                                    <span></span>
                                </div>
                                    
                                
                                   <div class="form-group">
                                    <label for="email" class="col-md-3 control-label">Códigoo</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="codigo" placeholder="Código">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="email" class="col-md-3 control-label">Nombres</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="nombres" placeholder="Nombres">
                                    </div>
                                </div>
                                  <div class="form-group">
                                    <label for="email" class="col-md-3 control-label">Foto</label>
                                    <div class="col-md-9">2
                                        <input type="text" class="form-control" name="nombres" placeholder="FOTO">
                                    </div>
                                </div>
                                                         <div class="form-group">
                                    <label for="email" class="col-md-3 control-label">Apellidos</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="Apellidos" placeholder="Apellidos">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="firstname" class="col-md-3 control-label">Telefóno</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="Telefono" placeholder="Numero De telefóno">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="firstname" class="col-md-3 control-label">Fecha de nacimiento</label>
                                    <div class="col-md-9">
                                        <input type="date" class="form-control" name="firstname" />
                                    </div>
                                </div>
                               <div class="form-group">
                                    <label for="firstname" class="col-md-3 control-label">Correo electronico</label>
                                    <div class="col-md-9">
                                        <input type="email" class="form-control" name="firstname" placeholder="Correo electronico">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="firstname" class="col-md-3 control-label">Nombre De Usuario</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="firstname" placeholder="Nombre De Usuario">
                                    </div>
                                </div>
                               
                               
                                <div class="form-group">
                                    <label for="password" class="col-md-3 control-label">Contraseña</label>
                                    <div class="col-md-9">
                                        <input type="password" class="form-control" name="passwd" placeholder="Contraseña">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="password" class="col-md-3 control-label">Colonia</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="passwd" placeholder="Colonia">
                                    </div>
                                </div>
                                    
                                <div class="form-group">
                                    <label for="icode" class="col-md-3 control-label">Código Postal</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="icode" placeholder="Código Postal">
                                    </div>
                                </div>
                                 <div class="form-group">
                                    <label for="icode" class="col-md-3 control-label">Cruzamientos</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="icode" placeholder="Cruzamiento">
                                    </div>
                                </div>
                                    <div class="form-group">
                                    <label for="icode" class="col-md-3 control-label">Número Interior</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="icode" placeholder="Número Interior">
                                    </div>
                                </div>
                                    <div class="form-group">
                                    <label for="icode" class="col-md-3 control-label"> Número Exterior</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="icode" placeholder=" Número Exterior">
                                    </div>
                                </div>
                                    <div class="form-group">
                                    <label for="icode" class="col-md-3 control-label">Código Municipio</label>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" name="icode" placeholder="Código Municipio">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <!-- Button -->                                        
                                    <div class="col-md-offset-3 col-md-9">
                                        <button id="btn-signup" type="button" class="btn btn-info"><i class="icon-hand-right"></i> Registrame</button>
                                         
                                    </div>
                                </div>
                                
                               
                                
                                
                            </form>
                         </div>
                    

               
               
                </div>
            
  
    </div>
    </div>
    </form>
    <video id="video1" src="img/Capital%20Americana%20de%20la%20Cultura%202017.mp4" loop="loop" autoplay="autoplay" preload="auto" muted="muted"></video>
    <script  type="text/javascript" src="js/jquery.backstretch.min.js"></script>
    <script>

        $.backstretch("img/f57e4fe6f90a9648702d6184a1ceee20--mexico-vacation-mexico-city.jpg",{speed:500})

    </script>
</body>
</html>
