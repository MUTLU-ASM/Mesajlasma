using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MesajSistemi
{
    public partial class frmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBTQ48V\SQLEXPRESS;Initial Catalog=Mesajlasma;Integrated Security=True");
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From kisiler where numara=@p1 and sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",msktxtNumara.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmAnasayfa frm = new frmAnasayfa();
                frm.numara = msktxtNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi!!");
            }
            baglanti.Close();

        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
