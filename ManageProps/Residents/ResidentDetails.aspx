<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ResidentDetails.aspx.cs" Inherits="ManageProps.Residents.ResidentDetails" %>
<%@ Register Src="~/codeLogic/Controls/ResidentTabControls/UserControl.ascx" TagName="CustomFieldValues" TagPrefix="uc" %>
<%@ Register Src="~/codeLogic/Controls/ResidentTabControls/GeneralTab.ascx" TagName="GeneralInfo" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link rel="stylesheet" type="text/css" href="../css/tabs/normalize.css" />
		<link rel="stylesheet" type="text/css" href="../css/tabs/tabs.css" />
		<link rel="stylesheet" type="text/css" href="../css/tabs/tabstyles.css" />
  		<script src="/vendor/tabs/modernizr.custom.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <div class="page-content d-flex align-items-stretch">
            <section class="forms col-lg-12">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="card">

                                <div class="card-header d-flex align-items-center">
                                    <h3 class="h4">Edit Details</h3>
                                </div>
                                <div class="card-body">
				<div class="tabs tabs-style-bar">
					<nav>
						<ul>
							<li><a href="#section-bar-1"><span>General</span></a></li>
							<li><a href="#section-bar-2"><span>Occupants</span></a></li>
							<li><a href="#section-bar-3"><span>Transactions</span></a></li>
							<li><a href="#section-bar-4"><span>Payments</span></a></li>
							<li><a href="#section-bar-5"><span>Metered Utilities</span></a></li>
							<li><a href="#section-bar-6"><span>Recurring Charges</span></a></li>
							<li><a href="#section-bar-7"><span>User Defined</span></a></li>
						</ul>
					</nav>
					<div class="content-wrap">
						<section id="section-bar-1">
                            <uc:GeneralInfo runat="server" ID="tabGeneralInfo" />

						</section>
						<section id="section-bar-2"><p>2</p></section>
						<section id="section-bar-3"><p>3</p></section>
						<section id="section-bar-4"><p>4</p></section>
						<section id="section-bar-5"><p>5</p></section>
						<section id="section-bar-6"><p>6</p></section>
						<section id="section-bar-7">
                            <uc:CustomFieldValues runat="server" id="tabFields"></uc:CustomFieldValues>
						</section>
					</div><!-- /content -->
				</div><!-- /tabs -->

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary" OnClick="btnSave_Click" Text="Save" />



                        </div>
                    </div>
                </div>
            </section>
        </div>

    <script src="../vendor/tabs/cbpFWTabs.js"></script>
		<script>
            (function () {

                [].slice.call(document.querySelectorAll('.tabs')).forEach(function (el) {
                    new CBPFWTabs(el);
                });

            })();
		</script>
</asp:Content>
