using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class orderlist : Form
    {
        List<string> list飲料品項 = new List<string>(); //key
        List<int> list飲料價格 = new List<int>(); //value
        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();
        
       
        int 杯數 = 0;
        int 單價 = 0;
        int 品項總價 = 0;
        string 品項名稱 = "";
        string 甜度 = "";
        string 冰塊 = "";
        bool is外帶 = false;
        bool is購物袋 = false;
        bool is內用 = false;
        public orderlist()
        {
            InitializeComponent();
        }

        private void 訂購項目_Load(object sender, EventArgs e)
        {
            list飲料品項.Add("美式咖啡");
            list飲料品項.Add("拿鐵");
            list飲料品項.Add("義式濃縮");
            list飲料品項.Add("馥芮白");
            list飲料品項.Add("卡布奇諾");

            list飲料價格.Add(55);
            list飲料價格.Add(60);
            list飲料價格.Add(50);
            list飲料價格.Add(70);
            list飲料價格.Add(70);

            list甜度.Add("正常糖");
            list甜度.Add("半糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");

            list冰塊.Add("正常冰");
            list冰塊.Add("少冰");
            list冰塊.Add("去冰");
            list冰塊.Add("熱");


            for (int i = 0; i < list飲料品項.Count; i += 1)
            {
                string strItem = string.Format("{0} {1}元", list飲料品項[i], list飲料價格[i]);
                listBox飲料品項.Items.Add(strItem);
            }

            foreach (string item in list甜度)
            {
                comboBox甜度.Items.Add(item);
            }

            foreach (string item in list冰塊)
            {
                comboBox冰塊.Items.Add(item);
            }

            //表單預設值
            comboBox甜度.SelectedIndex = 0;
            甜度 = list甜度[comboBox甜度.SelectedIndex];
            comboBox冰塊.SelectedIndex = 0;
            冰塊 = list冰塊[comboBox冰塊.SelectedIndex];
            listBox飲料品項.SelectedIndex = 0;
            品項名稱 = list飲料品項[listBox飲料品項.SelectedIndex];
            杯數 = 1;
            txt數量.Text = 杯數.ToString();
            chk外帶.Checked = true;
            is外帶 = chk外帶.Checked;
            chk購物袋.Checked = false;
            is購物袋 = chk購物袋.Checked;
        }
        void 計算所選品項的總價()
        {
            if (listBox飲料品項.SelectedIndex >= 0)
            {
                品項總價 = 單價 * 杯數;
                lbl品項總價.Text = string.Format("{0}元", 品項總價);
            }
        }
        private void listBox飲料品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox飲料品項.SelectedIndex >= 0)
            {
                品項名稱 = list飲料品項[listBox飲料品項.SelectedIndex];
                單價 = list飲料價格[listBox飲料品項.SelectedIndex] ;
                lbl單價.Text = string.Format("{0}元", 單價);
                計算所選品項的總價();
            }
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {
                bool is杯數輸入正確 = Int32.TryParse(txt數量.Text, out 杯數);

                if ((is杯數輸入正確) == false || (杯數 <= 0))
                {
                    MessageBox.Show("杯數輸入錯誤,請重新輸入!");
                    杯數 = 1;
                    txt數量.Text = 杯數.ToString();
                }
                計算所選品項的總價();
            }

        }

        private void comboBox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            甜度 = list甜度[comboBox甜度.SelectedIndex];
        }

        private void comboBox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk購物袋_CheckedChanged(object sender, EventArgs e)
        {
            if (chk購物袋.Checked)
                is購物袋 = true;
            else
                is購物袋 = false;
            globalvar.is購物袋 = is購物袋;
        }

        private void chk內用_CheckedChanged(object sender, EventArgs e)
        {
            if (chk內用.Checked)
                is內用 = true;
            else
                is內用 = false;
            globalvar.is內用 = is內用;
        }

        private void chk外帶_CheckedChanged(object sender, EventArgs e)
        {
            if (chk外帶.Checked)
                is外帶 = true;
            else
                is外帶 = false;
            globalvar.is外帶 = is外帶;
        }

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            if (listBox飲料品項.SelectedIndex >= 0)
            {
                ArrayList 訂購單品資訊 = new ArrayList();
                訂購單品資訊.Add(品項名稱);
                訂購單品資訊.Add(單價);
                訂購單品資訊.Add(杯數);
                訂購單品資訊.Add(品項總價);
                訂購單品資訊.Add(甜度);
                訂購單品資訊.Add(冰塊);


                globalvar.訂購人資訊 = txt訂購人.Text;
                globalvar.list訂購品項資料集合.Add(訂購單品資訊);

                globalvar.is外帶 = is外帶;
                globalvar.is購物袋 = is購物袋;

                MessageBox.Show("所選品項已加入購物車");

            }
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            orderlist2 myorderlist2 = new orderlist2();
            myorderlist2.ShowDialog();
        }
    }
}
