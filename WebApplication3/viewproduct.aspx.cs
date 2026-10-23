using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class WebForm4 : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=product;Integrated Security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				int i, j, k;

				for (i = 1; i <= 31; i++)
				{
					DropDownList1.Items.Add(i.ToString());
				}

				for (j = 1; j <= 12; j++)
				{
					DropDownList2.Items.Add(j.ToString());
				}

				for (k = 2024; k <= 2035; k++)
				{
					DropDownList3.Items.Add(k.ToString());
				}

				Grid();
			}
		}

		public void Grid()
		{
			string qry = "select * from Table_1";
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			GridView1.DataSource = dt;
			GridView1.DataBind();
		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			int p_id_val = Convert.ToInt32((sender as LinkButton).CommandArgument);
			string qry = "select * from Table_1 where p_id=" + p_id_val + "";
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				p_id.Text = dt.Rows[0][0].ToString();
				p_name.Text = dt.Rows[0][1].ToString();
				qty.Text = dt.Rows[0][3].ToString();
				company.Text = dt.Rows[0][4].ToString();

				DateTime expiry = Convert.ToDateTime(dt.Rows[0][2]);
				DropDownList1.SelectedValue = expiry.Day.ToString();
				DropDownList2.SelectedValue = expiry.Month.ToString();
				DropDownList3.SelectedValue = expiry.Year.ToString();
			}
		}

		protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

		protected void p_name_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click1(object sender, EventArgs e)
		{
			string expirydate = DropDownList1.Text + "/" + DropDownList2.Text + "/" + DropDownList3.Text;

			string qry = "update Table_1 set p_name='" + p_name.Text + "',expirydate='" + expirydate + "',qty='" + qty.Text + "',company='" + company.Text + "' where p_id='" + p_id.Text + "'";
			SqlCommand cmd = new SqlCommand(qry, con);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

			Grid();

			p_name.Text = "";
			qty.Text = "";
			company.Text = "";
			DropDownList1.SelectedIndex = 0;
			DropDownList2.SelectedIndex = 0;
			DropDownList3.SelectedIndex = 0;
		}

		protected void LinkButton_Click(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Click1(object sender, EventArgs e)
		{

		}

		protected void LinkButton_Click1(object sender, EventArgs e)
		{
			int p_id_val = Convert.ToInt32((sender as LinkButton).CommandArgument);

			string qry = "delete from Table_1 where p_id=" + p_id_val + "";
			SqlCommand cmd = new SqlCommand(qry, con);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
			Grid();
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			string qry = "select * from Table_1 where p_name='" + p_id.Text + "'";
			SqlCommand cmd3 = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd3);
			DataTable dt = new DataTable();
			da.Fill(dt);  
			GridView1.DataSource = dt;
			GridView1.DataBind();
		}

		protected void search_Click(object sender, EventArgs e)
		{
			string qry = "select * from Table_1 where p_name='" + TextBox1.Text + "'";
			SqlCommand cmd3 = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd3);
			DataTable dt = new DataTable();
			da.Fill(dt);
			GridView1.DataSource = dt;
			GridView1.DataBind();
		}
	}
}