using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class MaintenceRequestModel
    {
        public int RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestDetails { get; set; }
        public int UserID { get; set; }
        public int UnitID { get; set; }
        public int ResidentID { get; set; }
        public int PropertyID { get; set; }

    }
