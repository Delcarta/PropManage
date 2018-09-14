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
    /// Summary description for MaintenenceServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MaintenenceServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetMaintenenceRequests(int propertyID)
        {
            using (var context = new LocalPropManageEntities())
            {
                var maintenceRequests = (from x in context.MaintenceRequests where x.PropertyID == propertyID select x).ToList();
                dynamic MaintenceWrapper = new { allMaintenceRequest = maintenceRequests };
                Context.Response.Write(JsonConvert.SerializeObject(MaintenceWrapper, Formatting.Indented));
            }
               
        }
    }
}
