using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace at_yarisi
{
    public partial class Form2_21701035 : Form
    {
        //SoundPlayer den Player_212701035 nesnesi ürettik
        private SoundPlayer Player_212701035 = new SoundPlayer();
        public Form2_21701035()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try - cath yapmamaızın sebebi try içindeki şartlar sağlanmassa (2,3,4 sayılarının girilmemesi) hata verecek
            //ve cath e yollayacak orda bizi uyaracak ve doğru girmeye zorlayacak
            try
            {
                //Burada form açılır açılmaz çalan müziği tuşa basılınca durdurduk
                this.Player_212701035.Stop();

                //diğer forma veri göndermek için değişken oluşturduk ve
                //Bunu burda oluşturduğumuz form1_212701035 nesnesinin parametresine vereceğiz ki,
                //diğer formda bunu çağırdığımız zaman diğer forma oluşturduğumuz değişkene bu değeri ataybilelim
                int oyuncuSayisi_212701035 = Convert.ToInt32(textBox1_21701035.Text);

                //diğer forma geçiporaya veri değiştirmek için oluşturduk
                Form1_21701035 form1_212701035 = new Form1_21701035(oyuncuSayisi_212701035);

                //2,3,4 sayılarından biri girilince yarış ekranına yönlendirecek
                if (oyuncuSayisi_212701035 >= 2 && oyuncuSayisi_212701035 <= 4)
                {
                    //diğer forma yönlendir
                    form1_212701035.Show();
                    //ve o formu gösterir
                    this.Hide();
                }
                else
                {
                    //yanlış sayı girilince ekrana uyarı verir
                    MessageBox.Show("Lütfen 2 ile 4 arası bir sayı giriniz");
                    //sayı giriş alanını yanlış girdikten sonra temizler
                    textBox1_21701035.Clear();
                }
            }
            catch (Exception)
            {
                //yanlış sayı girilince ekrana uyarı verir
                MessageBox.Show("Lütfen 2 ile 4 arası bir sayı giriniz");
                //sayı giriş alanını yanlış girdikten sonra temizler
                textBox1_21701035.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //sayfa müziğinini durdurmadan resetlenmemei için görünmez ve pasif yaptım
            button2_21701035.Visible = false;
            button2_21701035.Enabled = false;

            //Player_212701035 nesnesine çalacağı müziğin yolunu belirttik
            this.Player_212701035.SoundLocation = @"C:\Users\Eren\Desktop\212701035_eren_kalayci_at_yarisi\sound\horse.wav";

            //çalan müziği döküye soktuk
            this.Player_212701035.PlayLooping();
        } 

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Çıkış ekranını çıkışa atamamızın nedeni çıkış değişkeninin aldığı sonuca göre çıkmak veya ekranda kalmak
            DialogResult cikis = MessageBox.Show("Çıkmak istediğinizden emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //çıkış evet ise ekran kapanır
            if(cikis == DialogResult.Yes)
            {
                //form2 kapanır
                Form2_21701035 form2_212701035 = new Form2_21701035();
                form2_212701035.Close();
            }

            //çıkış hayır ise ekran kapanmaz
            else if(cikis == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //reset tuşuna basınca müziği tekrar başlatır
            //Player_212701035 nesnesine çalacağı müziğin yolunu belirttik
            this.Player_212701035.SoundLocation = @"C:\Users\Eren\Desktop\212701035_eren_kalayci_at_yarisi\sound\horse.wav";

            //Müziği başlatır
            this.Player_212701035.Play();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stop tuşu ve müziği durduru
            this.Player_212701035.Stop();

            //ilk defa stopyaptıktan sonra reset tuşu çalışır
            button2_21701035.Visible = true;
            button2_21701035.Enabled = true;
        }
    }
}
