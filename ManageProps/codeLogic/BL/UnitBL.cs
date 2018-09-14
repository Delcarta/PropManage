using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for UnitBL
/// </summary>
public class UnitBL
{
    public UnitBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddUnit(UnitModel unitInfoIn)
    {
        UnitDAL unitSav = new UnitDAL();
        unitSav.AddNewUnit(unitInfoIn);
    }
}