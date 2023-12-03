namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ilksayi = 0;
        string isaret;
        double ikincisayi = 0;
        double sonuc;
        public double hafiza = 0;
        double tersi;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtAna.Text = "0";
        }
        private void focusukaldir()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Focus();
                }
            }
            btnEsittir.Focus();
        }
        private void SonucGoster()
        {
            txtAna.Text = "0";
            txtSonucGoster.Text = Convert.ToString(ilksayi);
            txtSonucGoster.Visible = true;
            txtAna.Visible = false;
        }
        private void btnArti_Click(object sender, EventArgs e)
        {

            ilksayi += Convert.ToDouble(txtAna.Text);
            isaret = "+";
            txtGecmis.Text = ilksayi + isaret;
            SonucGoster();
            focusukaldir();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {

            if (ilksayi != 0)
            {
                ilksayi += Convert.ToDouble(txtAna.Text);
                isaret = "-";
                txtGecmis.Text = ilksayi + isaret;
            }
            else
            {
                ilksayi = Convert.ToDouble(txtAna.Text);
                isaret = "-";
                txtGecmis.Text = ilksayi + isaret;
            }
            SonucGoster();
            focusukaldir();
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            if (ilksayi != 0)
            {
                ilksayi *= Convert.ToDouble(txtAna.Text);
                isaret = "X";
                txtGecmis.Text = ilksayi + isaret;
            }
            else
            {
                if (isaret == "X")
                {
                    ilksayi *= Convert.ToDouble(txtAna.Text);
                    isaret = "X";
                    txtGecmis.Text = ilksayi + isaret;

                }
                ilksayi = Convert.ToDouble(txtAna.Text);
                isaret = "X";
                txtGecmis.Text = ilksayi + isaret;
            }
            SonucGoster();
            focusukaldir();
        }

        private void btnBolu_Click(object sender, EventArgs e)
        {

            if (ilksayi != 0)
            {
                ilksayi /= Convert.ToDouble(txtAna.Text);
                isaret = "/";
                txtGecmis.Text = ilksayi + isaret;

            }
            else
            {
                ilksayi = Convert.ToDouble(txtAna.Text);
                isaret = "/";
                txtGecmis.Text = ilksayi + isaret;
            }
            SonucGoster();
            focusukaldir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            txtAna.Text = txtAna.Text.Remove(txtAna.Text.Length - 1);
            if (txtAna.Text.Length == 0)
                txtAna.Text = "0";
            focusukaldir();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtSonucGoster.Visible = false;
            txtGecmis.Text = "";
            txtAna.Text = "0";
            ilksayi = 0;
            focusukaldir();
        }

        private void btnKok_Click(object sender, EventArgs e)
        {

            double karekok = Convert.ToDouble(txtAna.Text);
            karekok = Math.Sqrt(karekok);
            txtAna.Text = Convert.ToString(karekok);
            txtAna.Text = "0";
            txtSonucGoster.Text = Convert.ToString(karekok);
            txtSonucGoster.Visible = true;
            txtAna.Visible = false;
            focusukaldir();
        }

        private void btnUssu_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(txtAna.Text);
            kare = Math.Pow(kare, 2);
            txtAna.Text = Convert.ToString(kare);
            txtAna.Text = "0";
            txtSonucGoster.Text = Convert.ToString(kare);
            txtSonucGoster.Visible = true;
            txtAna.Visible = false;
            focusukaldir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSonucGoster.Visible = false;
            txtAna.Text = "0";
            focusukaldir();
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {

            if (isaret == "X")
            {
                ikincisayi = Convert.ToDouble(txtAna.Text);
                txtAna.Text = Convert.ToString(ikincisayi / 100);
                txtGecmis.Text = ilksayi + "X" + txtAna.Text;
                focusukaldir();
            }
        }

        private void btn1Bolu_Click(object sender, EventArgs e)
        {

            double bolumx = Convert.ToDouble(txtAna.Text);
            bolumx = 1 / (bolumx);
            txtAna.Text = Convert.ToString(bolumx);
            txtAna.Text = "0";
            txtSonucGoster.Text = Convert.ToString(bolumx);
            txtSonucGoster.Visible = true;
            txtAna.Visible = false;
            focusukaldir();
        }

        private void SayilaraTikla(object sender, EventArgs e)
        {

            Button btnTiklanan = (Button)sender;
            string butonYazi = btnTiklanan.Text;
            if (txtAna.Text == "0")
                txtAna.Text = butonYazi;
            else
                txtAna.Text = txtAna.Text + butonYazi;
            txtAna.Visible = true;
            txtSonucGoster.Visible = false;
            focusukaldir();
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            txtAna.Text = txtAna.Text + ",";
            focusukaldir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            ikincisayi = Convert.ToDouble(txtAna.Text);

            if (isaret == "+")
            {
                sonuc = (ilksayi + ikincisayi);
                txtAna.Text = Convert.ToString(sonuc);
                txtGecmis.Text = ilksayi + "+" + ikincisayi + "=";
                ilksayi = sonuc;

            }
            else if (isaret == "X")
            {
                sonuc = (ilksayi * ikincisayi);
                txtAna.Text = Convert.ToString(sonuc);
                txtGecmis.Text = ilksayi + "X" + ikincisayi + "=";
                ilksayi = sonuc;

            }
            else if (isaret == "-")
            {
                sonuc = (ilksayi - ikincisayi);
                txtAna.Text = Convert.ToString(sonuc);
                txtGecmis.Text = ilksayi + "-" + ikincisayi + "=";
                ilksayi = sonuc;

            }
            else if (isaret == "/")
            {
                if (ikincisayi == 0)
                {
                    txtAna.Text = "Uygulanamaz";
                }
                else
                {
                    sonuc = (ilksayi / ikincisayi);
                    txtAna.Text = Convert.ToString(sonuc);
                    txtGecmis.Text = ilksayi + "/" + ikincisayi + "=";
                    ilksayi = sonuc;
                }
            }
            SonucGoster();
        }

        private void button35_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button35_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {

                rakam1.PerformClick();
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {

                rakam0.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {

                rakam2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                rakam3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {

                rakam4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {

                rakam5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {

                rakam6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {

                rakam7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {

                rakam8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {

                rakam9.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {

                btnEsittir.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {

                btnArti.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {

                btnEksi.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {

                btnCarpi.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {

                btnBolu.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {

                btnGeri.PerformClick();
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {

                btnVirgul.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnArtiEksi_Click(object sender, EventArgs e)
        {

            tersi = Convert.ToDouble(txtAna.Text);
            txtAna.Text = Convert.ToString(tersi * -1);
            focusukaldir();
        }

        private void btnBellekEkle_Click(object sender, EventArgs e)
        {

            hafiza += Convert.ToDouble(txtAna.Text);
            txtAna.Text = "0";
            focusukaldir();
        }

        private void btnBellekCagir_Click(object sender, EventArgs e)
        {

            txtAna.Text = Convert.ToString(hafiza);
            focusukaldir();
        }

        private void btnBellekTemizle_Click(object sender, EventArgs e)
        {

            hafiza = 0;
            focusukaldir();
        }

        private void btnBellekDeposu_Click(object sender, EventArgs e)
        {

            hafiza = Convert.ToDouble(txtAna.Text);
            txtAna.Text = "0";
            focusukaldir();
        }

        private void btnBellek_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.hafiza2 = hafiza;
            form2.ShowDialog();
            hafiza = form2.hafiza2;
            focusukaldir();
        }

        private void btnBellekCikar_Click(object sender, EventArgs e)
        {

            hafiza -= Convert.ToDouble(txtAna.Text);
            txtAna.Text = "0";
            focusukaldir();
        }

        private void button21_KeyDown(object sender, KeyEventArgs e)
        {
        }



    }
}