using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddtoCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
         //   dt.Columns.Add("sno");
            dt.Columns.Add("itemid");
            dt.Columns.Add("title");
            dt.Columns.Add("quantity");
            dt.Columns.Add("unitPrice");
          //  dt.Columns.Add("totalprice");
            dt.Columns.Add("image");


            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                  // String mycon = "Data Source=HP-PC\\SQLEXPRESS;Initial Catalog=haritiShopping;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(DBClass.connectionString);
                    String myquery = "select * from items where itemid=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    //dr["sno"] = 1;
                    dr["itemid"] = ds.Tables[0].Rows[0]["itemid"].ToString();
                    dr["title"] = ds.Tables[0].Rows[0]["title"].ToString();
                    dr["quantity"] = ds.Tables[0].Rows[0]["quantity"].ToString();
                    dr["unitPrice"] = Request.QueryString["unitPrice"];
                    //dr["totalprice"] = ds.Tables[0].Rows[0]["totalprice"].ToString();
                    dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;
                    //dr["totalprice"] = totalprice;
                    dr["unitPrice"] = totalprice;
                   dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                  //  GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                   // String mycon = "Data Source=HP-PC\\SQLEXPRESS;Initial Catalog=haritiShopping;Integrated Security=True";
                    SqlConnection scon = new SqlConnection(DBClass.connectionString);
                    String myquery = "select * from items where itemid=" + Request.QueryString["id"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                   // dr["sno"] = sr + 1;
                    dr["itemid"] = ds.Tables[0].Rows[0]["itemid"].ToString();
                    dr["title"] = ds.Tables[0].Rows[0]["title"].ToString();
                    dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["unitPrice"] = ds.Tables[0].Rows[0]["unitprice"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;
                    //dr["totalprice"] = totalprice;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                  //  GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                   // GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                }


            }
            Label2.Text = GridView1.Rows.Count.ToString();

        }

    }

    public int grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        int nrow = dt.Rows.Count;
        int i = 0;
        int gtotal = 0;
        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        return gtotal;
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id = GridView1.SelectedRow.Cells[0].Text;
        Response.Write("item Id  :  +>  " + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {


     //  int i= GridView1.SelectedRow.RowIndex;
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];

        // string id=  dt.Rows[i]["itemid"].ToString();


        // string id = GridView1.SelectedRow.["itemid"].ToString();




        // Get the currently selected row using the SelectedRow property.
        // GridViewRow row = GridView1.SelectedRow;

        // In this example, the first column (index 0) contains
        
       


    }


}
