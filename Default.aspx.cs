using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Rsvp_Onclick(object sender, EventArgs e)
    {
        var url = string.Format("/Rsvp?username={0}", usernameInput.Text);
        Response.Redirect(url);        

    }
}