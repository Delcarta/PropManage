using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PropertyModel
/// </summary>
public class PropertyModel : CoreModel
{
    public PropertyModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int PropertyID { get; set; }
    public int CompanyID { get; set; }
    public string PropertyName { get; set; }
    public string ContactPerson { get; set; }
}