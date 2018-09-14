<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Residents.aspx.cs" Inherits="ManageProps.Residents.Residents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <section class=" no-padding-bottom">
        <div class="container-fluid">
            <div class="card">
              
                <div class="card-body">
                   

                    <div class="table-responsive">
                        <table id="tblResidents" style="width:100%" class="table table-hover">
                              <thead>
                                <tr>
                                    <th>residentID</th>
                                    <th>unitId</th>
                                    <th>moveInDate</th>
                                    <th>moveOutDate</th>
                                    <th>firstName</th>
                                    <th>lastName</th>
                                    <th>email</th>
                                    <th>phone</th>
                                    <th>birthday</th>
                                    <th>middleName</th>
                                    <th>propertyID</th>
                                </tr>
                            </thead>
                            <tbody>
                              <tr>
                                  <td>5</td>
                                  <td>5</td>
                                  <td>12/12/17</td>
                                  <td>12/12/17</td>
                                  <td>Mickey</td>
                                  <td>Mouse</td>
                                  <td>mm@mouse.com</td>
                                  <td>6542147856</td>
                                  <td>12/12/17</td>
                                  <td>Pest</td>
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
            var dataTable = $('#tblResidents').DataTable(
                {
                    "ajax": {
                        url: requestDataSource,
                        dataSrc: 'allResidents',
                        "type": "GET"},
                    columns: [
                        { data: 'ResidentID' },
                        { data: 'UnitID' },
                        { data: 'MoveInDate' },
                        { data: 'MoveOutDate' },
                        { data: 'FirstName' },
                        { data: 'LastName' },
                        { data: 'Email' },
                        { data: 'Phone' },
                        { data: 'Birthday' },
                        { data: 'MiddleName' },
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
                window.location.href = 'ResidentDetails.aspx?ResidentID=' + rowInfo.ResidentID;
            });
           
        });
    </script>
</asp:Content>
