using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using ManageProps.codeLogic.dal;
using ManageProps.codeLogic.DataModels;

namespace ManageProps.codeLogic.BL
{
    public class SettingsBL
    {
        #region Custom Fields
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="propertyID"></param>
        /// <param name="companyID"></param>
        public void SaveCustomFields(string fields, int propertyID, int companyID)
        {
            StringBuilder fieldSB = new StringBuilder();
            SettingsDAL setDAL = new SettingsDAL();
            setDAL.SaveCustomFields(fields, propertyID, companyID);
        }

        public string GetCustomFields(int propID)
        {
            SettingsDAL setDAL = new SettingsDAL();
            return setDAL.GetCustomFields(propID);
        }


        #endregion
    }
}