using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6FS753E\SQLEXPRESS;Initial Catalog=new_project;Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{
				string query = "select * from registration";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DropDownList1.DataSource = dt;
				DropDownList1.DataTextField = "r_name";
				DropDownList1.DataValueField = "R_id";
				DropDownList1.DataBind();
			}
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			if (FileUpload1.HasFile)
			{
				FileUpload1.SaveAs(Server.MapPath("~/upimage/" + FileUpload1.FileName));

				Label1.Text = FileUpload1.FileName;
				SqlCommand cmd = new SqlCommand("INSERT INTO file_upload(file_name,R_id) VALUES('" + Label1.Text + "','" + DropDownList1.SelectedValue + "')", con);
				con.Open();
				cmd.ExecuteNonQuery(); 
				con.Close();
			}
			else
			{
				Label1.Text = "No File Uploaded.";
			}

		}
    }
}