using ManageProps.codeLogic.dal;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
namespace ManageProps.codeLogic.BL
{
    public class ResidentBL
    {
        public ResidentBL()
        { }

        public string GetCustomFieldValues(int ResidentID, int PropertyID)
        {
            string values =  new ResidentDAL().GetResidentCustomFieldValues(ResidentID);
            string availableFields = new SettingsBL().GetCustomFields(PropertyID);

            if (!string.IsNullOrEmpty(values) && !string.IsNullOrEmpty(availableFields))
            {
                Dictionary<int, string> residentFieldValues = values.Split(new char[]{','}, System.StringSplitOptions.RemoveEmptyEntries)
                                                                .Select(part => part.Split(':'))
                                                                .ToDictionary(split => int.Parse(split[0]), split => split[1]);
                JArray fields = JArray.Parse(availableFields);

                return CombineFieldsAndValues(fields, residentFieldValues);
            }
            else if (!string.IsNullOrEmpty(availableFields))
            {
                JArray fields = JArray.Parse(availableFields);
                return ReturnFields(fields);
            }
            else
            {
                return "";
            }
            

        }

        public void SaveCustomFieldValues(string incomingFields, int ResidentID)
        {
            string fieldsToSave = ExtractFieldIdValuePairs(incomingFields);
            if(!string.IsNullOrWhiteSpace(fieldsToSave))
            new ResidentDAL().SaveResidentCustomFieldValues(fieldsToSave, ResidentID);
        }

        private string ExtractFieldIdValuePairs(string fields)
        {
            JArray jFields = JArray.Parse(fields);
            Dictionary<int, string> fieldsToInsert = new Dictionary<int, string>();
            foreach (JToken field in jFields.Children())
            {
                
                string currValue = field["fieldValue"].ToString();
                if (!string.IsNullOrWhiteSpace(currValue))
                {
                    fieldsToInsert.Add(int.Parse(field["index"].ToString()), currValue);
                }
            }
            return string.Join(",", fieldsToInsert.Select(x => string.Format("{0}:{1}", x.Key, x.Value)));
        }

        private string CombineFieldsAndValues(JArray fields, Dictionary<int, string> values)
        {
            foreach (JToken field in fields.Children())
            {
                    field["fieldValue"] = values.Where(x => x.Key == (int)field["index"]).FirstOrDefault().Value;
            }
            return fields.ToString();
        }

        private string ReturnFields(JArray fields)
        {
            
            foreach (JToken child in fields.Children())
            {
                child["fieldValue"] = "";
            }

            return fields.ToString();
        }
    }

    
}