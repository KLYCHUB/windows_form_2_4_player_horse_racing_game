using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//Eren KALAYCI
//212701035

namespace at_yarisi
{
    public partial class Form1_21701035 : Form
    {
        public Form1_21701035()
        {
            InitializeComponent();
        }

        //SoundPlayer den Player_212701035 nesnesi ürettik
        SoundPlayer Player_212701035 = new SoundPlayer();

        //Herhangi bir oyuncu kazanınca kazanma ekranında tüm ouncuların resmini silme fonksiyonu
        void oyunSonu()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        //form2 den aldığımız veriyi form2 den oluşturduğumuz nesne aracılığı ile form1 in parametresine atıyoruz
        Form2_21701035 form_2112701035 = new Form2_21701035();

        //üste bahsettiğim değeri alacak değişken 
        int sayiOyuncusu212701035;

        //form2 de oluşturudğumuz parametreyi burdaya gönderdik ve değeri tutmak için yeni oluşturduğumuz değişkene atadık
        public Form1_21701035(int oyuncuSayisi212701035)
        {
            //Burada form 2 de aldığımız veriyi burda oluşturduğumuz yeni değişekene aktarıyoruz
            sayiOyuncusu212701035 = oyuncuSayisi212701035;
            InitializeComponent();
        }

        //atların ilerlemesi için Randomdan random nesnesi üretiyoruz 
        Random random_212701035 = new Random();

        //her atın başlangıç değerini sıfıra eşitledik(konum olarak)
        //her yeni değer atadığımız da bu değişkenlerde arta arta ileri gitsin diye
        int at1_212701035 = 0;
        int at2_212701035 = 0;
        int at3_212701035 = 0;
        int at4_212701035 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //80 ie 110 arası sayı üretiyoruz ve bunu sayiya atıyoruz
            int sayi = random_212701035.Next(80, 110);
            
            //Buton1 e basınca sıfırla tuşu aktif olur çünkü ilerlememeiş bir oyun sıfırlanmaz
            button6_21701035.Enabled = true;

            //buton1 e basıldığında buton2 nin tıklama özelliği aktif olur ve buton1 in ki pasif olur
            button2_21701035.Enabled = true;
            button1_21701035.Enabled = false;

            //fonksiyonun dışında tanımladığımız 4 atdan 1.si için
            //pictureBox1(1. at) ın mevcut konumumuna (0) ürettiğimiz random sayıları ekleye ekleye ilerletecez
            pictureBox1.Left += sayi;

            //burda ürettiğimiz random sayıları a1=0 değişkenine keleye ekleye gidecez
            //değişkeni oluşturmamızın sebebi ise at 900 pikseli geçtiğinde oyunu kazanması
            at1_212701035 += sayi;


