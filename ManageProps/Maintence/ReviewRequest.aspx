<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ReviewRequest.aspx.cs" Inherits="ManageProps.Maintence.ReviewRequest" %>
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
                                    <h3 class="h4">Review Details</h3>
                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <label class="form-control-label">Unit ID</label>
                                        <input type="text" placeholder="Unit Lot #" readonly class="form-control" runat="server" id="txtUnitID" />
                                    </div>

                                    <div class="form-group">
                                        <label class="form-control-label">Issue</label>
                                        <textarea placeholder="Issue" readonly class="form-control form-control-lg" runat="server" id="txtIssue" />
                                    </div>
                                   
                                    <div class="form-group">
                                        <label class="form-control-label">Notes</label>
                                        <textarea placeholder="Notes" class="form-control form-control-lg" runat="server" id="txtNotes" />
                                    </div>

                                    <div class="form-group">
                                        <label class="form-control-label">Promise Date</label>
                                        <input type="date" placeholder="Promise Date" class="form-control" runat="server" id="txtPromise" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:Button runat="server" ID="btnCreateOrder" CssClass="btn btn-primary" OnClick="btnCreateOrder_Click" Text="Create Work Order" />

                            <asp:Button runat="server" ID="btnCloseRequest" CssClass="btn btn-primary" OnClick="btnCloseRequest_Click" Text="Close Request" />

                      
                            <asp:Button runat="server" ID="btnCancel" CssClass="btn" OnClick="btnCancel_Click" Text="Cancel" />

                        </div>
                    </div>
                </div>
            </section>
        </div>
</asp:Content>
