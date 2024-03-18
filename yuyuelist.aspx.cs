using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using System.IO;

public partial class xianxue_yuyuelist : System.Web.UI.Page
{

    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["mima"] == null)
            {
                //Response.Write("<script language=javascript>alert('请先登录!');window.location.href='.././Default.aspx'</script>");
                Response.Write("<script language=javascript>alert('Please log in first!');window.location.href='.././Default.aspx'</script>");

                return;
            }

            else
            {

                getinfo();
            }

            
        }
    }

    private void getinfo()
    {
        try
        {

            string strsql = "select *   from xxyuyue  where 1=1 ";
            if (this.TextBox1.Text != "")
            {
                strsql += " and xxzname like '%" + this.TextBox1.Text + "%'";
            }

            if (this.TextBox2.Text != "")
            {
                strsql += " and xxztel like '%" + this.TextBox2.Text + "%'";
            }

            if (Session["phonenumber"] != null && Session["phonenumber"].ToString()!="")
            {

                strsql += " and xxztel like '%" + Session["phonenumber"].ToString() + "%'";
            
            }

     

     
            strsql += "  order by id desc ";
            DataSet ds = data.GetDs(strsql, "ds");
            dlinfo.DataSource = ds.Tables[0];
            dlinfo.DataBind();
        }
        catch
        {
        }
    }
    protected void dlinfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dlinfo.PageIndex = e.NewPageIndex;
        getinfo();
    }
    protected void dlinfo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
     
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#f6f6f6',this.style.fontWeight='';");
          
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
        }
       
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", "this.style.backgroundColor='#f6f6f6'; this.style.color='buttontext';this.style.cursor='default';");
        }

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        getinfo();
    }


    protected void dlinfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {


        string ID = dlinfo.DataKeys[e.RowIndex].Values[0].ToString();

  

        try
        {
            data.RunSql("delete  from xxyuyue  where  id=" + ID );
            //alert.Alertjs("删除成功");
            alert.Alertjs("Deletion successful");

            dlinfo.EditIndex = -1;
            getinfo();


        }
        catch
        {
            //alert.Alertjs("删除失败");
            alert.Alertjs("Deletion failed");

        }
    }



}