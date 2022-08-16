using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüsteriEkle ekle = new MüsteriEkle();
            ekle.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMüsteriListeleme listele=new frmMüsteriListeleme();
            listele.ShowDialog();  
        }
    }
}
