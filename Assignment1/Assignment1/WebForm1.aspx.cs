using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("Select Product", "0"));
                DropDownList1.Items.Add(new ListItem("Bluetooth", "Bluetooth"));
                DropDownList1.Items.Add(new ListItem("mouse", "mouse"));
                DropDownList1.Items.Add(new ListItem("cooler", "cooler"));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Bluetooth")
            {
                Image1.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbZSU2FYfaFJxkfwCFzT6hTturZU4EYRdWWw&s";
            }
            else if (DropDownList1.SelectedValue == "mouse")
            {
                Image1.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLJBPXpykvG03fUcZoE41JhcvH14Uaydk4LQ&s";
            }
            else  
            {
                Image1.ImageUrl = "https://5.imimg.com/data5/SELLER/Default/2023/4/300938170/ES/FA/IP/36893300/vu-pixelight-126cm-50-inch-ultra-hd-4k-led-smart-tv-50-qdv-50-qdv-v1-.jpg";
            }
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Bluetooth")
            {
                Label1.Text = "Price: ₹3,500";
            }
            else if (DropDownList1.SelectedValue == "mouse")
            {
                Label1.Text = "Price: ₹850";
            }
            else if (DropDownList1.SelectedValue == "cooler")
            {
                Label1.Text = "Price: ₹11000";
            }
            else
            {
                Label1.Text = "Please select a product";
            }
        }
    }
}