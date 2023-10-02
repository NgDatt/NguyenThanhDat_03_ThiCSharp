using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenThanhDat_03_ThiCSharp
{
    public partial class Phuongtrinhbac2 : Form
    {
        public Phuongtrinhbac2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btgiaiphuongtrinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (double.TryParse(txtSoA.Text, out a) && double.TryParse(txtSoB.Text, out b) && double.TryParse(txtSoC.Text, out c))
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textBox1.Text = "Phương trình có 2 nghiệm phân biệt: x1 = " + x1 + ", x2 = " + x2;
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    textBox1.Text = "Phương trình có nghiệm kép: x = " + x;
                }
                else
                {
                    textBox1.Text = "Phương trình không có nghiệm thực";
                }
            }
            else
            {
                textBox1.Text = "Vui lòng nhập đúng định dạng số";
            }

        }

        private void Phuongtrinhbac2_Load(object sender, EventArgs e)
        {

        }
    }
}
