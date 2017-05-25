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

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();

        int result = sc.PersonLogin(UserNameTextBox.Text, PasswordTextBox.Text);
        if (result != 0)
        {
            Session["PersonKey"] = result;
            ResultLabel.Text = "Welcome ";
            Response.Redirect("Application.aspx");
        }
        else
        {
            ResultLabel.Text = "Invalid login. Register first.";
        }

    }

}