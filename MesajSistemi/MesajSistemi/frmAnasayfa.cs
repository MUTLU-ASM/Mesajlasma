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

namespace MesajSistemi
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBTQ48V\SQLEXPRESS;Initial Catalog=Mesajlasma;Integrated Security=True");

        public void Temizle()
        {
            txtBaslik.Text = "";
            rchtxtMesaj.Text = "";
            msktxtAlici.Text = "";
            msktxtAlici.Focus();
        }
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from mesajlar where alici="+numara,baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            gridGelen.DataSource = dt1;
        }    
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from mesajlar where gonderen="+numara,baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridGiden.DataSource = dt2;
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();

            //Ad Soyad Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ad,soyad from kisiler where numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into mesajlar (gonderen,alici,baslik,icerik) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", msktxtAlici.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rchtxtMesaj.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız gönderildi.");
            gidenkutusu();
            Temizle();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
