﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Loginpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        int key = 0;
        Community_AssistEntities db = new Community_AssistEntities();
        int success = db.usp_Login(UserTextBox.Text, PasswordTextBox.Text);
        if (success != -1)
        {
            var uKey = (from k in db.People
                        where k.PersonEmail.Equals(UserTextBox.Text)
                        select k.PersonKey).FirstOrDefault();

            key = (int)uKey;
            Session["PersonKey"] = key;
            Response.Redirect("Donation1.aspx");

        }else
        {
            ResultLabel.Text = "Invalid Login. You should register first.";
        }
    }

    protected void RegisterLinkButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}