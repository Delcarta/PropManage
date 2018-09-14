using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using ManageProps.codeLogic.DataModels;
using System.Data.Entity;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ManageProps.codeLogic.Services
{
    /// <summary>
    /// Summary description for DataServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class DataServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetResidents(int propertyID)
        {

            using (var context = new LocalPropManageEntities())
            {
                var residentResults =  (from x in context.Residents
                                            select new
                                            {
                                                x.ResidentID,
                                                x.UnitID,
                                                x.MoveInDate,
                                                x.MoveOutDate,
                                                x.FirstName,
                                                x.LastName,
                                                x.Email,
                                                x.Phone,
                                                x.Birthday,
                                                x.MiddleName,
                                                x.PropertyID
                                            }
                                                       ).ToList();
                dynamic residentWrapper = new { allResidents = residentResults };
                Context.Response.Write(JsonConvert.SerializeObject(residentWrapper, Formatting.Indented));

            }
        }
    }
}
