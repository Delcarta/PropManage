using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UnitDAL
/// </summary>
public class UnitDAL : dalBase
{
    public UnitDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddNewUnit(UnitModel unitInfo)
    {
        SqlCommand cmd = new SqlCommand("Insert into units values (@LotNum, @add1, @add2, @zip, @propID);");
        cmd.Parameters.Add("@LotNum", SqlDbType.Int).Value = unitInfo.UnitLotNum;
        cmd.Parameters.Add("@propID", SqlDbType.Int).Value = unitInfo.PropertyID;
        cmd.Parameters.Add("@add1", SqlDbType.VarChar, 60).Value = unitInfo.Address1;
        cmd.Parameters.Add("@add2", SqlDbType.VarChar, 60).Value = unitInfo.Address2;
        cmd.Parameters.Add("@zip", SqlDbType.VarChar, 60).Value = unitInfo.Zip;

        ExecuteNonQuery(cmd);
    }

    
}