<%@ Page Title="Electricity Board Home" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="ElectricBill._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h2>Electricity Board Billing Automation</h2>
        </section>

        <hr />

        <div class="row">

            <section class="row">
                <h3>Add Electricity Bill</h3>
                <p>
                    <a href="AddBill.aspx" class="btn btn-primary">
                        Add Bill
                    </a>
                </p>
            </section>

            <section class="row">
                <h3>View Last N Bills</h3>
                <p>
                    <a href="ViewBill.aspx" class="btn btn-success">
                        View Bills
                    </a>
                </p>
            </section>

        </div>

        <hr />

    </main>

</asp:Content>
