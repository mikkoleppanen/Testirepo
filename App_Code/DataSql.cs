using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataSql
/// </summary>
public class DataSql
{
    public DataSql()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static DataTable getData()
    {
        string sql = "SELECT asioid, lastname, firstname, date FROM lasnaolot";
        string connStr = ConfigurationManager.ConnectionStrings["DemoxConnectionString"].ConnectionString;
    }
}