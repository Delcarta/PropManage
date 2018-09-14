using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CompanyModel
/// </summary>
public class CompanyModel : CoreModel
{
    public CompanyModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int CompanyID { get; set; }
    public string CompanyName { get; set; }
    public string DBAName { get; set; }
    public int UserID { get; set; }

}