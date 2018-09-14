using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for User
/// </summary>
public class UserBL
{
    private DataTable _UserInfo;
    private DataTable _CompanyInfo;
    private DataTable _PropertyInfo;

    public UserBL(DataTable UserInfo)
    {
        _UserInfo = UserInfo;
        SetAdditionalData();
    }

    private void SetAdditionalData()
    {
        if (CompanyID != 0)
        {
            CompanyDAL comp = new CompanyDAL();
            _CompanyInfo = comp.GetCompany(CompanyID);

            PropertyDAL prop = new PropertyDAL();
            _PropertyInfo = prop.GetProperties(CompanyID);
        }
    }

    public DataTable CompanyInfo
    { get { return _CompanyInfo; } }

    public DataTable PropertyInfo
    { get { return _PropertyInfo; } }
    #region UserInfo

    public int UserID
    {
        get
        {
            return (int)_UserInfo.Rows[0]["UserID"];
        }
    }
    public string FirstName
    {
        get
        {
            return (string)_UserInfo.Rows[0]["FirstName"];
        }
    }

    public string LastName
    {
        get
        {
            return (string)_UserInfo.Rows[0]["LastName"];
        }
    }

    public string Title
    {
        get
        {
            if (!DBNull.Value.Equals(_UserInfo.Rows[0]["Title"]))
                return (string)_UserInfo.Rows[0]["Title"];
            else
                return "";
        }
    }
    #endregion


    private int _CompanyID;
    public int CompanyID
    {
        get
        {
            if (_CompanyID != 0)
                return _CompanyID;

            if (IsValidUser && !DBNull.Value.Equals(_UserInfo.Rows[0]["CompanyID"]))
            {
                _CompanyID = (int)_UserInfo.Rows[0]["CompanyID"];
                return _CompanyID;
            }
            else
                return _CompanyID;
        }
    }
    public bool IsValidUser
    {
        get
        {
            if (_UserInfo.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

    public bool HasCompany
    {
        get
        {
            if (_CompanyInfo != null && _CompanyInfo.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

    public bool HasProperty
    {
        get
        {
            if (_PropertyInfo != null && _PropertyInfo.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

    public void Reload()
    {
        UserDAL userLogic = new UserDAL();
        _UserInfo = userLogic.GetUser(this.UserID);
        SetAdditionalData();
    }

    

}