<%@ Page Title="" Language="C#" MasterPageFile="~/administrador.Master" AutoEventWireup="true" CodeBehind="admin_UsuarioGUI.aspx.cs" Inherits="AdministradorGUI.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            height: 1235px;
            width: 1080px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <link href="css/estilo-usuario.css" rel="stylesheet" />
    <form id="form1" runat="server">
        <div class="row">
		<div class="col-md-12">
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<img alt="Bootstrap Image Preview" src="http://lorempixel.com/140/140/" class="img-circle">
		</div>
	</div>
	<div class="row">
		<div class="col-md-4">
			<form role="form">
				<div class="form-group">
					 
					<label for="exampleInputEmail1">
						Email address
					</label>
					<input type="email" class="form-control" id="exampleInputEmail1">
				</div>
				<div class="form-group">
					 
					<label for="exampleInputPassword1">
						Password
					</label>
					<input type="password" class="form-control" id="exampleInputPassword1">
				</div>
				<div class="form-group">
					 
					<label for="exampleInputFile">
						File input
					</label>
					<input type="file" id="exampleInputFile">
					<p class="help-block">
						Example block-level help text here.
					</p>
				</div>
				<div class="checkbox">
					 
					<label>
						<input type="checkbox"> Check me out
					</label>
				</div> 
				<button type="submit" class="btn btn-default">
					Submit
				</button>
			</form>
		</div>
		<div class="col-md-4">
			 
			<button type="button" class="btn btn-lg btn-block btn-info">
				Default
			</button> 
			<button type="button" class="btn btn-block btn-lg active btn-success">
				Default
			</button>
		</div>
		<div class="col-md-4">
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
		</div>
	</div>
    </form>
</asp:Content>
