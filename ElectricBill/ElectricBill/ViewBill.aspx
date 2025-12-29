<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBill.aspx.cs" Inherits="ElectricBill.ViewBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View N Bills</title>
    <style>
    body {
        font-family: Arial;
        background: #f2f2f2;
    }

    .bill-box {
        width: 360px;
        margin: 130px auto;
        padding: 8px;
        background: white;
        border: 1px solid #ccc;
    }

    .bill-box h2 {
        text-align: center;
        font-size: 18px;
        margin-bottom: 8px;
    }

    .bill-box label {
        font-size: 13px;
        margin-top: 5px;
        display: block;
    }

    .bill-box input[type="text"] {
        width: 220px;
        padding: 3px;
        font-size: 13px;
    }

    .bill-box input[type="submit"] {
        padding: 4px 10px;
        font-size: 13px;
        margin-top: 6px;
    }

    .bill-box table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 8px;
        font-size: 12px;
    }

    .bill-box th, .bill-box td {
        border: 1px solid #ccc;
        padding: 4px;
        text-align: center;
    }

    .bill-box th {
        background-color: #eee;
    }
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="bill-box">
            <h2>View Last N Electricity Bills</h2>

            <!-- Input for N -->
            <asp:Label ID="lblEnterN" runat="server" Text="Enter number of bills to retrieve:"></asp:Label><br />
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtN" ErrorMessage="value must be 1 to 100" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br /><br />

            <asp:Button ID="btnViewBills" runat="server" Text="View Bills" OnClick="btnViewBills_Click" /><br /><br />

            <!-- Display messages -->
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
            <br /><br />

            <!-- GridView to show bill details -->
            <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="false" BorderStyle="Solid" BorderWidth="1px">
                <Columns>
                    <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
                    <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
                    <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
                    <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount (Rs.)" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
