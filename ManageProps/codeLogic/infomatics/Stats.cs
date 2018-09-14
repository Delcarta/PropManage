using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Stats
/// </summary>
public abstract class Stats
{
    protected int _Applications;
    public int Applications
    {
        get { return _Applications; }
    }

    public Stats()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}