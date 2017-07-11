<%@ Page Title="" Language="C#" MasterPageFile="~/homevisor.Master" AutoEventWireup="true" CodeBehind="loginn.aspx.cs" Inherits="GUI.loginn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <!--    
        <div class="form-horizontal">
            <div class="row">
                <div class="jumbotron">
            <h2 class="fa-align-center">Ingresar</h2>
            <div class="form-group">
                <label>Nombre de Usuario  </label>
    <asp:TextBox ID="TextBox2" runat="server"  ></asp:TextBox>

    <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
                <div>
    <asp:Button ID="Button2" runat="server" Text="ingresar" CssClass="btn btn-info" />
                    </div>
    <asp:Button ID="Button1" runat="server" Text="hjjhj"  CssClass=" btn btn-success"/>
                </div>
                </div>
                </div>
            </div>
        
    </div
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
<div class="main">
    
    
    <div class="container">
<center>
<div class="middle">
      <div id="login">

        <form action="javascript:void(0);" method="get">

          <fieldset class="clearfix">

            <p ><span class="fa fa-user"></span><input type="text"  Placeholder="Username" required></p> <!-- JS because of IE support; better: placeholder="Username" -->
      <div class="container">    
        <div id="loginbox" style="margin-top:50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
            <div class="panel panel-info" >
                    <div class="panel-heading">
                        <div class="panel-title">Sign In</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px"><a href="#">Forgot password?</a></div>
                    </div>     

                    <div style="padding-top:30px" class="panel-body" >

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                            
                        <form id="loginform" class="form-horizontal" role="form">
                                    
                                    
                                
                            <div style="margin-bottom: 25px " class="input-group col-lg-offset-2 ">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:TextBox ID="txt_usuario" runat="server" type="text" class="form-control " name="username" value="" placeholder="username or email"></asp:TextBox>
                                        </div>
                                
                            <div style="margin-bottom: 25px" class="input-group col-lg-offset-2 ">
                                        <span class="input-group-addon "><i class="glyphicon glyphicon-lock " ></i></span>
        <asp:TextBox ID="txt_contraseña" runat="server" type="password" class="form-control " name="password" placeholder="password"></asp:TextBox>
                                              </div>
                                    

                                
                            <div class="input-group col-lg-offset-2">
                                      <div class="checkbox">
                                        <label>
                                          <input id="login-remember" type="checkbox" name="remember" value="1"> Recordar Contraseña
                                        </label>
                                      </div>
                                    </div>


                                <div style="margin-top:10px" class="form-group col-lg-offset-3">
                                    <!-- Button -->

                                    <div class="col-sm-12 controls">
        <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar"  href="#" class="btn  btn-primary " OnClick="Button1_Click" />
                                      
                                      <a id="btn-fblogin" href="#" onclick="$('#loginbox').hide(); $('#signupbox').show()" class="btn btn-success">registrarse</a>

                                    </div>
                                </div>


                                <div class="form-group col-lg-offset-1">
                                    <div class="col-md-12 control">
                                        <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%" >
                                            No te has Registrado?
                                        <a href="#" onClick="$('#loginbox').hide(); $('#signupbox').show()">
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

</asp:Content>
