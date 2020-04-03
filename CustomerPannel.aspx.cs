using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerPannel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        showAll();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        



            int count = DataList1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                Label lbl = DataList1.Items[i].FindControl("Label4") as Label;
                string itemid = lbl.Text;
                Label1.Text = "Item ID " + itemid;

                TextBox txt = DataList1.Items[i].FindControl("TextBox2") as TextBox;
                string quantity = txt.Text;
                Label2.Text = "Quantity  " + quantity;
            }

    }
    //<asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" vCellPadding="10" DataKeyField="product_id" DataSourceID="SqlDataSource1" RepeatColumns="2">

      //  <asp:Button ID = "ButtonAddToCart" runat="server" Text="Add to Cart" CommandName="addtocart2" />



    private void showAll()
    {
        string query = "select * from items";

      // SqlConnection con = new SqlConnection(DBClass.connectionString);
        SqlConnection con = new SqlConnection(DBClass.connectionString);
        //Open database connection to connect to SQL Server
        con.Open();
        //Data table is used to bind the resultant data
        DataTable dt = new DataTable();
        // Create a new data adapter based on the specified query.
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        //SQl command builder is used to get data from database based on query
        SqlCommandBuilder cmd = new SqlCommandBuilder(da);
        //Fill data table
        da.Fill(dt);
        con.Close();
        DataList1.DataSource = dt;
        DataList1.DataBind();


    }



    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int count = DataList1.Items.Count;
        for (int i = 0; i < count; i++)
        {
            Label lbl = DataList1.Items[i].FindControl("Label4") as Label;
            string itemid = lbl.Text;
            Label1.Text = "Item ID "+itemid;

            Label lbl2 = DataList1.Items[i].FindControl("TextBox2") as Label;
            string quantity= lbl2.Text;
            Label1.Text = "Item ID " + quantity;
        }




    }


   

    protected void DataList1_ItemDataBound1(object sender, DataListItemEventArgs e)
    {
       




    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "addtocart")
        {

            DropDownList dlist = (DropDownList)(e.Item.FindControl("DropDownList1"));
            Response.Redirect("AddtoCart.aspx?id=" + e.CommandArgument.ToString() + "&unitPrice=" + dlist.SelectedItem.ToString());

        }

    }
}