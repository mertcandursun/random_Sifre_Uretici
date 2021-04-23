using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_Sifre_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buyukHarfuretA()
        {
            //Büyük harf üretici ASCII Kod Tablosunda (65 - 90)

            Random rndChar = new Random();
            int buyukRandom = rndChar.Next(65, 91);
            char buyuk = Convert.ToChar(buyukRandom);
            txtSifre.Text = buyuk.ToString();
        }
        public void buyukHarfuretB()
        {
            //Büyük harf üretici ASCII Kod Tablosunda (65 - 90)

            Random rndChar = new Random();
            int buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            char buyuk = Convert.ToChar(buyukRandom);
            txtSifre.Text += buyuk.ToString();
        }
        public void buyukHarfuretC()
        {
            //Büyük harf üretici ASCII Kod Tablosunda (65 - 90)

            Random rndChar = new Random();
            int buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            buyukRandom = rndChar.Next(65, 91);
            char buyuk = Convert.ToChar(buyukRandom);
            txtSifre.Text += buyuk.ToString();
        }
        public void kucukHarfuretA()
        {
            //Küçük harf üretici ASCII Kod Tablosunda (97 - 121)

            Random rndChar = new Random();
            int kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            char kucuk = Convert.ToChar(kucukRandom);
            txtSifre.Text += kucuk.ToString();
        }
        public void kucukHarfuretB()
        {
            //Küçük harf üretici ASCII Kod Tablosunda (97 - 121)

            Random rndChar = new Random();
            int kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            char kucuk = Convert.ToChar(kucukRandom);
            txtSifre.Text += kucuk.ToString();
        }
        public void kucukHarfuretC()
        {
            //Küçük harf üretici ASCII Kod Tablosunda (97 - 121)

            Random rndChar = new Random();
            int kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            kucukRandom = rndChar.Next(97, 122);
            char kucuk = Convert.ToChar(kucukRandom);
            txtSifre.Text += kucuk.ToString();
        }
        public void rakamUretA()
        {
            //Rakam üretici ASCII Kod tablosunda (48 - 56)

            Random rndChar = new Random();
            int rakamRandom = rndChar.Next(48, 57);
            char rakam = Convert.ToChar(rakamRandom);
            txtSifre.Text += rakam.ToString();
        }
        public void rakamUretB()
        {
            //Rakam üretici ASCII Kod tablosunda (48 - 56)

            Random rndChar = new Random();
            int rakamRandom = rndChar.Next(48, 57);
            rakamRandom = rndChar.Next(48, 57);
            char rakam = Convert.ToChar(rakamRandom);
            txtSifre.Text += rakam.ToString();
        }
        public void rakamUretC()
        {
            //Rakam üretici ASCII Kod tablosunda (48 - 56)

            Random rndChar = new Random();
            int rakamRandom = rndChar.Next(48, 57);
            rakamRandom = rndChar.Next(48, 57);
            rakamRandom = rndChar.Next(48, 57);
            char rakam = Convert.ToChar(rakamRandom);
            txtSifre.Text += rakam.ToString();
        }
        public void ozelKarakteruretA()
        {
            //Özel karakter üretici ASCII Kod tablosunda (33 - 47)

            Random rndChar = new Random();
            int ozelARandom = rndChar.Next(33, 47);
            char ozelA = Convert.ToChar(ozelARandom);
            txtSifre.Text += ozelA.ToString();
        }
        public void ozelKarakteruretB()
        {
            // Özel karakter üretici ASCII Kod tablosunda (58 - 64)

            Random rndChar = new Random();
            int ozelBRandom = rndChar.Next(58, 64);
            char ozelB = Convert.ToChar(ozelBRandom);
            txtSifre.Text += ozelB.ToString();
        }
        public void ozelKarakteruretC()
        {
            // Özel karakter üretici ASCII Kod tablosunda (59 - 63)

            Random rndChar = new Random();
            int ozelBRandom = rndChar.Next(59, 63);
            char ozelB = Convert.ToChar(ozelBRandom);
            txtSifre.Text += ozelB.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Value = 100;
            if (progressBar1.Value == 100)
            {
                //Büyük harf metodu çağırılıyor 
                buyukHarfuretA();

                //Küçük harf metodu çağırılıyor
                kucukHarfuretA();

                //Rakam metodu çağırılıyor
                rakamUretA();

                //Özel karakter metodu çağırılıyor ilk aşama
                ozelKarakteruretA();

                //Büyük harf metodu ikinci aşama
                buyukHarfuretB();

                //Rakam metodu ikinci aşama
                rakamUretB();

                //Küçük harf metodu ikinci aşama
                kucukHarfuretB();

                //Özel karakter metodu çağırılıyor ikinci aşama
                ozelKarakteruretB();

                //Büyük harf metodu üçüncü aşama
                buyukHarfuretC();

                //Rakam metodu üçüncü aşama
                rakamUretC();

                //Küçük harf metodu üçüncü aşama
                kucukHarfuretC();

                //Özel karakter metodu üçüncü aşama
                ozelKarakteruretC();

                MessageBox.Show("Şifre başarıyla üretildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
