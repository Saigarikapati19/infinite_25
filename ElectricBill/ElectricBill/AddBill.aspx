<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBill.aspx.cs" Inherits="ElectricBill.AddBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Electricity Bill Entry</title>
        <style>
    body {
        font-family: Arial;
        background: #f2f2f2;
    }

    .bill-box {
        width: 400px;
        margin: 120px auto;
        padding: 10px;
        background: white;
        border: 1px solid #ccc;
    }

    .bill-box label {
        font-weight: normal;
    }

    .bill-box input {
        width: 75%;
        padding: 4px;
        margin-top: 3px;
    }

    .bill-box input[type="submit"] {
        width: auto;
        padding: 4px 12px;
        margin-top: 5px;
    }

    .bill-box span {
        color: black;
        font-size: 12px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="bill-box">
            <h2>Electricity Bill Entry</h2>

            <!-- General Message -->
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />

            <!-- Consumer Number -->
            <asp:Label ID="lblConsumerNumber" runat="server" Text="Consumer Number:"></asp:Label><br />
            <asp:TextBox ID="txtConsumerNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConsumerNumber" runat="server"
                ControlToValidate="txtConsumerNumber" ErrorMessage="Consumer Number is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revConsumerNumber" runat="server"
                ControlToValidate="txtConsumerNumber"
                ErrorMessage="Invalid format. start with EB by 5 digits."
                ValidationExpression="^EB\d{5}$" ForeColor="Red">*</asp:RegularExpressionValidator>
            <br /><br />

            <!-- Consumer Name -->
            <asp:Label ID="lblConsumerName" runat="server" Text="Consumer Name:"></asp:Label><br />
            <asp:TextBox ID="txtConsumerName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConsumerName" runat="server"
                ControlToValidate="txtConsumerName" ErrorMessage="Consumer Name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br /><br />

            <!-- Units Consumed -->
            <asp:Label ID="lblUnitsConsumed" runat="server" Text="Units Consumed:"></asp:Label><br />
            <asp:TextBox ID="txtUnitsConsumed" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUnits" runat="server"
                ControlToValidate="txtUnitsConsumed" ErrorMessage="Units Consumed is required" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvUnits" runat="server"
                ControlToValidate="txtUnitsConsumed"
                MinimumValue="0" MaximumValue="100000"
                Type="Integer"
                ErrorMessage="Units Consumed must be 0 or greater" ForeColor="Red">*</asp:RangeValidator>
            <br /><br />

            <!-- Submit Button -->
            <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" OnClick="btnAddBill_Click" /><br /><br />

            <!-- Output Message -->
            <asp:Label ID="lblBillOutput" runat="server" ForeColor="Green"></asp:Label>

        </div>
    </form>
</body>
</html>
