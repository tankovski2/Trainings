using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FragmentCache : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        _timeStamp.Text = DateTime.Now.ToLongTimeString();

    }
}
