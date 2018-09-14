using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class WorkOrderModel
    {
        public int WorkOrderID;
        public int ApprovedBy;
        public DateTime ApprovedDate;
        public int MaintenceRequestID;
        public string CurrentStatus;
        public string Notes;
        public DateTime OrderStarted;
        public DateTime OrderFinished;
        private DateTime _promise;
        public DateTime? PromiseDate
        {
            get
            {
                if (_promise == DateTime.MinValue)
                    return null;
                else
                    return _promise;
            }
            set
            {
                _promise = value ?? DateTime.MinValue;
            }
        }
    }
