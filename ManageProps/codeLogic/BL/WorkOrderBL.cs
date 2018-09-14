using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ManageProps.codeLogic.dal;

namespace ManageProps.codeLogic.BL
{
    public class WorkOrderBL
    {
        public WorkOrderBL()
        { }

        public void CreateWorkOrder(WorkOrderModel orderModel)
        {
            WorkOrderDAL workOrder = new WorkOrderDAL();
            workOrder.CreateWorkOrder(orderModel);
        }

        public DataTable GetWorkOrder(int workOrderID)
        {
            return new WorkOrderDAL().GetWorkOrder(workOrderID);
        }

        public void UpdateWorkOrder(WorkOrderModel orderModel)
        {
            new WorkOrderDAL().UpdateWorkOrder(orderModel);
        }
    }
}