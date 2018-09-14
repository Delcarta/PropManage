<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ManageProps.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <title>Log-In</title>
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
    <!-- Favicon
    <link rel="shortcut icon" href="img/favicon.ico"/>-->
    <!-- Tweaks for older IEs--><!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->
  </head>
<body>
    <form id="form1" runat="server">
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
            <div class="col-lg-6 bg-white">
              <div class="form d-flex align-items-center">
                <div class="content">
                    <div class="form-group text-danger" id="divLogInError" runat="server" visible="false">
                        <label>That user/password combo is incorrect.</label>
                    </div>
                    <div class="form-group">
                      <input id="txtLoginUserName" type="text" name="loginUsername" required="" class="input-material" runat="server"/>
                      <label for="txtLoginUserName" class="label-material">User Name</label>
                    </div>
                    <div class="form-group">
                      <input id="txtLoginPassword" type="password" name="loginPassword" required="" class="input-material" runat="server"/>
                      <label for="txtLoginPassword" class="label-material">Password</label>
                    </div><asp:button runat="server" id="txtLogin"  class="btn btn-primary" Text="Log In" OnClick="TxtLogin_Click"></asp:button>
                    <!-- This should be submit button but I replaced it with <a> for demo purposes-->
                  <a href="recover.aspx" class="forgot-pass">Forgot Password?</a><br/><small>Do not have an account? </small><a href="register.aspx" class="signup">Signup</a>
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
    <script src="vendor/chart.js/Chart.min.js"></script>
    <script src="vendor/jquery-validation/jquery.validate.min.js"></script>
    <!-- Main File-->
    <script src="js/front.js"></script>
    </form>
</body>
</html>

