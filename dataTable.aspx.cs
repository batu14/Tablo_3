using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace tablo
{
    public partial class dataTable : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=BATUHAN;Initial Catalog=ENVANTERKOD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void tableCreator(EventArgs e)
        {
            
            var colNames = new List<string>();
            var rowNames = new List<string>();
            string sql = "select * , Fiyatı FROM fiyatteklif order by MalzemeninAdi ASC";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rowNames.Add(dr["Fiyatı"].ToString());
                colNames.Add(dr["MalzemeninAdi"].ToString());
            }
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MalzemeninAdi");
            dataTable.Columns.Add("Fiyatı");
            for (int i = 0; i < colNames.Count; i++)
            {
                DataRow row = dataTable.NewRow();
                row["MalzemeninAdi"] = colNames[i];
                row["Fiyatı"] = rowNames[i];
                dataTable.Rows.Add(row);
            }
            dr.Close();
            

        }
    }
}