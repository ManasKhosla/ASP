<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CC.aspx.vb" Inherits="CollegePractical_VB.CC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert: &nbsp;
        <input type="text" id="US" runat="server" />
            &nbsp; U.S. dollars to &nbsp;
        <select style="width: 155px" id="Currency" runat="server"></select>
            <br />
            <br />
            <input type="submit" value="OK" id="Convert" runat="server" /><br />
            <br />
            <div style="font-weight: bold" id="RESULT" runat="server"></div>
        </div>

    </form>
</body>
</html>
