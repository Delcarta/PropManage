using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for iaSession
/// </summary>
public class iaSession
{
    public bool IsValid
    {
        get
        {
            return Person.IsValidUser;
        }
    }

    private UserBL _Person;
    public UserBL Person
    {
        get
        {
            return _Person;
        }
    }

    private CompanyBL _CompanyInfo;
    public CompanyBL CompanyInfo
    {
        get
        {
            if (_CompanyInfo != null)
                return _CompanyInfo;
            else
            {
                //attempt to get company
                if (Person.HasCompany)
                {
                    _CompanyInfo = new CompanyBL(Person.CompanyInfo);
                    return _CompanyInfo;
                }
                else
                {
                    return null;
                }
            }
        }
    }

    private PropertyBL _PropertyInfo;
    public PropertyBL PropertyInfo
    {
        get
        {
            if (_PropertyInfo != null)
                return _PropertyInfo;
            else
            {
                if (Person.HasProperty)
                {
                    _PropertyInfo = new PropertyBL(Person.PropertyInfo);
                    return _PropertyInfo;
                }
                else
                {
                    return null;
                }
            }

        }
    }

    /// <summary>
    /// Used for denoting which property to load into the ui
    /// </summary>
    private int _ActivePropertyID;
    public int ActivePropertyID
    {
        get
        {
            return _ActivePropertyID;
        }
        
    }

    public iaSession(UserBL PersonIn)
    {
        _Person = PersonIn;
        if (PersonIn.HasCompany)
            _CompanyInfo = new CompanyBL(PersonIn.CompanyInfo);

        if (PersonIn.HasProperty)
        {
            _PropertyInfo = new PropertyBL(PersonIn.PropertyInfo);
            _ActivePropertyID = _PropertyInfo.GetLastPropertyID();
        }


    }

    public void SetActivePropertyID(int ID)
    {
        _ActivePropertyID = ID;
    }
}