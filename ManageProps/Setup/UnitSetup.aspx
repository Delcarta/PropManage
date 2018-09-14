<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UnitSetup.aspx.cs" Inherits="ManageProps.Setup.UnitSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="content-inner">
          <header class="page-header">
            <div class="container-fluid">
              <h2 class="no-margin-bottom">Unit Info</h2>
            </div>
          </header>
        <div class="page-content d-flex align-items-stretch">
             <section class="forms col-lg-12">
                <div class="container-fluid">
                    <div class="row">
                         <div class="col-lg-6">
                  <div class="card">
                  
                    <div class="card-header d-flex align-items-center">
                      <h3 class="h4">Add A Unit(s)</h3>
                    </div>
                    <div class="card-body">
                        <div class="form-group">
                          <label class="form-control-label">Unit Lot #</label>
                          <input type="text" placeholder="Unit Lot #" class="form-control" runat="server" id="txtLotNum"/>
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

