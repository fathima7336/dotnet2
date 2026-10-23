using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
	public class dboperation
	{

		public SqlConnection con;
		public SqlCommand cmd;

		public dboperation()
		{
			con = new SqlConnection("Data Source=LAPTOPLAB-15888\\SQLEXPRESS;Initial Catalog=aspnet_october_crud;Integrated Security=True");
			cmd = new SqlCommand();
			cmd.Connection = con;
		}

		public SqlConnection getcon()
		{
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			return con;
		}

		public void dbClose()
		{
			con.Close();
		}

		public int exenonquery(String sql)
		{
			getcon();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			int i = cmd.ExecuteNonQuery();
			return i;
		}

		public DataTable exetable(String sql)
		{
			getcon();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dbClose();
			return dt;
		}

		public object exescalar(String sql)
		{
			getcon();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			object ob = cmd.ExecuteScalar();
			return ob;
		}

		public SqlDataReader exereader(String sql)
		{
			getcon();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			SqlDataReader dr = cmd.ExecuteReader();
			return dr;
		}

		public DataSet exedataset(String sql)
		{
			getcon();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;
		}
	}

	


}