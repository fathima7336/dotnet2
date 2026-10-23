using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class registeration : System.Web.UI.Page
    {

		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=new_project;Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
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
		}
        

        protected void Button1_Click(object sender, EventArgs e)
        {
			string gender;
			string date = DropDownList1.Text + "/" + DropDownList2.Text + "/" + DropDownList3.Text;

			if (RadioButton1.Checked == true)
			{
				gender = "Male";
			}
			else
			{
				gender = "Female";
			}

			string qry = "insert into registration values ('" + name_text.Text + "','" + date + "','" + gender + "','" + phn_no.Text + "')";
			SqlCommand cmd = new SqlCommand(qry, con);
			string qry1 = "insert into Login_tb values('" + txt_email.Text + "','" + password.Text + "','admin')";
			SqlCommand cmd1 = new SqlCommand(qry1, con);
			con.Open();
			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			con.Close();
		}

		protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}