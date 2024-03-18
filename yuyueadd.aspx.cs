using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class xianxue_yuyueadd : System.Web.UI.Page
{

    SqlHelper data3 = new SqlHelper();
    SqlHelper data4 = new SqlHelper();
    public string strtype;



    public string strdevicephotourl;
        
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Session["mima"] == null)
            {
                Response.Write("<script language=javascript>alert('请先登录!');window.location.href='.././Default.aspx'</script>");

                return;
            }

        }




        if (Request.QueryString["type"] == null)
        {
            strtype = "1";
        }
        else
        {
            strtype = Request.QueryString["type"].ToString();
        }


        
        
        if (!IsPostBack)
        {

            if (Session["mima"] == null || Session["mima"].ToString().Trim()=="")
            {
                Response.Write("<script language=javascript>alert('请先登录!');window.location.href='.././Default.aspx'</script>");
            }

    

   

                if (strtype == "2")
                {


                    if (Session["type"].ToString() != "0")
                    {

                        Alert.AlertAndRedirect("普通用户不能修改！", "yuyuelist.aspx");
                        return;

                    }
                    
                    
                    
                    string id = Request.QueryString["id"].ToString();
                    string strsql = "select * from xxyuyue where ID=" + id;
                    DataSet ds = data4.GetDs(strsql, "ds");

                 

                    this.xxzname.Text = ds.Tables[0].Rows[0]["xxzname"].ToString().Trim();

                    this.xxztel.Text = ds.Tables[0].Rows[0]["xxztel"].ToString().Trim();

                    this.yysj.Text = ds.Tables[0].Rows[0]["yysj"].ToString().Trim();

                    this.yyaddress.Text = ds.Tables[0].Rows[0]["yyaddress"].ToString().Trim();


                    this.yykstime.Text = ds.Tables[0].Rows[0]["yykstime"].ToString().Trim();
                    this.yyjstime.Text = ds.Tables[0].Rows[0]["yyjstime"].ToString().Trim();

                    this.sts.Text = ds.Tables[0].Rows[0]["sts"].ToString().Trim();






                    this.xxzname.ReadOnly = false;

                    this.xxztel.ReadOnly = false;

                    this.yysj.ReadOnly = false;
                    this.yyaddress.ReadOnly = false;

                    this.yykstime.ReadOnly = false;


                    this.yyjstime.ReadOnly = false;
                    this.sts.ReadOnly = false;
        
             

                }

                if (strtype == "1")
                {
             
                    this.sts.ReadOnly = true;


                }




        }

    }


       private static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }


       public string GenerateOrderNumber()
        {
            Random random = new Random();
            var timeStamp = GetTimeStamp();
            var orderNumber = timeStamp + random.Next(1000, 10000).ToString();
            return orderNumber;
        }


       protected void Button1_Click(object sender, EventArgs e)
       {

           SqlHelper data = new SqlHelper();


           if (strtype == "2")
           {
               yyong1();

               return;


           }



           if (this.xxzname.Text == null || this.xxzname.Text.ToString().Trim() == null || this.xxzname.Text == "")
           {

               Response.Write("<script language=javascript>alert('姓名不能为空！');</" + "script>");

               return;

           }

           if (this.xxztel.Text == null || this.xxztel.Text.ToString().Trim() == null || this.xxztel.Text == "")
           {

               Response.Write("<script language=javascript>alert('电话不能为空！');</" + "script>");

               return;

           }






           string xxzname = this.xxzname.Text.ToString().Trim();

           string xxztel = this.xxztel.Text.ToString().Trim();
           string yysj = this.yysj.Text.ToString().Trim();
           string yyaddress = this.yyaddress.Text.ToString().Trim();

           string yykstime = this.yykstime.Text.ToString().Trim();
           string yyjstime = this.yyjstime.Text.ToString().Trim();
           string sts = this.sts.Text.ToString().Trim();


           xxzname = xxzname.Replace("'", "''");
           xxztel = xxztel.Replace("'", "''");
           yysj = yysj.Replace("'", "''");
           yyaddress = yyaddress.Replace("'", "''");


           yykstime = yykstime.Replace("'", "''");
           yyjstime = yyjstime.Replace("'", "''");
           sts = sts.Replace("'", "''");



           string sql = "insert into xxyuyue(xxzname,xxztel,yysj,yyaddress,yykstime,yyjstime,sts) values";
           sql += "('" + xxzname + "','" + xxztel + "','" + yysj + "','" + yyaddress + "','" + yykstime + "','" + yyjstime + "','预约成功')";
           data.RunSql(sql);

           Alert.AlertAndRedirect("添加成功", "yuyuelist.aspx");

       }




       private void yyong1()
       {



           string xxzname = this.xxzname.Text.ToString().Trim();
           string xxztel = this.xxztel.Text.ToString().Trim();
           string yysj = this.yysj.Text.ToString().Trim();



           string yyaddress = this.yyaddress.Text.ToString().Trim();

           string yykstime = this.yykstime.Text.ToString().Trim();
           string yyjstime = this.yyjstime.Text.ToString().Trim();
           string sts = this.sts.Text.ToString().Trim();

           xxzname = xxzname.Replace("'", "''");
           xxztel = xxztel.Replace("'", "''");
           yysj = yysj.Replace("'", "''");
           yyaddress = yyaddress.Replace("'", "''");


           yykstime = yykstime.Replace("'", "''");
           yyjstime = yyjstime.Replace("'", "''");
           sts = sts.Replace("'", "''");




           string id = Request.QueryString["id"].ToString();

           string strsql="";



           strsql = " Update xxyuyue set xxzname='" + xxzname + "',xxztel='" + xxztel + "',yysj='" + yysj + "', yyaddress='" + yyaddress + "' , yykstime='" + yykstime + "' , yyjstime='" + yyjstime + "', sts='" + sts + "' where id =" + id;  


           data3.RunSql(strsql);

           Alert.AlertAndRedirect("修改成功", "yuyuelist.aspx");

       }
     





    protected void devicephotourl_Unload(object sender, EventArgs e)
    {

    }
    protected void drawingurl_Unload(object sender, EventArgs e)
    {

    }
    protected void result_Unload(object sender, EventArgs e)
    {

    }
    protected void zaikepufileurl_Unload(object sender, EventArgs e)
    {

    }
    protected void zaikepuurl_Unload(object sender, EventArgs e)
    {

    }
    protected void photourl_Unload(object sender, EventArgs e)
    {

    }
}