<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yuyuelist.aspx.cs" Inherits="xianxue_yuyuelist" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title></title>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <TABLE cellSpacing=0 cellPadding=0  width="100%" align=center border=0>
  <tr>
    <td height="30"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="15" height="30"><img src=".././Admin/images/tab_03.gif" width="15" height="30" /></td>
        <td background=".././Admin/images/tab_05.gif"><img src=".././Admin/images/311.gif" width="16" height="16" /> <span class="STYLE4">Reservation list</span></td>
        <td width="14"><img src=".././Admin/images/tab_07.gif" width="14" height="30" /></td>
      </tr>
    </table></td>
  </tr>
      <TR>
    <TD height=1>
       Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> Tel:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:Button
            ID="Button1" runat="server" Text="Query" Height="25px" 
            onclick="Button1_Click" Width="66px" />  </TD></TR>
  <TR >
    <TD background=../images/shadow_bg.jpg>
        <asp:GridView ID="dlinfo" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="id" 
            OnPageIndexChanging="dlinfo_PageIndexChanging" 
            OnRowDataBound="dlinfo_RowDataBound"   
            OnRowDeleting="dlinfo_RowDeleting" 
            pagesize="20"
            Width="100%">
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#8EC172" CssClass="ct" Font-Bold="True" 
                ForeColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="num" >
                    <ItemStyle HorizontalAlign="Center" Width="2%"/>
                    <ItemTemplate>
                        <asp:Label ID="id" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
               
                    <asp:TemplateField HeaderText="name" >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="xxzname" runat="server" Text='<%# Bind("xxzname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  

                      <asp:TemplateField HeaderText="tel"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="xxztel" runat="server" Text='<%# Bind("xxztel") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  

                 <asp:TemplateField HeaderText="Reservation time"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="yysj" runat="server" Text='<%# Bind("yysj") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  
                  

                <asp:TemplateField HeaderText="Reservation address"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="yyaddress" runat="server" Text='<%# Bind("yyaddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  

                 <asp:TemplateField HeaderText="Reservation begin time"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="yykstime" runat="server" Text='<%# Bind("yykstime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  
                
                <asp:TemplateField HeaderText="Reservation end time"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="yyjstime" runat="server" Text='<%# Bind("yyjstime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  


                <asp:TemplateField HeaderText="Reservation status"  >
                    <ItemStyle HorizontalAlign="Left" Width="5%" />
                    <ItemTemplate>
                        <asp:Label ID="sts" runat="server" Text='<%# Bind("sts") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>  







                    <asp:TemplateField HeaderText="modify">
                    <ItemStyle HorizontalAlign="Center" Width="5%" />
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink3" runat="server" 
                            NavigateUrl='<%# "yuyueadd.aspx?id="+Eval("id")+"&type=2" %>' Text="Modify"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="operation" ShowHeader="False">
                    <ItemStyle HorizontalAlign="Center" Width="2%" />
                    <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('Are you sure you want to delete it?')"  CausesValidation="False" 
                            CommandName="Delete" Text="delete" Width="50px"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>


      
          
            </Columns>
            <PagerSettings FirstPageText="first page" LastPageText="last page" NextPageText="next page" 
                PageButtonCount="12" PreviousPageText="previous page" />
            <RowStyle ForeColor="#000066" HorizontalAlign="Left" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerTemplate>
                <table border="0" width="100%">
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" 
                                CommandName="Page" 
                                Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != 0 %>">first page </asp:LinkButton>
                            <asp:LinkButton ID="LinkButtonPreviousPage" runat="server" 
                                CommandArgument="Prev" CommandName="Page" 
                                Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != 0 %>">previous page </asp:LinkButton>
                            <asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" 
                                CommandName="Page" 
                                Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>">next page </asp:LinkButton>
                            <asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" 
                                CommandName="Page" 
                                Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>">last page  </asp:LinkButton>
                            total 
                            <asp:Label ID="LabelPageCount" runat="server" 
                                Text=" <%# ((GridView)Container.NamingContainer).PageCount %>"> </asp:Label>
                            page  di 
                            <asp:Label ID="Label2" runat="server" 
                                Text=" <%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"> </asp:Label>
                            page 
                        </td>
                        <td align="right" >
                        </td>
                    </tr>
                </table>
            </PagerTemplate>
        </asp:GridView>
        </TD></TR>
        </TABLE>

    </div>
    </form>
</body>
</html>
