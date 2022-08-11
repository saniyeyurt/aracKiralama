using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracKiralama
{
    internal class aracKiralama
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-5I7N1N2/SQLEXPRESS;Initial Catalog=DbRentACar;Integrated Security=True");
        DataTable tablo;

        public void insert_delete_update(SqlCommand komut ,string sorgu)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery(); //işlemi onayylama

            baglantı.Close();
        }
    }
}
