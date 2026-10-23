using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class view_registration : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=new_project;Integrated Security=True");

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

				for (k = 1900; k <= 2023; k++)
				{
					DropDownList3.Items.Add(k.ToString());
				}


				Grid();
			}
		}

		public void Grid()
		{
			string qry = "select * from Registration inner join login_tb on Registration.R_id = login_tb.l_id";
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			GridView1.DataSource = dt; 
			GridView1.DataBind();
		}
		protected void LinkButton1_Click(object sender, EventArgs e) 
		{
			int R_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
			string qry = "select * from Registration inner join login_tb on Login_tb.l_id=Registration.R_id where Registration.R_id=" + R_id + "";
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				string gen = dt.Rows[0][3].ToString();
				if (gen == "Male")
				{
					RadioButton1.Checked = true;
				}
				else
				{
					RadioButton2.Checked = true;
				}
				text_id.Text = dt.Rows[0][0].ToString();
				name_text.Text = dt.Rows[0][1].ToString();
				phn_no.Text = dt.Rows[0][4].ToString();
				txt_email.Text = dt.Rows[0][6].ToString();
				password.Text = dt.Rows[0][7].ToString();
				string dob = dt.Rows[0][2].ToString();
				string[] ab = dob.Split('/');
				DropDownList1.Text = ab[0].ToString();
				DropDownList2.Text = ab[1].ToString();
				DropDownList3.Text = ab[2].ToString();
			}


		}

		protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			
		}

		protected void name_text_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click1(object sender, EventArgs e)
		{
			string gen = "";
			string dob = DropDownList1.Text + "/" + DropDownList2.Text + "/" + DropDownList3.Text;

			if (RadioButton1.Checked == true)
			{
				gen = "Male";
			}
			else
			{
				gen = "Female";
			}

			string qry = "update Registration set R_name='" + name_text.Text + "',R_dob='" + dob + "',gender='" + gen + "' where R_id='" + text_id.Text + "'";
			SqlCommand cmd = new SqlCommand(qry, con);

			string qry1 = "update Login_tb set email='" + txt_email.Text + "',pwd='" + password.Text + "' where l_id='" + text_id.Text + "'";
			SqlCommand cmd1 = new SqlCommand(qry1, con);

			con.Open();
			cmd1.ExecuteNonQuery();
			cmd.ExecuteNonQuery();
			con.Close();

			Grid();

			name_text.Text = "";
			txt_email.Text = "";
			phn_no.Text = "";
			password.Text = "";
			RadioButton1.Checked = false;
			RadioButton2.Checked = false;
			DropDownList1.SelectedValue = "-1";
			DropDownList2.SelectedValue = "-1";
			DropDownList3.SelectedValue = "-1";

		}

		protected void LinkButton_Click(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Click1(object sender, EventArgs e)
		{
			
		}

		protected void LinkButton_Click1(object sender, EventArgs e)
		{
			int R_id = Convert.ToInt32((sender as LinkButton).CommandArgument);

			string qry = "delete from Registration where R_id=" + R_id + "";
			SqlCommand cmd = new SqlCommand(qry, con);

			string qry1 = "delete from login_tb where l_id=" + R_id + "";
			SqlCommand cmd2= new SqlCommand(qry1, con);

			con.Open();
			cmd.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			con.Close();
			Grid();
		}

		protected void Button2_Click(object sender, EventArgs e)
		 {
			string qry = "select * from Registration inner join Login_tb on Login_tb.l_id=Registration.R_id where R_name='" + TextBox1.Text + "'";
			SqlCommand cmd3 = new SqlCommand(qry, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd3);
			DataTable dt = new DataTable();
			da.Fill(dt);
			GridView1.DataSource = dt;
			GridView1.DataBind();


		}
	}
}