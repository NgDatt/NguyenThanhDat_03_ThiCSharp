using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThanhDat_03_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string hovaten = "Nguyễn Thành Đạt";
            string mssv = "1223360094";
            string monthi = "Lập trình window 2 - C#";

            label1.Text = "Họ Tên :" + hovaten;
            label1.Text += "\nMSSV: " + mssv;
            label1.Text += "\nNgaythi: " + System.DateTime.Now.ToString();
            label1.Text += "\nMonthi: :" + monthi;
             


        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinhdang gpt = new Dinhdang();
            gpt.Show();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuongtrinhbac2 gpt = new Phuongtrinhbac2();
            gpt.Show();
        }
    }
}
