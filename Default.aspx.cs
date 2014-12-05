using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class _Default : System.Web.UI.Page
{
    BAL b = new BAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillState();
            //FillCity();
        }
    }

    public void FillState()
    {
        DataSet ds = b.reg_getDataState();
        DropState.DataSource = ds;
        DropState.DataTextField = ds.Tables[0].Columns["State"].ToString();
        DropState.DataValueField = ds.Tables[0].Columns["StateId"].ToString();
        DropState.DataBind();
    }

    public void FillCity()
    {
        b.Stateid = Convert.ToInt32(DropState.SelectedItem.Value);
        DataSet ds = new DataSet();
        ds = b.reg_getDataCity(b);
        DropCity.DataSource = ds;
        DropCity.DataTextField = ds.Tables[0].Columns["city"].ToString();
        DropCity.DataValueField = ds.Tables[0].Columns["CityId"].ToString();
        DropCity.DataBind();
    }
   
    protected void DropState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropState.SelectedIndex > 0)
        {
            FillCity();
        }
    }
}