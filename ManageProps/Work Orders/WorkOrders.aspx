<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WorkOrders.aspx.cs" Inherits="ManageProps.Work_Orders.WorkOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     

        <section class=" no-padding-bottom">
        <div class="container-fluid">
            <div class="card">
              
                <div class="card-body">
                   

                    <div class="table-responsive">
                        <table id="tblWorkOrders" style="width:100%" class="table table-hover">
                              <thead>
                                <tr>
                                    <th>workOrderID</th>
                                    <th>approvedBy</th>
                                    <th>approveDate</th>
                                    <th>maintenceRequestID</th>
                                    <th>currentStatus</th>
                                    <th>notes</th>
                                    <th>orderStarted</th>
                                    <th>orderFinished</th>
                                </tr>
                            </thead>
                            <tbody>
                              <tr>
                                  <td>5</td>
                                  <td>5</td>
                                  <td>12/12/17</td>
                                  <td>3</td>
                                  <td>pending</td>
                                  <td>12/12/17</td>
                                  <td>12/12/17</td>
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
            var dataTable = $('#tblWorkOrders').DataTable(
                {
                    "ajax": {
                        url: requestDataSource,
                        dataSrc: 'allWorkOrders',
                        "type": "GET"},
                    columns: [
                        { data: 'WorkOrderID' },
                        { data: 'ApprovedBy' },
                        { data: 'ApproveDate' },
                        { data: 'MaintenceRequestID' },
                        { data: 'CurrentStatus' },
                        { data: 'Notes' },
                        { data: 'OrderStarted' },
                        { data: 'OrderFinished' }
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
                window.location.href = 'WorkOrderDetails.aspx?WorkOrderID=' + rowInfo.WorkOrderID;
            });
           
        });
    </script>
</asp:Content>
