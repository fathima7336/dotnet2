using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class WebForm5 : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				SqlConnection conProduct = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=product;Integrated Security=True");
				string qry = "select * from Table_1";
				SqlCommand cmd = new SqlCommand(qry, conProduct);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DropDownList1.DataSource = dt;
				DropDownList1.DataTextField = "p_name";
				DropDownList1.DataValueField = "p_id";
				DropDownList1.DataBind();
			}
		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Calendar1_SelectionChanged(object sender, EventArgs e)
		{

		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string selectedDate = Calendar1.SelectedDate.ToShortDateString();

			con.Open();

			// Check whether a stock row already exists for this product
			int count = 0;
			string checkQry = "select count(*) from stock_tb where p_id=@pid";
			using (SqlCommand checkCmd = new SqlCommand(checkQry, con))
			{
				checkCmd.Parameters.AddWithValue("@pid", DropDownList1.SelectedValue);
				count = Convert.ToInt32(checkCmd.ExecuteScalar());
			}

			string qry;
			if (count > 0)
			{
				qry = "update stock_tb set date=@date, qty=@qty where p_id=@pid";
			}
			else
			{
				qry = "insert into stock_tb (p_id, date, qty) values (@pid, @date, @qty)";
			}

			using (SqlCommand cmd = new SqlCommand(qry, con))
			{
				cmd.Parameters.AddWithValue("@pid", DropDownList1.SelectedValue);
				cmd.Parameters.AddWithValue("@date", selectedDate);
				cmd.Parameters.AddWithValue("@qty", TextBox1.Text);
				cmd.ExecuteNonQuery();
			}

			con.Close();

			TextBox1.Text = "";
		}
	}
}