using Assignment6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Viewgrants : System.Web.UI.Page
{

    Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();
    

    protected void Page_Load(object sender, EventArgs e)
    {
             Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();

        if(Session["PersonKey"] != null)
        {
            int key = (int)Session["PersonKey"];
            var grant = (from g in sc.GetReview
                         where g.PersonKey == key
                         select g).ToList();

            GrantGridView.DataSource = grant;
            GrantGridView.DataBind();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }

    protected void GrantGridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}