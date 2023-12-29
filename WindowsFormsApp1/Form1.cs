using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            Formin form3 = new Formin();
            form3.ShowDialog();
        }

        private void btn咖啡訂購單_Click(object sender, EventArgs e)
        {
            orderlist myorderlist = new orderlist();
            myorderlist.ShowDialog();
        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            Formpersons myForm2 = new Formpersons();
            myForm2.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            Formshow myForm4 = new Formshow();
            myForm4.ShowDialog();
        }
    }
}
