using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class orderlist2 : Form
    {
        public orderlist2()
        {
            InitializeComponent();
        }

        private void listbox品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 咖啡項目２_Load(object sender, EventArgs e)
        {
            lbl訂購資料.Text = globalvar.訂購人資訊;

            foreach (ArrayList 訂購單品 in globalvar.list訂購品項資料集合)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 單價 = (int)訂購單品[1];
                int 杯數 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 甜度 = (string)訂購單品[4];
                string 冰塊 = (string)訂購單品[5];
                

                string strInfo = string.Format("{0} {1}元 {2}杯 品項總價：{3}元 {4} {5}", 品項名稱, 單價, 杯數, 品項總價, 甜度, 冰塊);
                listbox品項列表.Items.Add(strInfo);
            }
            計算訂單總價();
        }

        private void btn移除所有選項_Click(object sender, EventArgs e)
        {
            if (listbox品項列表.SelectedIndex >= 0)
            {
                int selIndex = listbox品項列表.SelectedIndex;
                globalvar.list訂購品項資料集合.RemoveAt(selIndex);
                listbox品項列表.Items.RemoveAt(selIndex);
                計算訂單總價();
            }
            else
                MessageBox.Show("請選擇移除品項!");

        }

        private void btn清除所有選項_Click(object sender, EventArgs e)
        {
            listbox品項列表.Items.Clear();
            globalvar.list訂購品項資料集合.Clear();
            計算訂單總價();
        }

        private void btn輸出訂購單_Click(object sender, EventArgs e)
        {
            string str檔案目錄 = @"C:\Users\User\Desktop\其中\WindowsFormsApp1";
            Random myRnd = new Random();
            int rndNum = myRnd.Next(10000, 100000);
            string str檔名 = DateTime.Now.ToString("yyMMddHHss") + rndNum + "訂購檔.txt";
            string str完整檔案路徑 = str檔案目錄 + @"\" + str檔名;

            Console.WriteLine(str完整檔案路徑);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案目錄;//預設儲存目錄
            sfd.FileName = str檔名;//預設檔名
            sfd.Filter = "文字檔|*.txt";//只把.txt檔顯示在目錄中

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
                str完整檔案路徑 = sfd.FileName;
            else
                return;

            //訂單內容輸出
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("****************** ICE冷飲店訂購單 ********************");
            list訂單資訊.Add("------------------------------------------------------");
            list訂單資訊.Add($"訂購時間：{DateTime.Now}");
            list訂單資訊.Add($"訂購人：{globalvar.訂購人資訊}");
            list訂單資訊.Add("=================== << 訂購品項 >> ====================");
            foreach (ArrayList 訂購單品 in globalvar.list訂購品項資料集合)
            {
                string 品項名稱 = (string)訂購單品[0];
                int 單價 = (int)訂購單品[1];
                int 杯數 = (int)訂購單品[2];
                int 品項總價 = (int)訂購單品[3];
                string 甜度 = (string)訂購單品[4];
                string 冰塊 = (string)訂購單品[5];
                

                string strInfo = string.Format("{0} {1}元 {2}杯 品項總價：{3}元 {4} {5}", 品項名稱, 單價, 杯數, 品項總價, 甜度, 冰塊);

                list訂單資訊.Add(strInfo);
            }
            list訂單資訊.Add("=======================================================");
            list訂單資訊.Add($"{lbl外帶.Text} {lbl購物袋.Text}");
            list訂單資訊.Add($"{lbl總價.Text}");
            list訂單資訊.Add("=======================================================");
            list訂單資訊.Add("*********************** 謝謝光臨 ************************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("訂購單儲存成功");

        }

        private void btn繼續訂購_Click(object sender, EventArgs e)
        {
            Close();
        }

        void 計算訂單總價()
        {
            int 訂單總價 = 0;
            foreach (ArrayList 訂購單品 in globalvar.list訂購品項資料集合)
            {
                int 品項總價 = (int)訂購單品[3];

                訂單總價 += 品項總價;
            }
            if ((globalvar.is購物袋 == true) && (globalvar.list訂購品項資料集合.Count > 0))
            {
                訂單總價 += 2;
                lbl購物袋.Text = "買購物袋";
            }
            else
                lbl購物袋.Text = "";
            if (globalvar.is外帶 == true)
                lbl外帶.Text = "外帶";
            else
                lbl外帶.Text = "內用";

            lbl總價.Text = string.Format("訂單總價：{0}元", 訂單總價);
        }

        private void FormOderList_FormClosing(object sender, FormClosingEventArgs e) //表單關閉前
        {
            DialogResult R = MessageBox.Show("您確定要關閉表單嗎?", "關閉表單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }
    }
}
