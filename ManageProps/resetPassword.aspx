<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetPassword.aspx.cs" Inherits="ManageProps.resetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <form id="resetPassword" runat="server">
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
                  <div >
                    <div class="form-group" runat="server" visible="false" id="divExpired">
                      <label class="text-danger">That link is expired.</label>
                    </div>
                    <div class="form-group">
                      <input id="txtPass1" type="text" name="txtPass1" required class="input-material" runat="server"/>
                      <label for="txtPass1" class="label-material">Password</label>
                    </div>
                   <div class="form-group">
                      <input id="txtPass2" type="text" name="txtPass2" required class="input-material" runat="server"/>
                      <label for="txtPass2" class="label-material">Re-Enter Password</label>
                    </div>
                   
                    <asp:button id="btnReset" type="submit" text="Reset" class="btn btn-primary" OnClick="btnReset_Click" runat="server"/>
                  </div>
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
        <asp:HiddenField ID="hdUserID" runat="server" />
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
