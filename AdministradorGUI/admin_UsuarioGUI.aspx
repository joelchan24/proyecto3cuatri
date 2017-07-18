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
		<div class="col-md-6">
			<img alt="Bootstrap Image Preview" src="http://lorempixel.com/140/140/" />
		</div>
            <br />
		<div class="col-md-6">
			<div class="form-horizontal" role="form">
				<div class="form-group">
					 
					<label for="inputEmail3" class="col-sm-2 control-label">
						Email
					</label>
					<div class="col-sm-10">
						<input type="email" class="form-control" id="inputEmail3" />
					</div>
				</div>
                <br />
                <br />
				<div class="form-group">
					 
					<label for="inputPassword3" class="col-sm-2 control-label">
						Password
					</label>
					<div class="col-sm-10">
						<input type="password" class="form-control" id="inputPassword3" />
					</div>
				</div>
                <br />
                <br />
				<div class="form-group">
					<div class="col-sm-offset-2 col-sm-10">
						<div class="checkbox">
							 
							<label>
								<input type="checkbox" /> Remember me
							</label>
						</div>
					</div>
				</div>
				<div class="form-group">
					<div class="col-sm-offset-2 col-sm-10">
						 
						<button type="submit" class="btn btn-default">
							Sign in
						</button>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class="row">
		<div class="col-md-6">
			<div class="form-horizontal" role="form">
				<div class="form-group">
					 
					<label for="inputEmail3" class="col-sm-2 control-label">
						Email
					</label>
					<div class="col-sm-10">
						<input type="email" class="form-control" id="inputEmail3" />
					</div>
				</div>
				<div class="form-group">
					 
					<label for="inputPassword3" class="col-sm-2 control-label">
						Password
					</label>
					<div class="col-sm-10">
						<input type="password" class="form-control" id="inputPassword3" />
					</div>
				</div>
				<div class="form-group">
					<div class="col-sm-offset-2 col-sm-10">
						<div class="checkbox">
							 
							<label>
								<input type="checkbox" /> Remember me
							</label>
						</div>
					</div>
				</div>
				<div class="form-group">
					<div class="col-sm-offset-2 col-sm-10">
						 
						<button type="submit" class="btn btn-default">
							Sign in
						</button>
					</div>
				</div>
			</div>
		</div>
	</div>
    </form>
</asp:Content>
