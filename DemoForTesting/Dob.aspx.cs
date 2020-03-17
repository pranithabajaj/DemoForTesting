using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoForTesting
{
    public partial class Dob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            BLClass B = new BLClass();
            try
            {
                txtAge.Text = B.Age(DateTime.Parse(txtDob.Text)).ToString();
            }
            catch(CustomException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}