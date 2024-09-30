using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;



        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.Text = "Cevapla";

            if (soruno < 24)
            {
                soruno++;
                this.Text = soruno.ToString();
            }

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Çiçek demetine verilen isim ?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü olan ilimiz";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Mimar Sinan'ın ustalık eserinin olduğu şehir ?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Türkiye'nin en büyük spor kulübü ?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü sınavlardan sonra donup bakakaldığı şey ?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü olan ilimiz ? ";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersin'in diğer ismi ?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Kasabalarda güvenlik ile sorumlu olan birim ?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Galatasaray'ın 7 numarasının adı ?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek etkinliği ?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı ?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Yılbaşının diğer adı ?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Plakası 52 olan il ?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "İnsanların çoğunun sevmediği ot yemeği ?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Müslümanların kutsal ayı ?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Türkiye'nin en kuzeyi olan il ?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Ekip kelimesinin eş anlamlısı ?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Trabzon'daki meşhur göl ?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "5 ........ namaz vardır ";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "İnsan canlısı balıklar ?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Afrika'da bir ülke ?";
                button24.BackColor = Color.Yellow;
            }

        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                switch (soruno)
                {
                    case 1:
                        if (richTextBox2.Text == "Akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                        }

                        break;

                    case 2:
                        if (richTextBox2.Text == "Buket")
                        {
                            button2.BackColor = Color.Green;

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                        }

                        break;

                    case 3:
                        if (richTextBox2.Text == "Cuma")
                        {
                            button3.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;

                        }
                        break;

                    case 4:
                        if (richTextBox2.Text == "Diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;

                        }
                        break;


                    case 5:
                        if (richTextBox2.Text == "Edirne")
                        {
                            button5.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;

                        }
                        break;

                    case 6:
                        if (richTextBox2.Text == "Flüt")
                        {
                            button6.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;

                        }
                        break;


                    case 7:
                        if (richTextBox2.Text == "Galatasaray")
                        {
                            button7.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;

                        }
                        break;

                    case 8:
                        if (richTextBox2.Text == "Halı")
                        {
                            button8.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;

                        }
                        break;

                    case 9:
                        if (richTextBox2.Text == "Isparta")
                        {
                            button9.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;

                        }
                        break;

                    case 10:
                        if (richTextBox2.Text == "İçel")
                        {
                            button10.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;

                        }
                        break;


                    case 11:
                        if (richTextBox2.Text == "Jandarma")
                        {
                            button3.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;

                        }
                        break;

                    case 12:
                        if (richTextBox2.Text == "Kerem")
                        {
                            button12.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;

                        }
                        break;
                    case 13:
                        if (richTextBox2.Text == "Lale")
                        {
                            button13.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;

                        }
                        break;

                    case 14:
                        if (richTextBox2.Text == "Mart")
                        {
                            button14.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;

                        }
                        break;

                    case 15:
                        if (richTextBox2.Text == "Noel")
                        {
                            button15.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;

                        }
                        break;

                    case 16:
                        if (richTextBox2.Text == "Ordu")
                        {
                            button16.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;

                        }
                        break;


                    case 17:
                        if (richTextBox2.Text == "Pırasa")
                        {
                            button17.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;

                        }
                        break;


                    case 18:
                        if (richTextBox2.Text == "Ramazan")
                        {
                            button18.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;

                        }
                        break;

                    case 19:
                        if (richTextBox2.Text == "Sinop")
                        {
                            button19.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;

                        }
                        break;
                    case 20:
                        if (richTextBox2.Text == "Tim")
                        {
                            button20.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;

                        }
                        break;
                    case 21:
                        if (richTextBox2.Text == "Uzungöl")
                        {
                            button21.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;

                        }
                        break;

                    case 22:
                        if (richTextBox2.Text == "vakit")
                        {
                            button22.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;

                        }
                        break;

                    case 23:
                        if (richTextBox2.Text == "Yunus")
                        {
                            button23.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;

                        }
                        break;

                    case 24:
                        if (richTextBox2.Text == "Zimbabve")
                        {
                            button24.BackColor = Color.Green;
                            richTextBox2.Clear();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;

                        }
                        break;


                }



            }
        }
    }
}
