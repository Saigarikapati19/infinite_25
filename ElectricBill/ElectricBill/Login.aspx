<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectricBill.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
        font-family: Arial;
        background: #f2f2f2;
    }

    .login-box {
        width: 300px;
        margin: 150px auto;
        padding: 10px;
        background: white;
        border: 1px solid #ccc;
    }

    .login-box td {
        padding: 3px;
    }

    .login-box input {
        width: 100%;
        padding: 4px;
    }

    .login-box input[type="submit"] {
        width: auto;
        padding: 4px 10px;
    }

    #lblMsg {
        text-align: center;
        display: block;
        margin-top: 5px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="login-box">
        <h2>Admin Login</h2>

        <table>
            <tr>
                <td>Username:</td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>

        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
             </div>
    </form>
</body>
</html>
