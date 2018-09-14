using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for dalBase
/// </summary>
public abstract class dalBase
{
    protected ConnectionStringSettings connStr;
    protected dalBase()
    {
        if (System.Diagnostics.Debugger.IsAttached)
            connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["LocalData"];
        else
            connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["PropData"];
    }

    protected DataTable GetDataTable(SqlCommand theCommand)
    {
        SqlConnection theConnection = new SqlConnection(connStr.ConnectionString);
        theCommand.Connection = theConnection;
        SqlDataAdapter daFiller = new SqlDataAdapter(theCommand);

        theConnection.Open();
        DataTable results = new DataTable();
        daFiller.Fill(results);
        theConnection.Close();
        theConnection.Dispose();
        return results;
    }

    //protected int ExecuteScalar(SqlCommand theCommand)
    //{
    //    using (SqlConnection theConnection = new SqlConnection(connStr.ConnectionString))
    //    {
    //        theConnection.Open();
    //        theCommand.Connection = theConnection;
    //        return (int)theCommand.ExecuteScalar();
    //    }
    //}

    protected object ExecuteScalar(SqlCommand theCommand)
    {
        using (SqlConnection theConnection = new SqlConnection(connStr.ConnectionString))
        {
            theConnection.Open();
            theCommand.Connection = theConnection;
            return theCommand.ExecuteScalar();
        }
    }

    protected int ExecuteNonQuery(SqlCommand theOrder)
    {
        using (SqlConnection theConnection = new SqlConnection(connStr.ConnectionString))
        {
            theConnection.Open();
            theOrder.Connection = theConnection;
            return theOrder.ExecuteNonQuery();
        }
    }

}