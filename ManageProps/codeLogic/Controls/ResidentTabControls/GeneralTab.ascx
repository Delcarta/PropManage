<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GeneralTab.ascx.cs" Inherits="ManageProps.codeLogic.Controls.ResidentTabControls.GeneralTab" %>
<div class="row">
    <div class="form col-lg-6">
        <label class="form-control-label font-weight-bold">Account Info</label>
        <div class="form-group">
            <label class="form-control-label">Primary Account Name</label>
            <asp:TextBox runat="server" ID="txtPrimanyName" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>

        <label class="form-control-label font-weight-bold">Rental Info</label>
        <div class="form-group">
            <label class="form-control-label">Property</label>
            <asp:DropDownList runat="server" ID="ddlPropertySelect" CssClass="form-control"  ></asp:DropDownList>
        </div>

        <label class="form-control-label font-weight-bold">Addresses</label>
        <div class="form-group">
            <label class="form-control-label">Property</label>
            <input class="form-control" value="datatable here" />
        </div>
    </div>

    <div class="form col-lg-3">

        <label class="form-control-label font-weight-bold">Unit</label>
        <div class="form-group">
            <label class="form-control-label">Unit</label>
            <asp:DropDownList runat="server" ID="ddlUnit" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label class="form-control-label">Move-In</label>
            <input class="form-control" type="text" />
        </div>
        <div class="form-group">
            <label class="form-control-label">Move-Out</label>
            <input class="form-control" type="text" />
        </div>
        <div class="form-group">
            <label class="form-control-label">Notice</label>
            <input class="form-control" type="text" />
        </div>
        <div class="form-group">
            <label class="form-control-label">Expected MO</label>
            <input class="form-control" type="text" />
        </div>
    </div>
    <div class="form col-lg-3">
        <label>&nbsp;</label>
        <div class="form-group">
            <label class="form-control-label">Lease Sign</label>
            <input type="text" />

        </div>
        <div class="form-group">
            <label class="form-control-label">Lease Start</label>
            <input type="text" />

        </div>
        <div class="form-group">
            <label class="form-control-label">Lease End</label>
            <input type="text" />

        </div>
    </div>


</div>
