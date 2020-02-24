using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMedicineDonation
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["loggedIn"] != null)
            {
                /*
                  When the normal user is Logged in.
                 */

                liLogin.Visible = false;
                liRegister.Visible = false;
                liAdminPanel.Visible = false;

                btnLogout.Visible = true;
                liMyAccount.Visible = true;
                liAddMedicine.Visible = true;
<<<<<<< HEAD
                liDonations.Visible = true;
                liMyMedicines.Visible = true;
                liUserEmail.Visible = true;
=======
                //liDonations.Visible = true;
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
                

                /*
                 Admin Navigation
                 */
                if (Session["userID"].ToString() == 1.ToString())
                {
                    liAdminPanel.Visible = true;
                }

                /*
                    Fetch username and set into liUserName. 
                */
                liUserEmail.InnerText = Session["userEmail"].ToString();
            }
            else {
                /*
                  When the user is Not Logged in.
                 */

                liLogin.Visible = true;
                liRegister.Visible = true;

                btnLogout.Visible = false;
                liMyAccount.Visible = false;
                liAddMedicine.Visible = false;
                liAdminPanel.Visible = false;
<<<<<<< HEAD
                liDonations.Visible = false;
                liMyMedicines.Visible = false;
                liUserEmail.Visible = false;
=======
                //liDonations.Visible = false;
>>>>>>> 1bc938adc5e3fdaf6f7afc812415981829d12477
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["loggedIn"] = null;
            Response.Redirect("/");

            Session.Abandon();
            
        }
    }
}