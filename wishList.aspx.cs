using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wishList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {


            Label1.Text = Session["userid"].ToString();

            if (Request.QueryString["id"] != null)
            {
                string itemid = Request.QueryString["id"].ToString();
                saveWishList(Label1.Text, itemid);


                Show();
            }


        }


    }
    private void Show()
    {

        SqlConnection scon = new SqlConnection(DBClass.connectionString);
        String myquery = "select * from wishlist where userid='" + Label1.Text + "'";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = scon;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataTable dt1 = new DataTable();
        da.Fill(dt1);
        GridView1.DataSource = dt1;
        GridView1.DataBind();

    }


    private void saveWishList(string userid,string itemid)
    {

        SqlConnection conn = new SqlConnection(DBClass.connectionString);

        string query = "insert into wishList(userid,itemid) values('" + userid + "','" + itemid +  "')";


        SqlCommand sqlCmd = new SqlCommand(query, conn);
        conn.Open();
        sqlCmd.ExecuteNonQuery();// insertion into db
        conn.Close();


    }



        

}