            //bir üste yorum satırıda bahsetiğim döngü
            if(at1_212701035 >= 850)
            {
                //en süte oluşturduğum oyuncu kazanınca oyuncu fotolarını silme fonksiyonunu çağırdım
                oyunSonu();

                //oyuncu kazanınca ekrana gelen mesaj kutusu
                MessageBox.Show("AT 1 KAZANDI","SONUÇ EKRANI",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //ekranda açılan mesaj kutusunda onayladıktan sonra
                form_2112701035.Show();

                //yeni açılacak formu gösterir
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form açılır açılmaz resetleme tuşu pasif olmalı çünkü oyun da hareket olmadan oyunu sfırlamak mantıksız olur
            button6_21701035.Enabled = false;

            //burada buttonlara Visible nı false yapma sebebi başla tuşuna basmadan önce her şeyin gizli olması gerekmesi
            button1_21701035.Visible = false;
            button2_21701035.Visible = false;
            button3_21701035.Visible = false;
            button4_21701035.Visible = false;

            //burada buttonlara Enabled nı false yapma sebebi buttonlar sırayla çalışırken akış sırasının bozulmaması
            button2_21701035.Enabled = false;
            button3_21701035.Enabled = false;
            button4_21701035.Enabled = false;

            //form2 de oyuncu sayısı 2 girilince buraya girilecek
            if (sayiOyuncusu212701035 == 2)
            {
                //3. ve 4. oyuncunun görünürlüğü pasif olacak
                pictureBox3.Visible=false;
                pictureBox4.Visible = false;

                //en altdaki 2 panel görünürlüğü pasif olacak
                panel3_21701035.Visible = false;
                panel4_21701035.Visible = false;

                //en altdaki 2 panel bitirme çizgisi pasif olacak
                panel8_21701035.Visible = false;
                panel9_21701035.Visible = false;
            }

            //form2 de oyuncu sayısı 3 girilince buraya girilecek
            if (sayiOyuncusu212701035 == 3)
            {
                //4. oyuncunun görünürlüğü pasif olacak
                pictureBox4.Visible = false;

                ///en son panel pasif olacak
                panel4_21701035.Visible = false;

                //en altdaki panelin bitirme çizgisi pasif olacak
                panel9_21701035.Visible = false;
            }

        }

        //oyunu başlatma butonu
        private void button5_Click(object sender, EventArgs e)
        {
            //ürettiğimiz nesneyi kullanarak
            //oynatacağımız müziğin konumunu belirtiyoruz
            this.Player_212701035.SoundLocation = @"C:\Users\Eren\Desktop\212701035_eren_kalayci_at_yarisi\sound\at-kosma-sesi-nal-sesi-asmr-horse-running.wav";

            //müziği sonsuz döngüye sokarak oynatıyoruz
            this.Player_212701035.PlayLooping();

            //başla butonuna basınca 1. buton aktifleşti
            button1_21701035.Enabled = true;

            //ardından buton 5 pasifleşti (oyun bitene kadar 1 kez başlatılır)
            button5_21701035.Enabled = false;

            //Başlat butonuna basınca form2 de oyuncu sayısı 2 girilince veri buraya gelecek -ve kontol edilecek
            if (sayiOyuncusu212701035 == 2)
            {
                //iki girilmişsse
                //buton 1 aktif
                button1_21701035.Enabled = true;

                //buton1 ve 2 görünürlüğü aktif oldu
                button1_21701035.Visible = true;
                button2_21701035.Visible = true;
            }

            //Başlat butonuna basınca form2 de oyuncu sayısı 3 girilince veri buraya gelecek -ve kontol edilecek
            if (sayiOyuncusu212701035 == 3)
            {
                //buton 1,2 ve 3 aktif
                button1_21701035.Visible = true;
                button2_21701035.Visible = true;
                button3_21701035.Visible = true;
            }

            //Başlat butonuna basınca form2 de oyuncu sayısı 4 girilince veri buraya gelecek -ve kontol edilecek
            if (sayiOyuncusu212701035 == 4)
            {
                //Tüm butonların görünürlüğü akif olacak
                button1_21701035.Visible = true;
                button2_21701035.Visible = true;
                button3_21701035.Visible = true;
                button4_21701035.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //80 ie 110 arası sayı üretiyoruz ve bunu sayiya atıyoruz
            int sayi_212701035 = random_212701035.Next(80, 110);

            //Form2 de oyuncu sayısı 2 girilince 
            if (sayiOyuncusu212701035 == 2)
            {
                //1.butonun her oyuncu girişin de aktif olması için
                //buton2 ye basınca tekrar 1ç buton aktif olmalı için
                //tekrar 3. butondan 1. butona geçiş yapmak için
                button1_21701035.Enabled = true;
            }

            //Form2 de oyuncu sayısı 3 girilince 
            if (sayiOyuncusu212701035 == 3)
            {
                //3 oyuncu girildiği için 2. butona basıldıktansonra 3. butona sıra gelmesi için
                button3_21701035.Enabled = true;
                button3_21701035.Visible = true;
            }

            //Form2 de oyuncu sayısı 3 girilince
            if (sayiOyuncusu212701035 == 4)
            {
                //işlemler sıra sıra işlediği için böyle 2. butondan 3. butona üste de aynı şekil
                //3. butona bastıktan sonra 3. butonun aktif olması için
                button3_21701035.Enabled = true;
            }
            
            //btuon 2 ye basıldıktan sonra 2. butona tekrar basılmyı önlemek için pasif hale getiriyoruz
            button2_21701035.Enabled = false;

            //fonksiyonun dışında tanımladığımız 4 atdan 2.si için
            //pictureBox1(2. at) ın mevcut konumumuna (0) ürettiğimiz random sayıları ekleye ekleye ilerletecez
            pictureBox2.Left += sayi_212701035;

            //burda ürettiğimiz random sayıları a2=0 değişkenine keleye ekleye gidecez
            //değişkeni oluşturmamızın sebebi ise at 900 pikseli geçtiğinde oyunu kazanması
            at2_212701035 += sayi_212701035;

            //bir üste yorum satırıda bahsetiğim döngü
            if (at2_212701035 >= 850)
            {
                //en süte oluşturduğum oyuncu kazanınca oyuncu fotolarını silme fonksiyonunu çağırdım
                oyunSonu();

                //oyuncu kazanınca ekrana gelen mesaj kutusu
                MessageBox.Show("AT 2 KAZANDI", "SONUÇ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ekranda açılan mesaj kutusunda onayladıktan sonra
                form_2112701035.Show();

                //yeni açılacak formu gösterir
                this.Hide();  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //80 ie 110 arası sayı üretiyoruz ve bunu sayiya atıyoruz
            int sayi_212701035 = random_212701035.Next(80, 110);

            //Form2 de oyuncu sayısı 3 girilince
            if (sayiOyuncusu212701035 == 3)
            {
                //oyunun başlaması için ilk 1. buton aktif olmalı
                //tekrar 3. butondan 1. butona geçiş yapmak için
                button1_21701035.Enabled = true;
            }

            //Form2 de oyuncu sayısı 4 girilince
            if (sayiOyuncusu212701035 == 4)
            {
                //buton3 e basınca 4. butonu aktifleştirmek için
                button4_21701035.Enabled = true;
            }

            //btuon 3 ye basıldıktan sonra 3. butona tekrar basılmyı önlemek için pasif hale getiriyoruz
            button3_21701035.Enabled = false;

            //fonksiyonun dışında tanımladığımız 4 atdan 3.sü için
            //pictureBox1(3. at) ın mevcut konumumuna (0) ürettiğimiz random sayıları ekleye ekleye ilerletecez
            pictureBox3.Left += sayi_212701035;

            //burda ürettiğimiz random sayıları a3=0 değişkenine keleye ekleye gidecez
            //değişkeni oluşturmamızın sebebi ise at 900 pikseli geçtiğinde oyunu kazanması
            at3_212701035 += sayi_212701035;

            //bir üste yorum satırıda bahsetiğim döngü
            if (at3_212701035 >= 850)
            {
                //en süte oluşturduğum oyuncu kazanınca oyuncu fotolarını silme fonksiyonunu çağırdım
                oyunSonu();

                //oyuncu kazanınca ekrana gelen mesaj kutusu
                MessageBox.Show("AT 3 KAZANDI", "SONUÇ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ekranda açılan mesaj kutusunda onayladıktan sonra
                form_2112701035.Show();

                //yeni açılacak formu gösterir
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //80 ie 110 arası sayı üretiyoruz ve bunu sayiya atıyoruz
            int sayi_212701035 = random_212701035.Next(80, 110);

            //tekrar döngüye girmesi için bu butona basınca 1. butona geri dönecek ve aktifleşecek
            button1_21701035.Enabled = true;

            //şuanki butona basılınca pasif hale geçer ve sıraya tekrar girer
            button4_21701035.Enabled = false;

            //fonksiyonun dışında tanımladığımız 4 atdan 4.sü için
            //pictureBox1(4. at) ın mevcut konumumuna (0) ürettiğimiz random sayıları ekleye ekleye ilerletecez
            pictureBox4.Left += sayi_212701035;

            //burda ürettiğimiz random sayıları a4=0 değişkenine keleye ekleye gidecez
            //değişkeni oluşturmamızın sebebi ise at 900 pikseli geçtiğinde oyunu kazanması
            at4_212701035 += sayi_212701035;

            //bir üste yorum satırıda bahsetiğim döngü
            if (at4_212701035 >= 850)
            {
                //en süte oluşturduğum oyuncu kazanınca oyuncu fotolarını silme fonksiyonunu çağırdım
                oyunSonu();

                //oyuncu kazanınca ekrana gelen mesaj kutusu
                MessageBox.Show("AT 4 KAZANDI", "SONUÇ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ekranda açılan mesaj kutusunda onayladıktan sonra
                form_2112701035.Show();

                //yeni açılacak formu gösterir
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //resetleme butonunda büyün resimlerin konumunu x ekseninde 0 yaptı
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            
            //tekrar 2 den başlasın diye
            button1_21701035.Enabled = true;
            button2_21701035.Enabled = false;
            button3_21701035.Enabled = false;
            button4_21701035.Enabled = false;

            //resetleme tuşuna bastığımızda başlama tuşu tekrar aktif olsun diye
            button5_21701035.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}

//1-> oyun yüklenir yüklenmez form_load çalışacak ve ekranda oyuncu butonları görünmememsi için hepsinin görünürlüğünü flase yeptık
//1.1-> form_load da butonları enablesini false yapmamızın sebbi başlagıç olarak 1 dışında hepsinin pasif olması gerek yoksa 1 den fazla oyucu farklı tuşlara aynı anda basabilir
//1.2-> form_load içindeli kontrol yapıları ise kullanıcı 2 oyunculu girerse ilk iki oyuncu, 3 girerse ilk 3, 4 girese 4 oyuncunun gözükmesi
//dögünün daha iyi işlemesini sağlamak

//tasarım kısmında resimleri daha kolay görüünürlüğünü kapatmak için çoğunu panelin üstüne koydum

//butonların çalışma mantığı ise 2 oyuncu seçince ve başlama tuşuna basınca 1.buton aktif olacak
//1. butona basınca 1. buton pasif 2. buton aktif olacak
//2. butona basınca 2. pasif 1. aktif oalcak

//butonların çalışma mantığı ise 3 oyuncu seçince ve başlama tuşuna basınca 1.buton aktif olacak
//1. butona basınca 1. buton pasif 2. buton aktif olacak,
//3. butona basınca 2. buton pasif 3. buton aktif olacak
//3. butona basınca 1. aktif 3. pasif oalcak
//3. buton bitiminde 1. butona yönlendiri bu şekil döndü sağlanır

//bu mantıkla 4. de aynı eşkil olacak ve devam edecek tabi bunlar tuşlar içindeki karar yapıları ile mümkün
//her oyuncu sayısına göre her butonda ayrı karar yapısı var

//oyun bitince de tekar için oyuncu giriş sayfasına yönlendirilir

