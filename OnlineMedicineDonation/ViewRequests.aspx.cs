using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OnlineMedicineDonation
{
    public partial class ViewRequests : System.Web.UI.Page
    {
<<<<<<< HEAD

        private void feedApprovedDonations()
        {

            using (SqlConnection con = new SqlConnection(login.conString))
            {

                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM donations WHERE status = 'APPROVED'", con);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();

            }

        }

=======
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
<<<<<<< HEAD
                feedApprovedDonations();

            }

            if (Request["donId"] != null) {

                MultiView1.ActiveViewIndex = 1;

            }

            
        }

        protected void btnDonate_Click(object sender, EventArgs e)
        {
            /*switch (cblPaymentOptions.SelectedValue)
            {

                case "1":
                    Response.Redirect("https://paytm.com/");
                    break;

                case "2":
                    Response.Redirect("https://www.paypal.com/in/home");
                    break;

            }*/

            result.Text = "This might take some time.";
            System.Threading.Thread.Sleep(2000);
            result.Text = "Donation Successful.";
=======

            }

            using (SqlConnection con = new SqlConnection(login.conString))
            {

                con.Open();

                String query = "SELECT * FROM meds WHERE id = '" + Request["medId"].Trim() + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    actualQuantity = reader.GetInt32(3);

                    lblMedName.Text = reader.GetString(1);
                    lblMedDesc.Text = reader.GetString(2);
                    lblMedQuantity.Text = reader.GetInt32(3).ToString() + " Qty.";
                    RangeValidator1.MaximumValue = reader.GetInt32(3).ToString();

                }
                cmd.Dispose();
                reader.Close();
                con.Close();

            }
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
        }
    }
}