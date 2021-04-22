using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace TestApp
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 1. Create a database connection object
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

                // you can also hard-code your connection string like the following:
                // conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\Northwind.mdf; Integrated Security = True; Connect Timeout = 30";
                // 2. Create a database command object 
                SqlCommand cmd = new SqlCommand();

                // 3. Assign a SQL query to the command object
                cmd.CommandText = "SELECT * FROM Customers";
                cmd.Connection = conn;
                // 4. Connect to the database
                conn.Open();

                // 5. Execute the query using the command object
                // 6. The command object will return a dataset that contains your data
                SqlDataReader reader = cmd.ExecuteReader();
                // 7. Finally, we need to discconect from the database

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TableRow tr = new TableRow();
                        TableCell tc = new TableCell();
                        tc.Text = reader["CustomerID"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["CustomerName"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["ContactName"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["Address"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["City"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["PostalCode"].ToString();
                        tr.Cells.Add(tc);

                        tc = new TableCell();
                        tc.Text = reader["Country"].ToString();
                        tr.Cells.Add(tc);

                        tblCustomers.Rows.Add(tr);
                    }
                }
            }
        }
    }
}