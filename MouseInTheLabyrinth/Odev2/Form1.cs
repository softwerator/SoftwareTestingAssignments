using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class MouseInTheLabyrinth : Form
    {
        public MouseInTheLabyrinth()
        {
            InitializeComponent();
        }

        int[,] Labirent;
        int maxEn, maxBoy, fareEn, fareBoy, peynirEn, peynirBoy;
        bool FareEklendiMi = false, PeynirEklendiMi = false, IlkFareEklendiMi = false, IlkPeynirEklendiMi = false;
        Button GecmisFareButon, FareButon, GecmisPeynirButon, PeynirButon;

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtEn.Text != "")
            {
                if ((int.TryParse(txtEn.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!");
                }
            }
        }

        private void txtBoy_TextChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtBoy.Text != "")
            {
                if ((int.TryParse(txtBoy.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!");
                }
            }
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e) { Application.Restart(); }

        private void oyunuKapatToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yazılım Sınama dersinin 2. ödevidir." +
                            "\nAmaç farenin en kısa yolu kullanarak peynire ulaşmasıdır." +
                            "\nKullanıcı istediği kadar duvar örebilir." +
                            "\nFare ve peynirleri istediği yerlere koyabilir."
                            ,"Hakkında");
        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. En ve boy değerlerini giriniz. Yalnız bu değerler 1-9 aralığında olmalıdır." +
                            "\n2. Alana istediğiniz kadar duvar örebilirsiniz. " +
                            "\n3. Boşaltmak istedikleriniz için dolu alanları tıklayınız." +
                            "\n4. Ama öreceğiniz duvarlar yüzünden peynire ulaşıma engel olmayın." +
                            "\n5. Fare ve peyniri istediğiniz yerlere koyabilirsiniz. " +
                            "\n6. Boşaltmak istedikleriniz için dolu alanları tıklayıp başka yerlere koyabilirsiniz." +
                            "\n7. Eklediğiniz fare veya peynirin yerini boşaltmak için eklediğiniz yere tıklayın." +
                            "\n8. Daha sonra istediğiniz yerlere ekleyebilirsiniz." +
                            "\n9. Bu işlemleri gerçekleştirdikten sonra oyunu başlata tıklayarak işlemi sonlandırın."
                            ,"Nasıl Oynanır?");
        }

        private void btnOyunAlaniniOlustur_Click(object sender, EventArgs e)
        {
            int En, Boy; bool ctrlE = false, ctrlB = false, txtE = true, txtB = true;

            if (txtEn.Text  != "") { En = Convert.ToInt32(txtEn.Text);   } else { En = 0;  txtE = false; }
            if (txtBoy.Text != "") { Boy = Convert.ToInt32(txtBoy.Text); } else { Boy = 0; txtB = false; }

            if (En < 1  || En > 9)  { ctrlE  = false; } else { ctrlE  = true; }
            if (Boy < 1 || Boy > 9) { ctrlB  = false; } else { ctrlB  = true; }

            if (ctrlE && ctrlB)
            {
                En += 2; Boy += 2;
                Labirent = new int[En, Boy];
                for (int i = 0; i < En; i++) { for (int j = 0; j < Boy; j++) { Labirent[i, j] = 0; } }
                maxEn = En; maxBoy = Boy;
                Ciz(En, Boy);

                txtEn.Enabled = false;
                txtBoy.Enabled = false;
                btnOyunAlaniniOlustur.Enabled = false;
                btnFareEkle.Enabled = true;
            }

            else
            {
                if      (!(txtE) && !(txtB))   { MessageBox.Show("En ve boy değerleri boş girilmiştir!"); }
                else if (!(txtE))              { MessageBox.Show("En değeri boş girilmiştir!"); }
                else if (!(txtB))              { MessageBox.Show("Boy değeri boş girilmiştir!"); }
                else if (!(ctrlE) && !(ctrlB)) { MessageBox.Show("En ve boy değerleri hatalıdır!"); }
                else if (!(ctrlE))             { MessageBox.Show("En değeri hatalıdır."); }
                else if (!(ctrlB))             { MessageBox.Show("Boy değeri hatalıdır."); }
            }
        }

        private void Ciz(int En, int Boy)
        {
            for (int i = 0; i < En; i++)
            {
                for (int j = 0; j < Boy; j++)
                {
                    if ((i == 0) || (j == 0) || (i == En - 1) || (j == Boy - 1)) { Labirent[i, j] = -1; }
                }
            }

            int EnNokta = 0, BoyNokta = 0;

            for (int i = 0; i < En; i++)
            {
                for (int j = 0; j < Boy; j++)
                {
                    Button Buton = new Button();
                    if (Labirent[i, j] == -1) { Buton.Image = Properties.Resources.Duvar; Buton.Enabled = false; }
                    else { Buton.Text = ""; }

                    Buton.FlatStyle = FlatStyle.Flat;
                    Buton.Top = BoyNokta; Buton.Left = EnNokta;
                    Buton.Height = 50; Buton.Width = 50;
                    Buton.Tag = i + "," + j;
                    Buton.Click += EkleKaldir_Click;
                    dgv.Controls.Add(Buton);

                    if (j == Boy - 1) { EnNokta = 0; BoyNokta += 50; }
                    else { EnNokta += 50; }
                }
            }
        }

        private void EkleKaldir_Click(object sender, EventArgs e)
        {
            if (btnFareEkle.Enabled == true)
            {
                Button Buton = sender as Button;
                string[] Parse = new string[2];
                Parse = Buton.Tag.ToString().Split(',');
                if (Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] == 0)
                {
                    Buton.Image = Properties.Resources.Duvar;
                    Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = -1;
                }
                else
                {
                    Buton.Image = null;
                    Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = 0;
                }
            }
            if (btnPeynirEkle.Enabled == true)
            {
                Button Buton = sender as Button;
                string[] Parse = new string[2];
                Parse = Buton.Tag.ToString().Split(',');
                if (Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] == 0)
                {
                    if (!(IlkFareEklendiMi))
                    {
                        Buton.Image = Properties.Resources.Fare3;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = -1;
                        fareEn = Convert.ToInt32(Parse[0]); fareBoy = Convert.ToInt32(Parse[1]);
                        FareEklendiMi = true;
                        IlkFareEklendiMi = true;
                        FareButon = sender as Button;
                        GecmisFareButon = sender as Button;
                    }
                    else
                    {   
                        GecmisFareButon.Image = null;
                        Buton.Image = Properties.Resources.Fare3;
                        Labirent[fareEn, fareBoy] = 0;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = -1;
                        fareEn = Convert.ToInt32(Parse[0]); fareBoy = Convert.ToInt32(Parse[1]);
                        FareButon = sender as Button;
                        GecmisFareButon = sender as Button;
                        FareEklendiMi = true;
                    }
                }
                else
                {
                    if ((Convert.ToInt32(Parse[0]) == fareEn) && (Convert.ToInt32(Parse[1]) == fareBoy))
                    {
                        Buton.Image = null;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = 0;
                        FareEklendiMi = false;
                    }
                }
            }
            if (btnOyunuBaslat.Enabled == true)
            {
                Button Buton = sender as Button;
                string[] Parse = new string[2];
                Parse = Buton.Tag.ToString().Split(',');
                if (Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] == 0)
                {
                    if (!(IlkPeynirEklendiMi))
                    {
                        Buton.Image = Properties.Resources.Peynir;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = -1;
                        peynirEn = Convert.ToInt32(Parse[0]); peynirBoy = Convert.ToInt32(Parse[1]);
                        PeynirEklendiMi = true;
                        IlkPeynirEklendiMi = true;
                        PeynirButon = sender as Button;
                        GecmisPeynirButon = sender as Button;
                    }
                    else
                    {
                        GecmisPeynirButon.Image = null;
                        Buton.Image = Properties.Resources.Peynir;
                        Labirent[peynirEn, peynirBoy] = 0;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = -1;
                        peynirEn = Convert.ToInt32(Parse[0]); peynirBoy = Convert.ToInt32(Parse[1]);
                        PeynirButon = sender as Button;
                        GecmisPeynirButon = sender as Button;
                        PeynirEklendiMi = true;
                    }
                }
                else
                {
                    if ((Convert.ToInt32(Parse[0]) == peynirEn) && (Convert.ToInt32(Parse[1]) == peynirBoy))
                    {
                        Buton.Image = null;
                        Labirent[Convert.ToInt32(Parse[0]), Convert.ToInt32(Parse[1])] = 0;
                        PeynirEklendiMi = false;
                    }
                }
            }
        }

        private void btnFareEkle_Click(object sender, EventArgs e)
        {
            btnFareEkle.Enabled = false; btnPeynirEkle.Enabled = true;
        }

        private void btnPeynirEkle_Click(object sender, EventArgs e)
        {
            if (FareEklendiMi) { btnPeynirEkle.Enabled = false; btnOyunuBaslat.Enabled = true; }
            else { MessageBox.Show("Fare eklemediniz!"); }
        }

        private async void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            if (PeynirEklendiMi) { btnOyunuBaslat.Enabled = false; await Hareket(); }
            else { MessageBox.Show("Peynir eklemediniz!"); }
        }

        private async Task<int> Hareket()
        {
            Labirent[peynirEn, peynirBoy] = 0;
            int En = fareEn, Boy = fareBoy;
            while (true)
            {
                if (En > maxEn || Boy > maxBoy) break;
                int BulunanEn = 0, BulunanBoy = Boy, EnAz = 0, Bulunan = 0;

                int Ust = Boy - 1; int Alt = Boy + 1; int Sol = En - 1; int Sag = En + 1;

                int[] Siralama = new int[] 
                { int.MaxValue, Labirent[En, Ust], Labirent[En, Alt], Labirent[Sol, Boy], Labirent[Sag, Boy] };

                for (int i = 1; i < Siralama.Length; i++)
                {
                    if (Siralama[i] < Siralama[EnAz] && Siralama[i] != -1)
                    {
                        EnAz = i;
                        if      (i == 1) { BulunanEn = En;  BulunanBoy = Ust; }
                        else if (i == 2) { BulunanEn = En;  BulunanBoy = Alt; }
                        else if (i == 3) { BulunanEn = Sol; BulunanBoy = Boy; }
                        else if (i == 4) { BulunanEn = Sag; BulunanBoy = Boy; }
                        Bulunan = i;
                    }
                }
                
                foreach (var Eleman in dgv.Controls)
                {
                    if (Eleman is Button)
                    {
                        string[] Parse = new string[2];
                        Parse = (Eleman as Button).Tag.ToString().Split(',');

                        if (Parse[0] == BulunanEn.ToString() && Parse[1] == BulunanBoy.ToString())
                        {
                            FareButon.Image = null;
                            if      (Bulunan == 1) { (Eleman as Button).Image = Properties.Resources.Fare1; }
                            else if (Bulunan == 2) { (Eleman as Button).Image = Properties.Resources.Fare3; }
                            else if (Bulunan == 3) { (Eleman as Button).Image = Properties.Resources.Fare2; }
                            else if (Bulunan == 4) { (Eleman as Button).Image = Properties.Resources.Fare4; }

                            (Eleman as Button).Text = "";
                            await Task.Delay(150);
                            Labirent[BulunanEn, BulunanBoy] += 1;
                            (Eleman as Button).BackColor = Color.Transparent;
                            (Eleman as Button).Image = null;
                            break;
                        }

                        if (BulunanEn == peynirEn && BulunanBoy == peynirBoy)
                        {
                            PeynirButon.Image = null;
                            MessageBox.Show("Fare peyniri yakaladı!");
                            break;
                        }
                    }
                }

                if (BulunanEn == peynirEn && BulunanBoy == peynirBoy) { break; }

                En = BulunanEn; Boy = BulunanBoy;

                await Task.Delay(150);
            }
            return 0;
        }
    }
}
