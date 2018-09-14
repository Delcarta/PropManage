<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkOrderDetails.aspx.cs" Inherits="ManageProps.Work_Orders.WorkOrderDetails" %>
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
                                    <h3 class="h4">Review Work Order Details</h3>
                                </div>
                                <div class="card-body">
                                    <div class="form-group">
                                        <label class="form-control-label">Work Order ID</label>
                                        <input type="text" placeholder="Work Order ID" readonly class="form-control" runat="server" id="txtWorkOrderID" />
                                    </div>

                                    <div class="form-group">
                                        <label class="form-control-label">Maintence Request ID</label>
                                        <input type="text" placeholder="Maintence Request ID" readonly class="form-control" runat="server" id="txtRequestID" />
                                    </div>

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
                                        <input type="text" placeholder="Promise Date" class="form-control" runat="server" id="txtPromiseDate" />
                                    </div>

                                    <div class="form-group">
                                        <label class="form-control-label">Status</label>
                                        <input type="text" placeholder="Status" class="form-control" runat="server" id="txtStatus" />
                                    </div>

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
   
</asp:Content>
