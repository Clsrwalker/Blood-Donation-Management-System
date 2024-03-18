<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yuyueadd.aspx.cs" Inherits="xianxue_yuyueadd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> <!-- Adjusted charset to UTF-8 -->
<title>Appointment Add</title>
<link rel="stylesheet" href="css/xgxt_login.css" />
<style type="text/css">
<!--
body {
    margin-left: 0px;
    margin-top: 0px;
    margin-right: 0px;
    margin-bottom: 0px;
}
.STYLE1 {font-size: 12px}
.STYLE4 {
    font-size: 12px;
    color: #1F4A65;
    font-weight: bold;
}

a:link {
    font-size: 12px;
    color: #06482a;
    text-decoration: none;
}
a:visited {
    font-size: 12px;
    color: #06482a;
    text-decoration: none;
}
a:hover {
    font-size: 12px;
    color: #FF0000;
    text-decoration: underline;
}
a:active {
    font-size: 12px;
    color: #FF0000;
    text-decoration: none;
}
.STYLE7 {font-size: 12}

    -->
</style>
<script language="javascript" type="text/javascript" src=".././My97DatePicker/WdatePicker.js"></script>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <TABLE cellSpacing=0 cellPadding=0 width="100%" align=center border=0>
<tr>
    <td height="30"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="15" height="30"><img src=".././Admin/images/tab_03.gif" width="15" height="30" /></td>
        <td background=".././Admin/images/tab_05.gif"><img src=".././Admin/images/311.gif" width="16" height="16" /><span class="STYLE4">Reservation</span> </td>
        <td width="14"><img src=".././Admin/images/tab_07.gif" width="14" height="30" /></td>
      </tr>
    </table></td>
  </tr>
  <TR>
    <TD bgColor=#b1ceef height=1></TD></TR>
  <TR height=20>
    <TD>
      <table align="center" border="1" cellpadding="3" cellspacing="0" bordercolor="#A5DFC6" style="border-collapse:collapse;"
            width="99%">
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Name:</td>
                <td width="80%">
                    <asp:Textbox ID="xxzname" runat="server" Width="139px" ></asp:Textbox>
                    </td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Tel:</td>
                <td width="80%">
                    <asp:Textbox ID="xxztel" runat="server" Width="139px" ></asp:Textbox>
                    </td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Reservation Time:</td>
                <td width="80%">
                    <asp:Textbox ID="yysj" runat="server" Width="139px"  onclick="WdatePicker()" ></asp:Textbox> <img onClick="WdatePicker({el:$dp.$('yysj'),dateFmt:'yyyy/MM/dd HH:mm:ss', readOnly:true})" src=".././My97DatePicker/skin/datePicker.gif" mce_src="My97DatePicker/skin/datePicker.gif" width="16" height="22" align="absmiddle"> 
                    </td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Reservation Address:</td>
                <td width="80%">
                    <asp:Textbox ID="yyaddress" runat="server" Width="139px" ></asp:Textbox>
                    </td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Reservation Begin Time:</td>
                <td width="80%">
                    <asp:Textbox ID="yykstime" runat="server" Width="139px" ></asp:Textbox>
                    <img onClick="WdatePicker({el:$dp.$('yykstime'),dateFmt:'yyyy/MM/dd HH:mm:ss', readOnly:true})" src=".././My97DatePicker/skin/datePicker.gif" mce_src="My97DatePicker/skin/datePicker.gif" width="16" height="22" align="absmiddle"></td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Reservation End Time:</td>
                <td width="80%">
                    <asp:Textbox ID="yyjstime" runat="server" Width="139px" ></asp:Textbox>
                    <img onClick="WdatePicker({el:$dp.$('yyjstime'),dateFmt:'yyyy/MM/dd HH:mm:ss', readOnly:true})" src=".././My97DatePicker/skin/datePicker.gif" mce_src="My97DatePicker/skin/datePicker.gif" width="16" height="22" align="absmiddle"></td>
              </tr>
               <tr>
                <td class="left_title_1" style="WIDTH: 10%">Status:</td>
                <td width="80%">
                    <asp:Textbox ID="sts" runat="server" Width="139px" ></asp:Textbox>
                    </td>
              </tr>
            <tr>
                <td align="center" colspan="2" style="HEIGHT: 30px">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
                </td>
            </tr>
        </table>
      </TD></TR>
  <TR height=20>
    <TD background=../images/shadow_bg.jpg>&nbsp;</TD></TR></TABLE>

    </div>
    </form>
</body>
</html>
