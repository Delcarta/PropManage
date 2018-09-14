using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CompanyBL
/// </summary>
public class CompanyBL
{
    private DataTable _CompanyInfo;

    public CompanyBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public CompanyBL(DataTable info)
    {
        _CompanyInfo = info;
    }

    public void AddCompany(CompanyModel comp)
    {
        CompanyDAL compDal = new CompanyDAL();
        compDal.AddNewCompany(comp);
    }
}