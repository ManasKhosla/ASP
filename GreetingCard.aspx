<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GreetingCard.aspx.vb" Inherits="CollegePractical_VB.GreetingCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a background color:<br />
            <asp:DropDownList ID="lstBackColor" runat="server" Width="194px" Height="22px">
            </asp:DropDownList>
            <br />
            <br />
            Choose a font:<br />
            <asp:DropDownList ID="lstFontName" runat="server" Width="194px" Height="22px">
            </asp:DropDownList>
            <br />
            <br />
            Specify a numeric font size:<br />
            <asp:TextBox ID="txtFontSize" runat="server" /><br />
            <br />
            Choose a border style:<br />
            <asp:RadioButtonList ID="lstBorder" runat="server" Width="177px"
                Height="59px">
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:CheckBox ID="chkPicture" runat="server"
                Text="Add the Default Picture" AutoPostBack="true"></asp:CheckBox><br />
            <br />
            Enter the greeting text below:<br />
            <asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px"
                TextMode="MultiLine" />
            <br />
            <asp:Button ID="cmdUpdate"
                runat="server" Width="71px" Height="24px" Text="Update" />
        </div>
        <asp:Panel ID="pnlCard" Style="z-index: 101; left: 838px; position: absolute; top: 24px;" runat="server" Width="339px" Height="481px" HorizontalAlign="Center">
            <br />
            &nbsp;
            <asp:Label ID="lblGreeting" runat="server" Width="256px"
                Height="150px" /><br />
            <br />
            <br />
            <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" />
        </asp:Panel>
    </form>
</body>
</html>
