<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addMaintenceRequest.aspx.cs" Inherits="ManageProps.Maintence.addMaintenceRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
        <div class="page-content d-flex align-items-stretch">
            <section class="forms col-lg-12">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="card">

                                <div class="card-header d-flex align-items-center">
                                    <h3 class="h4">Add A Request</h3>
                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <label class="form-control-label">Unit ID</label>
                                        <input type="text" placeholder="Unit Lot #" class="form-control" runat="server" id="txtUnitID" />
                                    </div>

                                    <div class="form-group">
                                        <label class="form-control-label">Issue</label>
                                        <textarea placeholder="Issue" class="form-control form-control-lg" runat="server" id="txtIssue" />
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 text-right">
                            <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" Text="Submit" /></div>

                    </div>
                </div>
            </section>
        </div>
</asp:Content>
