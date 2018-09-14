<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="ManageProps.Apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="vendor/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/style.default.premium.css" />
    <link rel="stylesheet" href="css/custom.css" />
    <link rel="stylesheet" href="vendor/font-awesome/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="content-full">
                <header class="page-header">
                    <div class="container-fluid">
                        <h2 class="no-margin-bottom text-center">Resident Application Form</h2>
                        <h3 class="text-center">
                            <asp:Label runat="server" ID="lblPropertyName"></asp:Label></h3>
                        <h4 class="text-center">
                            <asp:Label runat="server" ID="lblPropertyAddress"></asp:Label>
                            <br />
                            <asp:Label runat="server" ID="lblPropertyPhone"></asp:Label></h4>
                    </div>
                </header>
                <div class="page-content d-flex align-items-stretch">
                    <section class="forms">
                        <div class="container-fluid">
                            <div class="row">
                                <!-- Primary App Form-->
                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Primary Applicant</h3>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <label class="form-control-label">First Name</label>
                                                <input type="text" placeholder="First Name" class="form-control" runat="server" id="txtPrimaryFirstName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Last Name</label>
                                                <input type="text" placeholder="Last Name" class="form-control" runat="server" id="txtPrimaryLastName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Phone</label>
                                                <input type="text" placeholder="Phone" class="form-control" runat="server" id="txtPrimaryPhone" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Social Security #</label>
                                                <input type="text" placeholder="Social Security #" class="form-control" runat="server" id="txtPrimarySocial" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Date of Birth</label>
                                                <input type="date" placeholder="Date of Birth" class="form-control" runat="server" id="txtPrimaryDOB" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Driver's License #</label>
                                                <input type="text" placeholder="Driver's License #" class="form-control" runat="server" id="txtPrimaryDrivers" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Email</label>
                                                <input type="text" placeholder="Email" class="form-control" runat="server" id="txtPrimaryEmail" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- Secondary Applicant Form-->

                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Spouse/Other Adult</h3>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <label class="form-control-label">First Name</label>
                                                <input type="text" placeholder="First Name" class="form-control" runat="server" id="txtSecondaryFirstName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Last Name</label>
                                                <input type="text" placeholder="Last Name" class="form-control" runat="server" id="txtSecondaryLastName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Phone</label>
                                                <input type="text" placeholder="Phone" class="form-control" runat="server" id="txtSecondaryPhone" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Social Security #</label>
                                                <input type="text" placeholder="Social Security #" class="form-control" runat="server" id="txtSecondarySocial" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Date of Birth</label>
                                                <input type="date" placeholder="Date of Birth" class="form-control" runat="server" id="txtSecondaryDOB" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Driver's License #</label>
                                                <input type="text" placeholder="Driver's License #" class="form-control" runat="server" id="txtSecondaryDrivers" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Email</label>
                                                <input type="text" placeholder="Email" class="form-control" runat="server" id="txtSecondaryEmail" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!--Other Occupants-->
                                <div class="col-lg-12">
                                    <div class="card">
                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4 col-lg-11">Other Occupants</h3>
                                            <div class="col-lg-1 text-right" onclick='Copy("div.occupantRow:last","div.occupantRow:last")'><i class="fa fa-plus-circle text-blue"></i></div>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group row occupantRow">
                                                <label class="col-sm-1 form-control-label">Name</label>

                                                <div class="col-sm-5">
                                                    <input type="text" placeholder="Name" class="form-control form-control-success" />
                                                </div>
                                                <label class="col-sm-1 form-control-label">Date of Birth</label>
                                                <div class="col-sm-5">
                                                    <input type="text" placeholder="Date of Birth" class="form-control form-control-success" />
                                                </div>
                                                <input type="hidden" value="1" />
                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <!--Emploment History-->
                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Employment History - Primary Applicant</h3>
                                            <div class="col-lg-1 text-right" onclick='Copy("div.primaryApplicantEmpHisRow:last","div.primaryApplicantEmpHisRow:last")'><i class="fa fa-plus-circle text-blue"></i></div>
                                        </div>
                                        <div class="card-body">
                                            <div class="primaryApplicantEmpHisRow">
                                                <div class="form-group">
                                                    <label class="form-control-label">Current Company Name</label>
                                                    <input type="text" placeholder="Current Company Name" class="form-control" runat="server" id="txtEmpPrimaryCompName" />
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-control-label">Address</label>
                                                    <input type="text" placeholder="Address" class="form-control" runat="server" id="txtEmpPrimaryAddress" />
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-control-label">Phone</label>
                                                    <input type="text" placeholder="Phone" class="form-control" runat="server" id="txtEmpPrimaryPhone" />
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-control-label">Start-End Date</label>
                                                    <input type="text" placeholder="Start-End Date" class="form-control" runat="server" id="txtEmpPrimaryEmploymentDates" />
                                                </div>
                                                <div class="form-group">
                                                    <label class="form-control-label">Gross Monthly Income</label>
                                                    <input type="text" placeholder="Gross Monthly Income" class="form-control" runat="server" id="txtEmpPrimaryGross" />
                                                </div>
                                                <input type="hidden" value="1" />
                                            </div>

                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Employment History - Spouse/Other</h3>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <label class="form-control-label">Current Company Name</label>
                                                <input type="text" placeholder="Current Company Name" class="form-control" runat="server" id="txtEmpOtherCompName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Address</label>
                                                <input type="text" placeholder="Address" class="form-control" runat="server" id="txtEmpOtherAddress" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Phone</label>
                                                <input type="tel" placeholder="Phone" class="form-control" runat="server" id="txtEmpOtherPhone" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Start-End Date</label>
                                                <input type="text" placeholder="Start-End Date" class="form-control" runat="server" id="txtEmpPrimaryOtherDates" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Gross Monthly Income</label>
                                                <input type="text" placeholder="Gross Monthly Income" class="form-control" runat="server" id="txtEmpOtherGross" />
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <!--Address History-->
                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Address History - Primary</h3>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <label class="form-control-label">Present Address</label>
                                                <input type="text" placeholder="Present Address" class="form-control" runat="server" id="txtHistoryPrimaryAdd" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">City/State/Zip</label>
                                                <input type="text" placeholder="City/State/Zip" class="form-control" runat="server" id="txtHistoryPrimaryCity" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Landlord/Company Name & Phone</label>
                                                <input type="text" placeholder="Landlord/Company Name & Phone" class="form-control" runat="server" id="txtHistoryPrimaryName" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Start-End Date</label>
                                                <input type="text" placeholder="Start-End Date" class="form-control" runat="server" id="txtHisPrimaryDateRange" />
                                            </div>

                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-6">
                                    <div class="card">

                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4">Address History - Spouse/Other</h3>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <label class="form-control-label">Present Address</label>
                                                <input type="text" placeholder="Present Address" class="form-control" runat="server" id="Text1" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">City/State/Zip</label>
                                                <input type="text" placeholder="City/State/Zip" class="form-control" runat="server" id="Text2" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Landlord/Company Name & Phone</label>
                                                <input type="text" placeholder="Landlord/Company Name & Phone" class="form-control" runat="server" id="Text3" />
                                            </div>
                                            <div class="form-group">
                                                <label class="form-control-label">Start-End Date</label>
                                                <input type="text" placeholder="Start-End Date" class="form-control" runat="server" id="Text4" />
                                            </div>

                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-12">
                                    <div class="card">
                                        <div class="card-header d-flex align-items-center">
                                            <h3 class="h4 col-lg-11">Pets </h3>
                                            <div class="col-lg-1 text-right" onclick='Copy("div.petRow:last","div.petRow:last")'><i class="fa fa-plus-circle text-blue"></i></div>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group row petRow">

                                                <label class="col-sm-2 form-control-label">Type</label>

                                                <div class="col-sm-2">
                                                    <input type="text" placeholder="Type" class="form-control form-control-success" />
                                                </div>
                                                <label class="col-sm-2 form-control-label">Breed</label>
                                                <div class="col-sm-2">
                                                    <input type="text" placeholder="Breed" class="form-control form-control-success" />
                                                </div>
                                                <label class="col-sm-2 form-control-label">Deposit</label>
                                                <div class="col-sm-2">
                                                    <input type="text" placeholder="Deposit" class="form-control form-control-success" />
                                                </div>
                                                <input type="hidden" value="1" />
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="col-sm-12 text-right">
                                    <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" Text="Submit" /></div>
                            </div>
                        </div>

                    </section>

                </div>

            </div>
        </div>
        <asp:HiddenField ID="hdVehicles" runat="server" />
        <asp:HiddenField ID="hdPets" runat="server" />
        <asp:HiddenField ID="hdOccupants" runat="server" />
        <asp:HiddenField ID="hdAddHistory" runat="server" />
        <asp:HiddenField ID="hdEmpHistoryPrimary" runat="server" />

        <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
        <script src="vendor/popper.js/umd/popper.min.js"> </script>
        <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
        <script src="js/apply.js"></script>

    </form>
</body>
</html>

