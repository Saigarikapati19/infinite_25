using ElectricBill.aspfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricBill
{
    public partial class ViewBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnViewBills_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text.Trim());

                ElectricityBoard board = new ElectricityBoard();
                List<ElectricityBill> bills = board.Generate_N_BillDetails(n);

                if (bills.Count == 0)
                {
                    Label1.Text = "No bills found in the database.";
                }

                gvBills.DataSource = bills;
                gvBills.DataBind();
                gvBills.Visible = true;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
            }
        }
    }
    
}