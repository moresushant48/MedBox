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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;

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
        }
    }
}