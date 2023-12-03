using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double hafiza2;
        Form1 form1 = new Form1();
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(hafiza2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            hafiza2 = 0;
            MessageBox.Show("Bellek Temizlendi!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.Close();
        }
        
    }
}
