<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .auto-style1 {
            width: 90px;
        }
        .auto-style2 {
            width: 770px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="2" class="style1">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Select State:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropState_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Select City:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropCity" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
