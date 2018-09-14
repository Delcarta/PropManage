using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CoreModel
/// </summary>
public abstract class CoreModel
{
    public CoreModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}