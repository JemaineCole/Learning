using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;                 //use for sql connection
using System.Data.SqlClient;    //use for sql connection

namespace aspDotNetCrud
{
    public partial class Contact : System.Web.UI.Page
    {
        //sql connection string
        SqlConnection sqlCon = new SqlConnection(@"Data Source = (local)\STUDIOJC-PC; Initial Catalog = TSQLV4; Integrated Security = true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btClear_Click(object sender, EventArgs e)
        {
            //calling Clear function
            Clear();
        }

        //defining function for clear button
        public void Clear()
        {
            txtEmployeeID.Text = "";

            lblErrorMsg.Text = "";
            lblSuccessMsg.Text = "";

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        /*protected void btDisplay_Click(object sender, EventArgs e)
        {
            //check if sql connection closed then open
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand("getContact", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@empID", Convert.ToInt32(txtEmployeeID.Text));
            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();
            Clear();
        }*/

    }
}