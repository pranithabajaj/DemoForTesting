using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoForTesting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BLClass B = new BLClass();
            try
            {
                txtResult.Text = (B.Divide(txtNumerator.Text, txtDenominator.Text).ToString());
            }
            catch(DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
            catch (FormatException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}