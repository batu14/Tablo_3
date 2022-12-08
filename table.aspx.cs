using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tablo
{
    public partial class table : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=BATUHAN;Initial Catalog=ENVANTERKOD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tableCreator()
        {

            List<string> ürünler = new List<string>();
            List<string> Fiyat = new List<string>();
            List<string> Firma = new List<string>();
            baglanti.Open();
            string sql = "SELECT  DISTINCT( MalzemeninAdi)  FROM fiyatteklif";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ürünler.Add(dr["MalzemeninAdi"].ToString());
            }
            dr.Close();

            foreach (string ürün in ürünler)
            {
                string sql2 = "select  Fiyatı,Firma from fiyatteklif where MalzemeninAdi = '" + ürün.ToString()+"'  order by Fiyatı ASC";
                SqlCommand cmd = new SqlCommand(sql2, baglanti);
                SqlDataReader dr2 = cmd.ExecuteReader();
                TableRow satır = new TableRow();
                TableCell hücre = new TableCell();
                hücre.Text = ürün;
                hücre.CssClass = "FCell";
                satır.Cells.Add(hücre);
                for (int i = 0; i < Fiyat.Count; i++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = Fiyat[i] + Firma[i];

                    satır.Cells.Add(cell);

                }
                Tablo.Rows.Add(satır);
                while (dr2.Read())
                {
                    //Response.Write("<br/>" +ürün + dr2["Firma"].ToString() +" " + dr2["Fiyatı"].ToString() + "<br/>");
                    for (int i = 0; i < dr2.VisibleFieldCount; i++)
                    {
                        TableCell cell = new TableCell();
                        cell.Text = dr2[i].ToString();
                        satır.Cells.Add(cell);

                    }


                }
                dr2.Close();




               

             
            }
           


            baglanti.Close();







        }

        protected void btn_Click1(object sender, EventArgs e)
        {
            tableCreator();
        }
    }
}