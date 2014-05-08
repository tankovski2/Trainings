using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{   
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Cache.SetCacheability(HttpCacheability.Public);
        //Response.Cache.SetExpires(DateTime.Now.AddMinutes(1));

        _timestamp.Text = DateTime.Now.ToLongTimeString();
    }
    protected void _enterNameButton_Click(object sender, EventArgs e)
    {
        _nameLabel.Text = _nameTextBox.Text;
    }
}
