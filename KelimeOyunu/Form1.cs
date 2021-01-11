using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =D:\Eğitimlerim\UDEMY C# -Murat Yücedağ\25 Derste 25 Proje C#\İNGİLİZCE KELİME OYUNU\dbSozluk.mdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;
        void getir()
        {
            int sayi;
            sayi = rast.Next(0, 2490);


            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtingilizce.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text = lblcevap.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
            
        }

     
        private void txtturkce_TextChanged(object sender, EventArgs e)
        {
            if (txtturkce.Text==lblcevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                getir();
                txtturkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                txtturkce.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
