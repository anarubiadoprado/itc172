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

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
       

        string email = EmailTextBox.Text;
        string amount = AmountTextBox.Text;
        string explanation = ExplanationTextBox.Text;


        Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();

        Assignment6.GrantRequest gRequest = new Assignment6.GrantRequest();


    }
}