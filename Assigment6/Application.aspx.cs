using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Application : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if(Session["PersonKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
       

        string email = EmailTextBox.Text;
        string amount = AmountTextBox.Text;
        string explanation = ExplanationTextBox.Text;


        Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();


        Assignment6.GrantRequest gReq = new Assignment6.GrantRequest();

        gReq.GrantRequestAmount = decimal.Parse(AmountTextBox.Text);
        gReq.GrantRequestDate = DateTime.Now;
        gReq.PersonKey = (int)Session["PersonKey"];

        sc.GrantRequests.Add(gReq);
        sc.SaveChanges();

        Response.Redirect("Viewgrants.aspx");
    }
}