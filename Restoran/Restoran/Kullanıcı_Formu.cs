using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restoran
{
    class Kullanıcı_Formu
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-BG35CSS;Initial Catalog=Restorant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand komut;
        SqlDataReader read;


        public SqlDataReader kullanıcı (TextBox kullanıcıadı, TextBox şifre)
        {
            baglantı.Open();
            komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select * from tbl_kullanici where kullanıcıadı='" + kullanıcıadı.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (şifre.Text == read["şifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Edin", "Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Edin", "Hata2");
            }
                baglantı.Close();
                return read;
            }
        public void yenikullanıcı(TextBox kullanıcıadı, TextBox şifre , TextBox şifretekrar)
        {
            if (şifre.Text == şifretekrar.Text)
            {
                baglantı.Open();
                komut = new SqlCommand();
                komut.Connection = baglantı;
                komut.CommandText = "insert into tbl_kullanici values('"+ kullanıcıadı.Text+"','"+şifre.Text+"','"+şifretekrar.Text+"','')";
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kullanıcı Eklendi");
                foreach (Control item in kullanıcıadı.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata");
            }
        }
            

        }

    }

