using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class MySessionVariables
{
    // private string m_UserName; Not required because we are using Sessions - check UserDetails.cs file
    public string UserName
    {
        get
        {
            if (HttpContext.Current.Session["Sess_UserName"] != null)
                return HttpContext.Current.Session["Sess_UserName"].ToString();
            else
                return String.Empty;
        }
        set
         {
                HttpContext.Current.Session["Sess_UserName"] = value;
         }
     }

    public string Password
    {
        get
        {
            if (HttpContext.Current.Session["Sess_Password"] != null)
                return HttpContext.Current.Session["Sess_Password"].ToString();
            else
                return String.Empty;
        }
        set
        {
            HttpContext.Current.Session["Sess_Password"] = value;
        }
    }

    public void Abandon()
    {
        HttpContext.Current.Session.Abandon();
    }

}