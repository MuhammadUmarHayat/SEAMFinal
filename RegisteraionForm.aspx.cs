using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisteraionForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(DBClass.connectionString);

        string query = "insert into users(userid,Password,Name,Address,MobileNo,Email,SecQuestion,SecAnswer,UserType,status) values ('"+TextBox1.Text+"','"+ TextBox2.Text + "','"+ TextBox3.Text + "','"+ TextBox4.Text + "','"+ TextBox5.Text + "','"+ TextBox6.Text + "','"+ TextBox7.Text + "','"+ TextBox8.Text + "','"+RadioButtonList1.Text+"','ok')";


        SqlCommand sqlCmd = new SqlCommand(query, conn);
        conn.Open();
        sqlCmd.ExecuteNonQuery();// insertion into db
        conn.Close();
        Label1.Text = "User is registered seccessfully";



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegisteraionForm");
    }
}