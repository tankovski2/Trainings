using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostCacheSubst : System.Web.UI.Page
{
    public static string GetTimeStamp(HttpContext ctx)
    {
        return "<h1>" + DateTime.Now.ToLongTimeString() + "</h1>";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = GetTimeStamp(this.Context);
    }
}
