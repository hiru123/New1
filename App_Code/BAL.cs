using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class BAL
{
    DAL d = new DAL();

    public int Stateid
    { get; set; }
	public BAL()
	{
	}

    public DataSet reg_getDataState()
    {
        return d.getDataState();
    }
    public DataSet reg_getDataCity(BAL b)
    {
        return d.getDataCity(b);
    }
}