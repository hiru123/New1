using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DAL
{
    
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
	public DAL()
	{
        con = new SqlConnection(ConfigurationManager.AppSettings["default"]);
	}

    public DataSet getDataState()
    {
        string cmdtext = "select * from tblState";
        cmd = new SqlCommand(cmdtext, con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getDataCity(BAL b)
    {
        string cmdtext = "select * from tblCity where StateId=@id";
        cmd = new SqlCommand(cmdtext, con);
        cmd.Parameters.AddWithValue("@id", b.Stateid);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}