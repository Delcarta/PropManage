<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ManageProps.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <title>Register</title>
        <meta name="description" content=""/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <meta name="robots" content="all,follow"/>
        <!-- Bootstrap CSS-->
        <link rel="stylesheet" href="vendor/bootstrap/css/bootstrap.min.css"/>
        <!-- Font Awesome CSS-->
        <link rel="stylesheet" href="vendor/font-awesome/css/font-awesome.min.css"/>
        <!-- Fontastic Custom icon font-->
        <link rel="stylesheet" href="css/fontastic.css"/>
        <!-- Google fonts - Poppins -->
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,700"/>
        <!-- theme stylesheet-->
        <link rel="stylesheet" href="css/style.default.premium.css" />
        <!-- Custom stylesheet - for your changes-->
        <link rel="stylesheet" href="css/custom.css"/>
        <!-- Favicon-->
        <!--<link rel="shortcut icon" href="img/favicon.ico">-->
        <!-- Tweaks for older IEs--><!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
            <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->
</head>
<body>
    <form id="registerForm" runat="server">
         <div class="page login-page">
      <div class="container d-flex align-items-center">
        <div class="form-holder has-shadow">
          <div class="row">
            <!-- Logo & Information Panel-->
            <div class="col-lg-6">
              <div class="info d-flex align-items-center">
                <div class="content">
                  <div class="logo">
                    <h1>Simply Manage</h1>
                  </div>
                  <p>A straight forward property management solution for all.</p>
                </div>
              </div>
            </div>
            <!-- Form Panel    -->
            <div class="col-lg-6 bg-white">
              <div class="form d-flex align-items-center">
                <div class="content">
                  <div id="register-form">
                    <div class="form-group">
                      <input id="txtUser" type="text" name="registerUsername" required class="input-material" runat="server"/>
                      <label for="txtUser" class="label-material">User Name</label>
                    </div>
                    <div class="form-group">
                      <input id="txtEmail" type="email" name="registerEmail" required class="input-material" runat="server"/>
                      <label for="txtEmail" class="label-material">Email Address      </label>
                    </div>
                    <div class="form-group">
                      <input id="txtPassword" type="password" name="registerPassword" required class="input-material" runat="server"/>
                      <label for="txtPassword" class="label-material">password        </label>
                    </div>
                      <div class="form-group">
                      <input id="txtFirstName" type="text" name="registerFirst" required class="input-material" runat="server"/>
                      <label for="txtFirstName" class="label-material">First Name        </label>
                    </div>
                      <div class="form-group">
                      <input id="txtLastName" type="text" name="registerLast" required class="input-material" runat="server"/>
                      <label for="txtLastName" class="label-material">Last Name        </label>
                    </div>
                    <div class="form-group terms-conditions">
                      <input id="license" type="checkbox" class="checkbox-template"/>
                      <label for="license">Agree the terms and policy</label>
                    </div>
                    <asp:button id="btnRegister" type="submit" text="Register" class="btn btn-primary" OnClick="register_Click" runat="server"/>
                  </div><small>Already have an account? </small><a href="login.aspx" class="signup">Login</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="copyrights text-center">
        <p>A site by <a href="https://www.implicitarts.com" class="external">Implicit Arts</a></p>
      </div>
    </div>
    <!-- Javascript files-->
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="vendor/popper.js/umd/popper.min.js"> </script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="vendor/jquery.cookie/jquery.cookie.js"> </script>
    <script src="vendor/jquery-validation/jquery.validate.js"></script>
    <!-- Main File-->
    <script src="js/front.js"></script>
    </form>
</body>
</html>
