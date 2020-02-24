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
    public partial class AddRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Session["userId"] == null)
                Response.Redirect("/");
=======
            //if (Session["userId"] == null)
            //    Response.Redirect("/");
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(login.conString);
                con.Open();
                String query = "INSERT INTO donations VALUES ( '"
                    + txtTitle.Text + "','"
                    + txtDesc.Text + "','"
                    + txtGoal.Text + "','"
                    + "UNCHECKED','" 
                    + Session["userId"].ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblResult.Text = "Added Request.";
                    txtTitle.Text = "";
                    txtDesc.Text = "";
                    txtGoal.Text = "";
                }

                cmd.Dispose();
                con.Close();
            }
            else
            {
<<<<<<< HEAD
                Response.Redirect("/AddRequest.aspx");
=======
                Response.Redirect("/addMedicine.aspx");
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
            }
        }
    }
}