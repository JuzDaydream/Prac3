<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusTicketting.aspx.cs" Inherits="Prac3.BusTicketting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        .auto-style2 {
            width: 115px;
        }

        .auto-style4 {
            width: 175px;
        }

        .auto-style5 {
            width: 115px;
            height: 23px;
        }

        .auto-style6 {
            width: 175px;
            height: 23px;
        }

        .auto-style7 {
            width: 63px;
        }

        .auto-style8 {
            width: 63px;
            height: 23px;
        }

        .auto-style9 {
            width: 115px;
            height: 26px;
        }

        .auto-style10 {
            width: 63px;
            height: 26px;
        }

        .auto-style11 {
            width: 175px;
            height: 26px;
        }

        .auto-style12 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td colspan="4" style="font-size: 18px; font-weight: bold; text-align: center;">ABC BUS ONLINE BOOKING &amp; TICKETING SYSTEM</td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="4" style="text-align: center;">
                        <asp:Label ID="lblTime" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Departure Date </td>
                    <td class="auto-style7" style="text-align: center;">:</td>
                    <td class="auto-style4">
                        <asp:Calendar ID="calDepartDt" runat="server" OnSelectionChanged="calDepartDt_SelectionChanged"></asp:Calendar>
                        <br />
                        <asp:TextBox ID="txtDepartDt" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style8" style="text-align: center;"></td>
                    <td class="auto-style6">
                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Adult</td>
                    <td class="auto-style7" style="text-align: center;">:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtAdult" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Child</td>
                    <td class="auto-style7" style="text-align: center;">:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtChild" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">From</td>
                    <td class="auto-style10" style="text-align: center;">:</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlFrom" runat="server" Height="18px" Width="113px" AutoPostBack="True">
                            <asp:ListItem>--Select Origin--</asp:ListItem>
                            <asp:ListItem Value="Hentian Duta"></asp:ListItem>
                            <asp:ListItem>Hentian Putra</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Destination</td>
                    <td class="auto-style7" style="text-align: center;">:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlTo" runat="server" Height="16px" Width="147px" AutoPostBack="True">
                            <asp:ListItem>--Select Destination--</asp:ListItem>
                            <asp:ListItem>Butterworth</asp:ListItem>
                            <asp:ListItem>Seremban</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Ticket Price</td>
                    <td class="auto-style7" style="text-align: center;">:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtPrice" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: center;">
                        <asp:Button ID="btnBookTkt" runat="server" Text="Book Ticket" Width="113px" OnClick="btnBookTkt_Click" OnClientClick="javascript:alert('You are now will be directed to the booking confirmation page')" />
                    </td>
                    <td style="text-align: center;" colspan="2">
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnMouseOver="this.value='Click if you confirm to reset selection'" OnMouseOut="this.value='Cancel'" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
