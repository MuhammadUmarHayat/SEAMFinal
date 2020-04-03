using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            Label4.Text = Session["userid"].ToString();


        }



        SqlConnection con = new SqlConnection(DBClass.connectionString);

        con.Open();

        SqlCommand cmd = new SqlCommand("", con);

        cmd.CommandType = System.Data.CommandType.Text;

        cmd.CommandText = "SELECT DISTINCT title from category";

        SqlDataAdapter adpt = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        adpt.SelectCommand = cmd;

        adpt.Fill(ds);



        // bind domain with the dropdownlist



        DropDownList1.DataTextField = "title";

        DropDownList1.DataValueField = "title";

        DropDownList1.DataSource = ds;

        DropDownList1.DataBind();

        con.Close();
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToString();
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        Label2.Text = Calendar1.SelectedDate.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string userid, usertype, status;
        userid = Label4.Text;
        usertype = "suplier";
        status = "ok";

        FileUpload1.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(FileUpload1.FileName));
        string link = "images/" + Path.GetFileName(FileUpload1.FileName);

        SqlConnection conn = new SqlConnection(DBClass.connectionString);                                                                                     //Items(title, category, unitPrice, quantity, ManDate, ExpiryDate, image, Remarks)

        string query = "insert into Items(title,category,unitPrice,quantity,ManDate,ExpiryDate,image,Remarks,userid,usertype,status) values ('" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + link + "','" + TextBox4.Text + "','" + userid + "','" + usertype + "','" + status + "')";


        SqlCommand sqlCmd = new SqlCommand(query, conn);
        conn.Open();
        sqlCmd.ExecuteNonQuery();// insertion into db
        conn.Close();
        Label3.Text = "Record is save seccessfully";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierItems.aspx");
    }
}