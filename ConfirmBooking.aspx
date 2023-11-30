<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmBooking.aspx.cs" Inherits="Prac3.ConfirmBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="font-weight: bold; font-size: 18px;">ABC BUS BOOKING CONFIRMATION</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>You have confirmed your booking with the following details</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDetails" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Please make payment at our counter.</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
