using ManageProps.codeLogic.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.BL
{
    public class MaintenceBL
    {

        public void AddMaintenceRequest(MaintenceRequestModel requestInfoIn)
        {
            MaintenceDAL requestSav = new MaintenceDAL();
            requestSav.addMaintenceRequest(requestInfoIn);
        }

        public DataTable GetMaintenceRequest(int RequestID)
        {
            MaintenceDAL requestGet = new MaintenceDAL();
            return requestGet.GetMaintenceRequest(RequestID);
        }

        public void CloseRequest(int RequestID)
        {
            MaintenceDAL requestCL = new MaintenceDAL();
            requestCL.CloseRequest(RequestID);
        }
    }

   
}