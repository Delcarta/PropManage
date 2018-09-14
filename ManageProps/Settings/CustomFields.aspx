<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomFields.aspx.cs" Inherits="ManageProps.Settings.CustomFields" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="page-content d-flex align-items-stretch">
      <section class="forms col-lg-12">
                    <div class="card">
                        <div class="card-header d-flex align-items-center">
                            <h3 class="h4 col-lg-11">Add / Edit Fields </h3><div class="col-lg-1 text-right" onclick='Copy("div.fieldRowTemplate:first","#currentFields")'>
                                <label id="fieldCount" >0</label>/50
                                <input type="button" class="btn btn-primary" value="Add Field" /></div>
                        </div>
                        <div class="card-body">
                            <div style="display:none">
                            <div class="form-group row fieldRowTemplate" >
                                <input type="hidden" id="fieldIndex" />
                                <label style="width:5px;" id="lblCount"></label>
                                <label class="col-sm-1 form-control-label">Field Name</label>
                                
                                <div class="col-sm-2">
                                    <input type="text" id="fieldName" placeholder="Field Name" class="form-control form-control-success" />
                                </div>
                                <label class="col-sm-1 form-control-label">Field Type</label>
                                <div class="col-sm-1">
                                    <select data-style="btn-primary" class="selectpicker">
                                      <option value="0" selected>Select</option>
                                      <option value="T">Text</option>
                                      <option value="N">Number</option>
                                      <option value="D">Decimal</option>
                                    </select>
                                </div>
                                <div class="col-lg-1 text-right removeField"><i class="fa fa-close fa-2x text-red"></i></div>
                                <input type="hidden" value="1" />
                            </div>
                                </div>
                            <div id="currentFields">


                            </div>
                        </div>
                    </div>
          <div class="col-sm-12 text-right"><asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" Text="Save" /></div>
                </section>
         </div>
    
    <input type="hidden" id="hdCustomFields" runat="server" />

    <script type="text/javascript">
        $(document).ready(function () {
            $("div.fieldRowTemplate input").blur(function () {
                StoreFields(this);
            });

            $("div.fieldRowTemplate .selectpicker").change(function () {
                StoreFields(this);
            });

            $(".removeField").click(function () { $(this).closest('div.fieldRowTemplate').remove(); });

            LoadFields();
        });

        function Copy(CopyFrom, CopyTo) {
            var theClone = $(CopyFrom).clone(true, true).appendTo(CopyTo);
            var currentFieldCount = parseInt($('#fieldCount').html());
            theClone.find('input').not(':button, :submit, :reset, :hidden').val('');
            $('#fieldCount').html(currentFieldCount + 1);
        }

        function StoreFields(fieldBox) {

            var fieldID = '#<%= hdCustomFields.ClientID %>';
            var fieldIndex = $(fieldBox).closest('div.fieldRowTemplate').find('#fieldIndex').val();
            var name = $(fieldBox).closest('div.fieldRowTemplate').find('#fieldName').val();
            var fieldType = $(fieldBox).closest('div.fieldRowTemplate').find('.selectpicker');
            var selectedFieldType = fieldType[0].value;

            if (name != "" && selectedFieldType != "0") {
                //Get existing json
                var existingFieldJson = $(fieldID).val();
                if (existingFieldJson.length == 0) {
                    //no other occupants. overwrite
                    var aField = { "fieldName": name, "fieldType": selectedFieldType, "index": 1 }
                    var fieldList = [aField];
                    $(fieldBox).closest('div.fieldRowTemplate').find('#fieldIndex').val(1)
                    $(fieldID).val(JSON.stringify(fieldList));
                }
                else {
                    //existing occupants. add.
                    var fieldList = JSON.parse(existingFieldJson);
                    fieldList = $.grep(fieldList, function (box, i) { return box.index != fieldIndex; });
                    var currIndex = AssignIndex(fieldIndex);
                    var aField = { "fieldName": name, "fieldType": selectedFieldType, "index": currIndex }
                    $(fieldBox).closest('div.fieldRowTemplate').find('#fieldIndex').val(currIndex);
                    fieldList.push(aField);
                    $(fieldID).val(JSON.stringify(fieldList));
                }
            }
        }

        function LoadFields()
        {
            var fieldID = '#<%= hdCustomFields.ClientID %>';
            var existingFieldJson = $(fieldID).val();
            if (existingFieldJson.length > 0)
            {
                var fieldList = JSON.parse(existingFieldJson);
                $(fieldList).each(
                    function (index)
                    {
                        var theClone = $("div.fieldRowTemplate:first").clone(true, true).appendTo("#currentFields");
                        theClone.find('#fieldName').val(this.fieldName);
                        theClone.find('.selectpicker').val(this.fieldType);
                        theClone.find('#fieldIndex').val(this.index);

                        var currentFieldCount = parseInt($('#fieldCount').html());
                        $('#fieldCount').html(currentFieldCount + 1);
                    }
                );
                
            }
            
        }

        function AssignIndex(existingIndex)
        {
            if (existingIndex)
            {
                return existingIndex;
            }
            else
            {
                var currentFieldCount = parseInt($('#fieldCount').html());
                return currentFieldCount;
            }
        }
    </script>
</asp:Content>
