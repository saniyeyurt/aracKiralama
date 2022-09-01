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
    public partial class frmMüsteriListeleme : Form
    {

        aracKiralama AracKiralama=new aracKiralama();
        public frmMüsteriListeleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMüsteriListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        private void YenileListele()
        {
            string cümle = "select *from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama.listele(adtr2, cümle);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from musteri where TC like ' % " + textBox1.Text " % ' " ;
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracKiralama.listele(adtr2, cümle);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txttc.Text = satır.Cells[0].Value.ToString();
            txtAdsoyad.Text = satır.Cells[0].Value.ToString();
            txtAdres.Text = satır.Cells[0].Value.ToString();
            txtMail.Text = satır.Cells[0].Value.ToString();
            txtTelefon.Text = satır.Cells[0].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cümle = "update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";

            SqlCommand komut2=new SqlCommand();

            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@email", txtMail.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            AracKiralama.insert_delete_update(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
            
        }
    }
}
