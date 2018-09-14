using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageProps.codeLogic.DataModels
{
    public class CustomFieldModel
    {

        public fieldDetails field;

        public CustomFieldModel()
        {

        }
    }

    public class fieldDetails
    {
        public string fieldName { get; set; }
        public char fieldType { get; set; }
    }
}

