<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompanySetup.aspx.cs" Inherits="ManageProps.Setup.CompanySetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content-full">
          <header class="page-header">
            <div class="container-fluid">
              <h2 class="no-margin-bottom">Company Info</h2>
            </div>
          </header>
        <div class="page-content d-flex align-items-stretch">
             <section class="forms col-lg-12">
                <div class="container-fluid">
                    <div class="row">
                         <div class="col-lg-6">
                  <div class="card">
                  
                    <div class="card-header d-flex align-items-center">
                      <h3 class="h4">Add Your Business Information</h3>
                    </div>
                    <div class="card-body">
                        <div class="form-group">
                          <label class="form-control-label">Company Name</label>
                          <input type="text" placeholder="Company Name" class="form-control" runat="server" id="txtCompanyName"/>
                        </div>
                        <div class="form-group">       
                          <label class="form-control-label">Doing Business As (DBA) Name</label>
                          <input type="text" placeholder="DBA Name" class="form-control" runat="server" id="txtDBA"/>
                        </div>
                       <div class="form-group">       
                          <label class="form-control-label">Address 1</label>
                          <input type="text" placeholder="Address 1" class="form-control" runat="server" id="txtAddress1"/>
                        </div>
                        <div class="form-group">       
                          <label class="form-control-label">Address 2</label>
                          <input type="text" placeholder="Address 2" class="form-control" runat="server" id="txtAddress2"/>
                        </div>
                        <div class="form-group">       
                          <label class="form-control-label">Zip</label>
                          <input type="text" placeholder="Zip" class="form-control" runat="server" id="txtZip"/>
                        </div>
                        <div class="form-group">       
                          <label class="form-control-label">Phone</label>
                          <input type="text" placeholder="Phone" class="form-control" runat="server" id="txtPhone"/>
                        </div>
                         <div class="form-group">       
                          <label class="form-control-label">Email</label>
                          <input type="text" placeholder="Email" class="form-control" runat="server" id="txtEmail"/>
                        </div>
                         
                    </div>
                  </div>
                </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 text-right"><asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" Text="Submit" /></div>

                    </div>
                </div>
             </section>
        </div>
    </div>
</asp:Content>
