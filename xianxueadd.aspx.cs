using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class xianxue_xianxueadd : System.Web.UI.Page
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




        //if (Session["type"].ToString() != "0")
        //{

        //    Alert.AlertAndRedirect("普通用户不能操作！", "DecorativeRooflist.aspx");

        //}

        if (Request.QueryString["type"] == null)
        {
            strtype = "1";
        }
        else
        {
            strtype = Request.QueryString["type"].ToString();
        }


        //if (Session["type"].ToString() != "0" && strtype != "1")
        //{

        //    Alert.AlertAndRedirect("普通用户不能操作11！", "DecorativeRooflist.aspx");

        //}

        
        
        if (!IsPostBack)
        {

            if (Session["mima"] == null || Session["mima"].ToString().Trim()=="")
            {
                Response.Write("<script language=javascript>alert('请先登录!');window.location.href='.././Default.aspx'</script>");
            }

                    // strtype = Request.QueryString["type"].ToString();
                //if (strtype == "3")
                //{


       


                //    string id = Request.QueryString["id"].ToString();
                //    string strsql = "select * from Decorativeroof where ID=" + id;
                //    DataSet ds = data4.GetDs(strsql, "ds");

                //    this.name.Text = ds.Tables[0].Rows[0]["name"].ToString().Trim();
                //   // this.devicephotourl. = ds.Tables[0].Rows[0]["name"].ToString().Trim();



                //    this.type.Text = ds.Tables[0].Rows[0]["type"].ToString().Trim();

                //    this.sctime.Text = ds.Tables[0].Rows[0]["sctime"].ToString().Trim();

                //    this.qux.Text = ds.Tables[0].Rows[0]["qux"].ToString().Trim();

                //    this.cjbtime.Text = ds.Tables[0].Rows[0]["cjbtime"].ToString().Trim();


                //    this.cjetime.Text = ds.Tables[0].Rows[0]["cjetime"].ToString().Trim();
                //    this.address.Text = ds.Tables[0].Rows[0]["address"].ToString().Trim();



                //    this.yyflag.Text = ds.Tables[0].Rows[0]["yyflag"].ToString().Trim();
                //    this.yycs.Text = ds.Tables[0].Rows[0]["yycs"].ToString().Trim();
                //    this.yyqx.Text = ds.Tables[0].Rows[0]["yyqx"].ToString().Trim();
                //    this.yyjieg.Text = ds.Tables[0].Rows[0]["yyjieg"].ToString().Trim();



                //    this.type.ReadOnly = true;

                //    this.sctime.ReadOnly = true;

                //    this.qux.ReadOnly = true;
                //    this.cjbtime.ReadOnly = true;

                //    this.cjetime.ReadOnly = true;
                //    this.address.ReadOnly = true;



                //    this.yyflag.ReadOnly = false;

                //    this.yycs.ReadOnly = false;
                //    this.yyqx.ReadOnly = false;
                //    this.yyjieg.ReadOnly = false;
                
                //}


                if (strtype == "2")
                {


                    if (Session["type"].ToString() != "0")
                    {

                        Alert.AlertAndRedirect("普通用户不能修改！", "DecorativeRooflist.aspx");
                        return;

                    }
                    
                    
                    
                    string id = Request.QueryString["id"].ToString();
                    string strsql = "select * from xianxuejilu where ID=" + id;
                    DataSet ds = data4.GetDs(strsql, "ds");

                    //this.name.Text = ds.Tables[0].Rows[0]["name"].ToString().Trim();

                    this.xxzname.Text = ds.Tables[0].Rows[0]["xxzname"].ToString().Trim();

                    this.xxztel.Text = ds.Tables[0].Rows[0]["xxztel"].ToString().Trim();

                    this.riqi.Text = ds.Tables[0].Rows[0]["riqi"].ToString().Trim();

                    this.xueliang.Text = ds.Tables[0].Rows[0]["xueliang"].ToString().Trim();


                    this.xuexing.Text = ds.Tables[0].Rows[0]["xuexing"].ToString().Trim();
                    this.didian.Text = ds.Tables[0].Rows[0]["didian"].ToString().Trim();

                    this.jiankang.Text = ds.Tables[0].Rows[0]["jiankang"].ToString().Trim();
                    this.caixueren.Text = ds.Tables[0].Rows[0]["caixueren"].ToString().Trim();




                    this.xxzname.ReadOnly = false;

                    this.xxztel.ReadOnly = false;

                    this.riqi.ReadOnly = false;
                    this.xueliang.ReadOnly = false;

                    this.xuexing.ReadOnly = false;
                    this.didian.ReadOnly = false;



                    this.jiankang.ReadOnly = false;

                    this.caixueren.ReadOnly = false;
             

                }

                if (strtype == "1")
                {
                    //this.yyflag.ReadOnly = true;

                    //this.yycs.ReadOnly = true;
                    //this.yyqx.ReadOnly = true;
                    //this.yyjieg.ReadOnly = true;


                }


                //if (Session["type"].ToString() == "" || Session["type"] == null || Session["type"].ToString() != "0")
                //{

                //    Response.Write("<script language=javascript>alert('无增加权限!');window.location.href='.././experimental/typelist.aspx'</script>");

                //    return;

                //}




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
           //strdevicephotourl = null;


           //if (strtype == "3")
           //{
           //    yyong();

           //    return;
           
           
           //}

           if (strtype == "2")
           {
               yyong1();

               return;


           }



           if (this.xxztel.Text == null || this.xxztel.Text.ToString().Trim() == null || this.xxztel.Text == "")
           {

               Response.Write("<script language=javascript>alert('电话不能为空！');</" + "script>");

               return;

           }

           if (this.xxzname.Text == null || this.xxzname.Text.ToString().Trim() == null || this.xxzname.Text == "")
           {

               Response.Write("<script language=javascript>alert('姓名不能为空！');</" + "script>");

               return;

           }



           if (this.riqi.Text == null || this.riqi.Text.ToString().Trim() == null || this.riqi.Text == "")
           {

               Response.Write("<script language=javascript>alert('日期不能为空！');</" + "script>");

               return;

           }


           if (this.xueliang.Text == null || this.xueliang.Text.ToString().Trim() == null || this.xueliang.Text == "")
           {

               Response.Write("<script language=javascript>alert('血量不能为空！');</" + "script>");

               return;

           }

           if (this.xuexing.Text == null || this.xuexing.Text.ToString().Trim() == null || this.xuexing.Text == "")
           {

               Response.Write("<script language=javascript>alert('血型不能为空！');</" + "script>");

               return;

           }



           string xxzname = this.xxzname.Text.ToString().Trim();

           string xxztel = this.xxztel.Text.ToString().Trim();
           string riqi = this.riqi.Text.ToString().Trim();
           string xueliang = this.xueliang.Text.ToString().Trim();
           string xuexing = this.xuexing.Text.ToString().Trim();
           string didian = this.didian.Text.ToString().Trim();
           string jiankang = this.jiankang.Text.ToString().Trim();
         //  string lrtime = DateTime.Now.ToString();
          // string caixueren = Session["admin"].ToString();
           string caixueren = this.caixueren.Text.ToString().Trim();



           xxzname = xxzname.Replace("'", "''");
           xxztel = xxztel.Replace("'", "''");
           riqi = riqi.Replace("'", "''");
           xueliang = xueliang.Replace("'", "''");
           xuexing = xuexing.Replace("'", "''");
           didian = didian.Replace("'", "''");
           jiankang = jiankang.Replace("'", "''");
           caixueren = caixueren.Replace("'", "''");

           string sql = "insert into xianxuejilu(xxzname,xxztel,riqi,xueliang,xuexing,didian,jiankang,caixueren) values";
           sql += "('" + xxzname + "','" + xxztel + "','" + riqi + "','" + xueliang + "','" + xuexing + "','" + didian + "','" + jiankang + "','" + caixueren +  "') ";
           data.RunSql(sql);

           Alert.AlertAndRedirect("添加成功", "xianxuelist.aspx");

       }

       //private void yyong()
       //{


       //    string yyflag = this.yyflag.Text.ToString().Trim();
       //    string yycs = this.yycs.Text.ToString().Trim();
       //    string yyqx = this.yyqx.Text.ToString().Trim();
       //    string yyjieg = this.yyjieg.Text.ToString().Trim();



       //    yyflag = yyflag.Replace("'", "''");
       //    yycs = yycs.Replace("'", "''");
       //    yyqx = yyqx.Replace("'", "''");
       //    yyjieg = yyjieg.Replace("'", "''");


       //    string id = Request.QueryString["id"].ToString();
       //    string strsql = " Update Decorativeroof set yyflag='" + yyflag + "',yycs='" + yycs + "',yyqx='" + yyqx + "', yyjieg='" + yyjieg + "' where id =" + id;

       //    data3.RunSql(strsql);

       //    Alert.AlertAndRedirect("引用操作成功", "DecorativeRooflist.aspx");   
     
       //}




       private void yyong1()
       {



           string xxzname = this.xxzname.Text.ToString().Trim();
           string xxztel = this.xxztel.Text.ToString().Trim();
           string riqi = this.riqi.Text.ToString().Trim();



           string xueliang = this.xueliang.Text.ToString().Trim();
           string xuexing = this.xuexing.Text.ToString().Trim();
           string didian = this.didian.Text.ToString().Trim();
           string jiankang = this.jiankang.Text.ToString().Trim();


           string caixueren = this.caixueren.Text.ToString().Trim();



           xxzname = xxzname.Replace("'", "''");
           xxztel = xxztel.Replace("'", "''");
           riqi = riqi.Replace("'", "''");
           xueliang = xueliang.Replace("'", "''");


           xuexing = xuexing.Replace("'", "''");
           didian = didian.Replace("'", "''");
           jiankang = jiankang.Replace("'", "''");
           caixueren = caixueren.Replace("'", "''");


           string id = Request.QueryString["id"].ToString();

           string strsql="";

           //if (string.IsNullOrEmpty(this.name.Text))
           //{

           //    strsql = " Update Decorativeroof set yyflag='" + yyflag + "',yycs='" + yycs + "',yyqx='" + yyqx + "', yyjieg='" + yyjieg + "', type='" + type + "', sctime='" + sctime + "', qux='" + qux + "', cjbtime='" + cjbtime + "', cjetime='" + cjetime + "', address='" + address + "' where id =" + id;

           //}
           //else
           //{

           //    strsql = " Update Decorativeroof set yyflag='" + yyflag + "',yycs='" + yycs + "',yyqx='" + yyqx + "', yyjieg='" + yyjieg + "', type='" + type + "', sctime='" + sctime + "', qux='" + qux + "', cjbtime='" + cjbtime + "', cjetime='" + cjetime + "', address='" + address + "', name='" + this.name.Text + "', photourl='" + strdevicephotourl + "'  where id =" + id;  

           //}


           strsql = " Update xianxuejilu set xxzname='" + xxzname + "',xxztel='" + xxztel + "',riqi='" + riqi + "', xueliang='" + xueliang + "', xuexing='" + xuexing + "', didian='" + didian + "', jiankang='" + jiankang + "', caixueren='" + caixueren + "'  where id =" + id;  


           data3.RunSql(strsql);

           Alert.AlertAndRedirect("修改成功", "xianxuelist.aspx");

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