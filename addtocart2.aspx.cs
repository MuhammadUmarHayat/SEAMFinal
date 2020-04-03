using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addtocart2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {


            Label3.Text = Session["userid"].ToString();
        }


            DataTable dt = new DataTable();
        DataRow dr;
        string gtotal = "";
        if (!IsPostBack)
        {

            #region NotispostBack

            dt.Columns.Add("sno");
            dt.Columns.Add("itemid");
            dt.Columns.Add("title");
            dt.Columns.Add("quantity");
            dt.Columns.Add("unitPrice");
            dt.Columns.Add("Total");
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
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);

                    dr["sno"] = 1;
                    dr["itemid"] = dt1.Rows[0]["itemid"].ToString();
                    dr["title"] = dt1.Rows[0]["title"].ToString();
                    dr["unitPrice"] = dt1.Rows[0]["unitPrice"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["image"] = dt1.Rows[0]["image"].ToString();


                    int price = Convert.ToInt16(dt1.Rows[0]["unitPrice"].ToString());

                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;

                    dr["Total"] = totalprice;


                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();



                    Session["buyitems"] = dt;
                  

                    if (GridView1.Rows.Count > 0)
                    {

                        gtotal = grandtotal().ToString();

                    }

                    Label2.Text = " Grand Total : " + gtotal;


                   Response.Redirect("addtocart2.aspx");





                }




                #endregion



                else
                {
                    #region postBack


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
                    DataTable dt2 = new DataTable();
                    da.Fill(dt2);

                    dr["sno"] = sr + 1;
                    dr["itemid"] = dt2.Rows[0]["itemid"].ToString();
                    dr["title"] = dt2.Rows[0]["title"].ToString();
                    dr["unitPrice"] = dt2.Rows[0]["unitPrice"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["image"] = dt2.Rows[0]["image"].ToString();


                    int price = Convert.ToInt16(dt2.Rows[0]["unitPrice"].ToString());

                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;

                    dr["Total"] = totalprice;


                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                   
                   Response.Redirect("addtocart2.aspx");

                    if (GridView1.Rows.Count > 0)
                    {

                        gtotal = grandtotal().ToString();

                    }

                    Label2.Text = " Grand Total : " + gtotal;

                    #endregion



                }
            }
            else
            {


                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();

                if (GridView1.Rows.Count > 0)
                {
                 
                    gtotal = grandtotal().ToString();

                }

                Label2.Text = " Grand Total : "+gtotal;

            }
            Label1.Text = GridView1.Rows.Count.ToString();
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
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["total"].ToString());

            i = i + 1;
        }
        return gtotal;
    }

















    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];


        for (int i = 0; i <= dt.Rows.Count - 1; i++)
        {
            int sr;
            int sr1;
            string qdata;
            string dtdata;
            sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[1];
            qdata = cell.Text;
            dtdata = sr.ToString();
            sr1 = sr;

            if (sr == sr1)
            {
                dt.Rows[i].Delete();
                dt.AcceptChanges();
                Label1.Text = "Item Has Been Deleted From Shopping Cart";
                Response.Redirect("addtocart2.aspx");
                string gtotal="";

                if (GridView1.Rows.Count > 0)
                {

                    gtotal = grandtotal().ToString();

                }

                Label2.Text = " Grand Total : " + gtotal;





                break;

            }
        }
    }

    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.RowIndex];

        String str = ((TextBox)(row.Cells[5].Controls[0])).Text;

        int id = Convert.ToInt32(e.NewValues[0]);

        string q = str;// e.NewValues[1].ToString();
        string numberR = e.NewValues[5].ToString();

        DataTable dt = (DataTable)Session["buyitems"];

        dt.Rows[0]["quantity"] = q;
        // dt.Rows[0]["Number"] = numberR;

        dt.AcceptChanges();

        GridView1.DataSource = dt;
        GridView1.DataBind();


    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {


       //GridView1.EditIndex = e.NewEditIndex;

        DataTable dt = (DataTable)Session["buyitems"]; 

        dt.Rows[0]["quantity"] = 5;
        // dt.Rows[0]["Number"] = numberR;

        dt.AcceptChanges();

        GridView1.DataSource = dt;
        GridView1.DataBind();


    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        GridView1.EditIndex = -1;
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("EditOrder.aspx?sno=" + GridView1.SelectedRow.Cells[0].Text);
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {




    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        //check out button

        btnCashOndelivery.Visible = true;
        btnCreditCard.Visible = true;
        btnOnlinePayment.Visible = true;


        Label4.Visible = true;
        Label5.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        ImageButton1.Visible = false;


       
        






    }


    private void SaveOrder(string customerID,string itemid, string q, string total)
    {
        Random random = new Random();
        int randomNumber = random.Next(123456,999999999);
        string orderId = "Order# "+ randomNumber;

        string status = "pending";
        SqlConnection conn = new SqlConnection(DBClass.connectionString);

        string query = "insert into Customer_Orders(orderid,itemId,quantity,total,date,status,CustomerId,DeliveryDate,DeliveryTime,month,year) values('"+orderId+"','" +itemid +"','" + q+ "','" + total+ "','" + DateTime.Now + "','" + status + "','" + customerID + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTime.Now.Month + "','" + DateTime.Now.Year + "')";
        string d = DateTime.Now.Date.ToString();

        SqlCommand sqlCmd = new SqlCommand(query, conn);
        conn.Open();
        sqlCmd.ExecuteNonQuery();// insertion into db
        conn.Close();

        SavePaymentDetails(customerID,  orderId, d, TextBox3.Text, TextBox4.Text, TextBox3.Text, TextBox4.Text, total);

        Response.Redirect("ThankYou.aspx");

    }

    private void SavePaymentDetails(string CustomerId, string orderId, string date,  string bankName, string bankAccount, string creditCardNo, string ExpiryDate, string total)
    {
        string PaymentType = "";
        string s = Label6.Text;

        if(s.Equals("Enter Credit Card Number"))
        {


            PaymentType = "Payment Through credit card";
        }
        else if (s.Equals("Enter Your Bank Name"))
        {

            PaymentType = "Payment Through online bank transfer";

        }
        else if (s.Equals("Cash on Delivery"))
        {

            PaymentType = "Payment Through Cash on Delivery";

        }



        string status = "pending";


        SqlConnection conn = new SqlConnection(DBClass.connectionString);
                                                                                                                                                                                       //(CustomerId,orderId,date,PaymentType,bankName,bankAccount,creditCardNo,ExpiryDate,total,status)
        string query = "insert into PaymentDetails(CustomerId,orderId,date,PaymentType,bankName,bankAccount,creditCardNo,ExpiryDate,total,status) values('" + CustomerId + "','" + orderId + "','" + DateTime.Now + "','" + PaymentType+ "','" + bankName + "','" + bankAccount + "','" + creditCardNo + "','" + ExpiryDate + "','" + total + "','" + status + "')";


        SqlCommand sqlCmd = new SqlCommand(query, conn);
        conn.Open();
        sqlCmd.ExecuteNonQuery();// insertion into db
        conn.Close();



    }



    protected void btnCashOndelivery_Click(object sender, ImageClickEventArgs e)
    {
        //cash on Delivery Button

        btnCashOndelivery.Visible = false;
        btnCreditCard.Visible = false;
        btnOnlinePayment.Visible = false;

        btnOrder.Visible = true;

      
        //order now
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        ImageButton1.Visible = false;

        Label6.Text = "Cash on Delivery"; 

        DataTable dt = (DataTable)Session["buyitems"];

        int size = dt.Rows.Count;

        for (int i = 0; i < size; i++)
        {
            //fetching the single row
            string itemid = dt.Rows[i]["itemid"].ToString();
            string t = dt.Rows[i]["title"].ToString();
            string q = dt.Rows[i]["quantity"].ToString();
            string u = dt.Rows[i]["unitPrice"].ToString();
            string total = dt.Rows[i]["total"].ToString();




        }


    }

    protected void btnCreditCard_Click(object sender, ImageClickEventArgs e)
    {
        // credit card button

        btnCashOndelivery.Visible = false;
        btnCreditCard.Visible = false;
        btnOnlinePayment.Visible = false;


        //order now
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
       

        TextBox1.Visible = true;
        TextBox2.Visible = true;

        TextBox3.Visible = true;
        TextBox4.Visible = true;

        TextBox5.Visible = true;

        ImageButton1.Visible = false;
        btnOrder.Visible = true;

    }

    protected void btnOnlinePayment_Click(object sender, ImageClickEventArgs e)
    {
        //online money transfer via bank

        btnCashOndelivery.Visible = false;
        btnCreditCard.Visible = false;
        btnOnlinePayment.Visible = false;


        //order now
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = false;


        TextBox1.Visible = true;
        TextBox2.Visible = true;

        TextBox3.Visible = true;
        TextBox4.Visible = true;

        TextBox5.Visible = false;

        ImageButton1.Visible = false;


        btnOrder.Visible = true;   

        Label6.Text = "Enter Your Bank Name";
        Label7.Text = "Enter Your Bank Account No along with Branch code";

    }

    protected void btnOrder_Click(object sender, ImageClickEventArgs e)
    {
        string customerId = Label3.Text;
        DataTable dt = (DataTable)Session["buyitems"];

        int size = dt.Rows.Count;

        for (int i = 0; i < size; i++)
        {
            //fetching the single row
            string itemid = dt.Rows[i]["itemid"].ToString();
            string t = dt.Rows[i]["title"].ToString();
            string q = dt.Rows[i]["quantity"].ToString();
            string u = dt.Rows[i]["unitPrice"].ToString();
            string total = dt.Rows[i]["total"].ToString();


            SaveOrder(customerId, itemid,  q, total);




        }






    }




}