using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThankYou : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (Session["userid"]!=null)
       {

            string userid = Session["userid"].ToString();
            string query = "select * from Customer_Orders where Customerid='" + userid + "'";
           // string query = "select * from Customer_Orders where Customerid='a'";
            SqlConnection con = new SqlConnection(DBClass.connectionString);
            //Open database connection to connect to SQL Server
            con.Open();
            //Data table is used to bind the resultant data
            DataTable dtusers = new DataTable();
            // Create a new data adapter based on the specified query.
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SQl command builder is used to get data from database based on query
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            //Fill data table
            da.Fill(dtusers);
            con.Close();
            GridView1.DataSource = dtusers;
            GridView1.DataBind();




          Session.Abandon();

       }





       

    }

    SerialPort s;
    public void GetPort(string comport)
    {

        this.s = new SerialPort();
        this.s.PortName = comport;
        this.s.Open();
        this.s.BaudRate = 9600;
        this.s.Parity = Parity.None;
        this.s.DataBits = 8;
        this.s.StopBits = StopBits.One;
        this.s.Handshake = Handshake.RequestToSend;
        this.s.DtrEnable = true;
        this.s.RtsEnable = true;
        this.s.RtsEnable = true;
        this.s.NewLine = System.Environment.NewLine;
        this.s.WriteLine("AT" + (char)(13));

        string s = "0";

        Thread.Sleep(2000);
        this.s.WriteLine("AT+CMGF=1" + (char)(13));
        Thread.Sleep(3000);
        this.s.WriteLine("AT+CMGS=\"" + s + "\"");
        Thread.Sleep(5000);
        this.s.WriteLine(">" + "umar hayat test sms" + (char)(26));
        this.s.Close();


    }


}