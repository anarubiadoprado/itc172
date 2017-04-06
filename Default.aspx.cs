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
        if (!IsPostBack)
        {
            string[] percents = { "10%", "15%", "20%", "Other"};
            TipPercentRadioButtonList1.DataSource = percents;
            TipPercentRadioButtonList1.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTotals();
    }

    private void GetTotals()
    {
        double amount;
        Tip tip = null;
        bool goodAmount = double.TryParse(MealTextBox.Text, out amount);
        if (goodAmount)
        {
            double percent = 0;
            if (TipPercentRadioButtonList1.SelectedItem.Text != "Other")
            {
                if (TipPercentRadioButtonList1.SelectedItem.Text.Equals("10%"))
                    percent = .1;
                if (TipPercentRadioButtonList1.SelectedItem.Text.Equals("15%"))
                    percent = .15;
                if (TipPercentRadioButtonList1.SelectedItem.Text.Equals("20%"))
                    percent = .2;
            }
            else
            {
                percent = double.Parse(OtherTextBox.Text);
                percent /= 100;
            }

            tip = new Tip(amount, percent);
        }
        else
        {
            Response.Write("<script>alert('Enter a valiable number');</script>");
        }

        ResultLabel.Text = "Amount: " + amount + "</br>" + "Tax: "
            + tip.CalculateTax().ToString("$ #,##0.00") + "</br>"
            + "Tip: " + tip.CalculateTip().ToString("$ #,##0.00") + "</br>"
            + "Total: " + tip.Total().ToString("$ #,##0.00");
    }
}
