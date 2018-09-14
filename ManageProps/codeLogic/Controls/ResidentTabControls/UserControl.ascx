<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="ManageProps.codeLogic.Controls.ResidentTabControls.UserControl" %>

<div style="display: none">
    <div class="form-group row fieldRowTemplate">
        <input type="hidden" id="fieldIndex" />
        
        <label id="lblFieldName" class="col-sm-1 form-control-label">Field Name</label>

     
        <input type="text" id="txtFieldValue" />
        <input type="hidden" id="hdFieldType" value="1" />
    </div>
</div>

<div id="fieldBox">
</div>

<asp:HiddenField runat="server" ID="hdResidentFieldValues" />
<script type="text/javascript">
    $(document).ready(
        function ()
        {
            WriteFields();

            $("input#txtFieldValue").blur(function () { SaveValue(this)});
        });
   
    function WriteFields()
    {
        var fieldID = '#<%= hdResidentFieldValues.ClientID %>';
        var fields = $(fieldID).val();
        if (fields.length > 0)
        {
            var theFields = JSON.parse(fields);
            $(theFields).each(function (index)
            {
                var theClone = $("div.fieldRowTemplate:first").clone(true, true).appendTo("#fieldBox");
                theClone.find('#lblFieldName').html(this.fieldName);
                theClone.find('#txtFieldValue').val(this.fieldValue);
                theClone.find('#fieldIndex').val(this.index);
                theClone.find('#hdFieldType').val(this.fieldType);
            });
        }
        else
        {
            $('#fieldBox').html("There are no fields to display.")
        }
    }

    function SaveValue(textBox)
    {
        var fieldID = $(textBox).closest('div.fieldRowTemplate').find('#fieldIndex').val();
        var theFields = JSON.parse($('#<%= hdResidentFieldValues.ClientID %>').val());
        $(theFields).each(function (index, fields)
        {
            if (fields.index == fieldID)
            {
                fields.fieldValue = textBox.value;
            }
        });

        $('#<%= hdResidentFieldValues.ClientID %>').val(JSON.stringify(theFields));
    }
</script>
