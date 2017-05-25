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
        string password = PasswordTextBox.Text;
        string apartmentNumber = ApartmentNumberTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zipcode = ZipcodeTextBox.Text;
        string homePhone = HomePhoneTextBox.Text;
        string workPhone = WorkPhoneTextBox.Text;
        
        

        Assignment6.Assignment5ServiceClient sc = new Assignment6.Assignment5ServiceClient();

        Assignment6.PersonInfo p = new Assignment6.PersonInfo();
        p.PersonEmail = email;
        p.PersonFirstName = firstname;
        p.PersonLastName = lastname;
        p.PersonPassword = password;
        p.PersonApartmentNumber = apartmentNumber;
        p.PersonStreet = street;
        p.PersonCity = city;
        p.PersonState = state;
        p.PersonZipcode = zipcode;
        p.PersonHomePhone = homePhone;
        p.PersonWorkPhone = workPhone;

        bool result = sc.Register(p);
        if(result)
        {
            Response.Redirect("Default.aspx");
        }else
        {
            ErrorLabel.Text = "Review your information, something is wrong.";

        }
    }
}