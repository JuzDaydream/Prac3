using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac3
{
    public partial class BusTicketting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            if (IsPostBack == true)
            {
                if (ddlFrom.SelectedIndex == 0 || ddlTo.SelectedIndex == 0)
                {
                    lblError.Text = "Please select an origin and a destination.";
                }

                else if (ddlFrom.SelectedIndex == 1 && ddlTo.SelectedIndex == 1)
                {
                    Double adultPrice = 34;
                    Double childPrice = 25.50;

                    if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                    {
                        lblError.Text = "Please enter number of adult and child";
                        return;
                    }

                    if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                    {
                        lblError.Text = "Please enter number of adult and child";
                        return;
                    }

                    int adultAmount = Convert.ToInt16(txtAdult.Text);
                    int childAmount = Convert.ToInt16(txtChild.Text);

                    double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                    txtPrice.Text = totalPrice.ToString("C2");
                    lblError.Text = "";
                }

                else if (ddlFrom.SelectedIndex == 2 && ddlTo.SelectedIndex == 2)
                {
                    Double adultPrice = 6;
                    Double childPrice = 4.30;

                    if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                    {
                        lblError.Text = "Please enter number of adult and child";
                        return;
                    }

                    if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                    {
                        lblError.Text = "Please enter number of adult and child";
                        return;
                    }

                    int adultAmount = Convert.ToInt16(txtAdult.Text);
                    int childAmount = Convert.ToInt16(txtChild.Text);

                    double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                    txtPrice.Text = totalPrice.ToString("C2");
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "Sorry, we do not provide trip from "
                        + ddlFrom.SelectedItem.Text + " to "
                        + ddlTo.SelectedItem.Text + ".";

                }
            }
        }



        protected void calDepartDt_SelectionChanged(object sender, EventArgs e)
        {
            txtDepartDt.Text = calDepartDt.SelectedDate.ToShortDateString();
        }

        // 1-1 Adult:34 Child 25.50
        // 2-2 Adult:6  Child 4.30
        // 1-2 Error
        // 2-1 Error

        protected void ddlFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - Select Origin
            // 1 - Hentian Duta
            // 2 - Hentian Putra
            if (ddlFrom.SelectedIndex == 0 || ddlTo.SelectedIndex == 0)
            {
                lblError.Text = "Please select an origin and a destination.";
            }

            else if (ddlFrom.SelectedIndex == 1 && ddlTo.SelectedIndex == 1)
            {
                Double adultPrice = 34;
                Double childPrice = 25.50;

                if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                int adultAmount = Convert.ToInt16(txtAdult.Text);
                int childAmount = Convert.ToInt16(txtChild.Text);

                double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                txtPrice.Text = totalPrice.ToString("C2");
                lblError.Text = "";
            }

            else if (ddlFrom.SelectedIndex == 2 && ddlTo.SelectedIndex == 2)
            {
                Double adultPrice = 6;
                Double childPrice = 4.30;

                if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                int adultAmount = Convert.ToInt16(txtAdult.Text);
                int childAmount = Convert.ToInt16(txtChild.Text);

                double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                txtPrice.Text = totalPrice.ToString("C2");
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Sorry, we do not provide trip from "
                    + ddlFrom.SelectedItem.Text + " to "
                    + ddlTo.SelectedItem.Text + ".";
            }


        }

        protected void ddlTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - Select Dest
            // 1 - Butterworth
            // 2 - Seremban
        }

        protected void btnBookTkt_Click(object sender, EventArgs e)
        {

            if (ddlFrom.SelectedIndex == 0 || ddlTo.SelectedIndex == 0)
            {
                lblError.Text = "Please select an origin and a destination.";
            }

            else if (ddlFrom.SelectedIndex == 1 && ddlTo.SelectedIndex == 1)
            {
                Double adultPrice = 34;
                Double childPrice = 25.50;

                if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                int adultAmount = Convert.ToInt16(txtAdult.Text);
                int childAmount = Convert.ToInt16(txtChild.Text);

                double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                txtPrice.Text = totalPrice.ToString("C2");
                lblError.Text = "";
            }

            else if (ddlFrom.SelectedIndex == 2 && ddlTo.SelectedIndex == 2)
            {
                Double adultPrice = 6;
                Double childPrice = 4.30;

                if (txtAdult.Text == string.Empty || txtChild.Text == string.Empty)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                if (txtAdult.Text.Length == 0 || txtChild.Text.Length == 0)
                {
                    lblError.Text = "Please enter number of adult and child";
                    return;
                }

                int adultAmount = Convert.ToInt16(txtAdult.Text);
                int childAmount = Convert.ToInt16(txtChild.Text);

                double totalPrice = (adultPrice * adultAmount) + (childPrice * childAmount);
                txtPrice.Text = totalPrice.ToString("C2");
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Sorry, we do not provide trip from "
                    + ddlFrom.SelectedItem.Text + " to "
                    + ddlTo.SelectedItem.Text + ".";
            }
        }

        protected void txtChild_TextChanged(object sender, EventArgs e)
        {

        }
    }
}