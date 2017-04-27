using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string email = EmailTextBox.Text;
        string firstname = FirstNameTextBox.Text;
        string lastname = LastNameTextBox.Text;
        string password = ConfirmPasswordTextBox.Text;

        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register(email, firstname, lastname, password);
        if(result != -1)
        {
            Response.Redirect("Donation.aspx");
        }else
        {
            ErrorLabel.Text = "Review your information, something is wrong.";

        }
    }
}