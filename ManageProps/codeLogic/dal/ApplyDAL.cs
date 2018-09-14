using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for apply
/// </summary>
public class ApplyDAL : dalBase
{
    public ApplyDAL() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void StoreApplicationData(ApplicationResidentApplication appInfo, List<ApplicationApplicant> applicantsInfo, List<ApplicationPets> petInfo, List<ApplicationOccupants> othersInfo)
    {
        int AppID = CreateApp(appInfo);
        StoreApplicants(applicantsInfo, AppID);
    }

    private int CreateApp(ApplicationResidentApplication app)
    {
        SqlCommand cmd = new SqlCommand("insert into Application values (@applicants, @occupants, @pets, @vehicles, @propertyid); SELECT CAST(scope_identity() AS int);");
        cmd.Parameters.Add("@applicants", SqlDbType.Int).Value = app.Applicants;
        cmd.Parameters.Add("@occupants", SqlDbType.Int).Value = app.Occupants;
        cmd.Parameters.Add("@pets", SqlDbType.Int).Value = app.Pets;
        cmd.Parameters.Add("@vehicles", SqlDbType.Int).Value = app.Vehicles;
        cmd.Parameters.Add("@propertyid", SqlDbType.Int).Value = 1;

        return (int)ExecuteScalar(cmd);
    }

    private void StoreApplicants(List<ApplicationApplicant> applicants, int ApplyID)
    {

    }

    private void StorePets()
    { }

    private void StoreOccupants()
    { }
}