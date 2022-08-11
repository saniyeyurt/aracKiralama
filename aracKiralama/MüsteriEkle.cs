using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class MüsteriEkle : Form
    {
        aracKiralama arac_kiralama=new aracKiralama();
        public MüsteriEkle()
        {
            InitializeComponent();
        }

        private void MüsteriEkle_Load(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba dünya");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müsteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";

            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@email", txtMail.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            arac_kiralama.insert_delete_update(komut2,cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";


        }
    }
}
