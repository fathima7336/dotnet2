using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class WebForm1 : System.Web.UI.Page
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
			}
		}

		protected void password_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string expirydate = DropDownList1.Text + "/" + DropDownList2.Text + "/" + DropDownList3.Text;

			string qry = "insert into Table_1 (p_name, expirydate, p_id, qty, company) values (@pname, @expiry, @pid, @qty, @company)";
			SqlCommand cmd = new SqlCommand(qry, con);
			cmd.Parameters.AddWithValue("@pname", p_name.Text);
			cmd.Parameters.AddWithValue("@expiry", expirydate);
			cmd.Parameters.AddWithValue("@pid", p_id.Text);
			cmd.Parameters.AddWithValue("@qty", qty.Text);
			cmd.Parameters.AddWithValue("@company", company.Text);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}

		
	}
}