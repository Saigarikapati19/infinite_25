using System;
using System.Text.RegularExpressions;
using ElectricBill.aspfiles;

namespace ElectricBill
{
    public partial class AddBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                ElectricityBill ebill = new ElectricityBill
                {
                    ConsumerNumber = txtConsumerNumber.Text.Trim(), 
                    ConsumerName = txtConsumerName.Text.Trim(),
                    UnitsConsumed = int.Parse(txtUnitsConsumed.Text.Trim()) 
                };

                ElectricityBoard board = new ElectricityBoard();
                board.CalculateBill(ebill);

                board.AddBill(ebill);

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Bill successfully added!";
                lblBillOutput.Text = $"{ebill.ConsumerNumber} {ebill.ConsumerName} {ebill.UnitsConsumed} Units, Bill Amount: {ebill.BillAmount}";
            }
            catch (FormatException ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
