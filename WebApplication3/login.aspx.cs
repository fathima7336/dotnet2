using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class WebForm6 : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=new_project;Integrated Security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Label1.Visible = false;
			}
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string query = "select * from login_tb where email=@email and pwd=@pwd";
			using (SqlCommand cmd = new SqlCommand(query, con))
			{
				cmd.Parameters.AddWithValue("@email", TextBox1.Text);
				cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);

				con.Open();

				DataTable dt = new DataTable();
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}

				con.Close();

				if (dt.Rows.Count > 0)
				{
					Session["reg_id"] = dt.Rows[0][0].ToString();
					Response.Redirect("AdminHome.aspx");
				}
				else
				{
					Label1.Visible = true;
					Label1.Text = "Invalid username or password";
				}
			}
		}
	}
}