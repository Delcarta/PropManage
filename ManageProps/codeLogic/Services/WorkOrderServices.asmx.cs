using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using ManageProps.codeLogic.DataModels;

namespace ManageProps.codeLogic.Services
{
    /// <summary>
    /// Summary description for WorkOrderServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WorkOrderServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetWorkOrders(int propertyID)
        {
            using (var context = new LocalPropManageEntities())
            {
                var WorkOrders = (from wo in context.WorkOrders
                                  join u in context.Users on wo.ApprovedBy equals u.UserID
                                  where wo.OrderFinished == null
                                  where (from m in context.MaintenceRequests
                                         where m.PropertyID == propertyID
                                         select m.RequestID).Contains(wo.MaintenceRequestID)
                                  select new {wo.WorkOrderID,
                                                ApprovedBy = string.Concat(u.FirstName, " ", u.LastName),
                                                wo.ApproveDate, wo.MaintenceRequestID, wo.CurrentStatus,
                                                wo.Notes, wo.OrderStarted, wo.OrderFinished}

                                  ).ToList();

                dynamic workOrdersWrapper = new { allWorkOrders = WorkOrders };
                Context.Response.Write(JsonConvert.SerializeObject(workOrdersWrapper, Formatting.Indented));


            }
        }

    }
}
