<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MaintenceRequest.aspx.cs" Inherits="ManageProps.Maintence.MaintenceRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 

        <section class=" no-padding-bottom">
        <div class="container-fluid">
            <div class="card">
              
                <div class="card-body">
                    <div class="row">
                        <a href="addMaintenceRequest.aspx" runat="server" class="btn btn-primary" >Add Request</a>
                    </div>

                    <div class="table-responsive">
                        <table id="tblRequests" style="width:100%" class="table table-hover">
                              <thead>
                                <tr>
                                    <th>RequestID</th>
                                    <th>RequestDate</th>
                                    <th>RequestDetails</th>
                                    <th>UserID</th>
                                    <th>UnitID</th>
                                    <th>ResidentID</th>
                                    <th>PropertyID</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>4</td>
                                    <td>12/12/2014</td>
                                    <td>suckage</td>
                                    <td>1</td>
                                    <td>1</td>
                                    <td>1</td>
                                    <td>1</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
               
            </div>
        </div>

            </section>
    <input type="hidden" runat="server" id="hdRequestData" />

     <script src="../vendor/datatables.net/js/jquery.dataTables.js"></script>
    <script src="../vendor/datatables.net-bs4/js/dataTables.bootstrap4.js"></script>
    <script src="../vendor/datatables.net-responsive/js/dataTables.responsive.min.js"></script>
    <script src="../vendor/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js"></script>
    <script type="text/javascript" >
        $(function () {
            var requestDataSource = $('#<%= hdRequestData.ClientID%>').val();
            var dataTable = $('#tblRequests').DataTable(
                {
                    "ajax": {
                        url: requestDataSource,
                        dataSrc: 'allMaintenceRequest',
                        "type": "GET"},
                    columns: [
                        { data: 'RequestID' },
                        { data: 'RequestDate' },
                        { data: 'RequestDetails' },
                        { data: 'UserID' },
                        { data: 'UnitID' },
                        { data: 'ResidentID' },
                        { data: 'PropertyID' }
                    ]
                }
            );

            $(document).on('sidebarChanged', function () {
                dataTable.columns.adjust();
                dataTable.responsive.recalc();
                dataTable.responsive.rebuild();
            });

            dataTable.on('click', 'tr', function () {
                var rowInfo = dataTable.row(this).data();
                window.location.href = 'ReviewRequest.aspx?requestID=' + rowInfo.RequestID;
            });
           
        });
    </script>
</asp:Content>

