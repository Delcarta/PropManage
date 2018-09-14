using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PropertyBL
/// </summary>
public class PropertyBL
{
    private DataTable _PropertyInfo;


    public PropertyBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public PropertyBL(DataTable info)
    {
        _PropertyInfo = info;
    }

    public void AddProperty(PropertyModel prop)
    {
        PropertyDAL propDal = new PropertyDAL();
        propDal.AddNewProperty(prop);
    }

    /// <summary>
    /// Gets last property from a list of properties owned by company
    /// </summary>
    /// <returns>int</returns>
    public int GetLastPropertyID()
    {
        //id's of properties should be sequential
        if (_PropertyInfo != null)
            return (int)_PropertyInfo.Rows[_PropertyInfo.Rows.Count - 1]["PropertyID"];
        else
            return 0;
    }
}