<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Breadcrumb.ascx.cs" Inherits="ManageProps.codeLogic.Controls.Breadcrumb" %>
<style>
    .crumbspacer
    {
        margin: 0 3px 0 3px;
    }
</style> 
<!-- Breadcrumb-->
          <div class="breadcrumb-holder container-fluid">
<ul class="breadcrumb">
<asp:SiteMapPath ID="SiteMapPath1" Runat="server"
        ParentLevelsDisplayed="2" 
        PathDirection="RootToCurrent" 
        ShowToolTips="true">
        <NodeTemplate>
            <li class="breadcrumb-item">
                <asp:HyperLink
                    id="lnkPage"
                    Text='<%# Eval("Title") %>'
                    NavigateUrl='<%# Eval("Url") %>'
                    ToolTip='<%# Eval("Description") %>'
                    Runat="server"
                 />
            </li>
        </NodeTemplate>
    <PathSeparatorTemplate><span class="crumbspacer">/</span></PathSeparatorTemplate>
    <CurrentNodeTemplate>
                        <li class="breadcrumb-item active"><%# Eval("Title") %></li>
                </CurrentNodeTemplate>
 </asp:SiteMapPath>
 </ul>
</div>