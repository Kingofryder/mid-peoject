using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formshow : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();


        public Formshow()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            讀取商品資料庫();
            顯示listView_圖片模式();
        }

        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from coffeeproducts_1;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                listID.Add((int)reader["id"]);
                listProductName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = $"{globalvar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList商品圖檔.Images.Add(img產品圖檔);
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 顯示listView_圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;//LargeIcon,Tile,List,SmallIcon
            imageList商品圖檔.ImageSize = new Size(110, 110);
            listView商品展示.LargeImageList = imageList商品圖檔; //LargeIcon, Tile
            listView商品展示.SmallImageList = imageList商品圖檔; //SmallIcon, List

            for (int i = 0; i < imageList商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listID[i];
                listView商品展示.Items.Add(item);
            }
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            顯示listView_圖片模式();
        }

        void 顯示ListView_列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100);
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 200);
            listView商品展示.GridLines = true; // 格線
            listView商品展示.FullRowSelect = true; //點選時反白

            for (int i = 0; i < listID.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                listItem.Tag = listID[i];
                listItem.Text = listID[i].ToString();
                listItem.SubItems.Add(listProductName[i]);
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.ForeColor = Color.DarkBlue;
                listItem.BackColor = Color.LightGray;
                listView商品展示.Items.Add(listItem);

            }
        }
        private void btn列表模式_Click(object sender, EventArgs e)
        {
            顯示ListView_列表模式();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            FormDetails myFormDetail = new FormDetails();
            myFormDetail.ShowDialog();
        }
        void 重新載入資料()
        {
            listID.Clear();
            listPrice.Clear();
            listProductName.Clear();
            imageList商品圖檔.Images.Clear();
            讀取商品資料庫();

            if (listView商品展示.View == View.Details)
            {
                顯示ListView_列表模式();
            }
            else
            {
                顯示listView_圖片模式();
            }
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void listView商品展示_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView商品展示.SelectedItems.Count > 0)
            {
                
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
          int intID = 0;
            //Int32.TryParse(txtID.Text, out intID);
            

                if(listView商品展示.SelectedItems.Count > 0)
                {
                    intID = (int)listView商品展示.SelectedItems[0].Tag;
                Console.WriteLine(intID);
                }
                SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from coffeeproducts_1 where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show($"資料已刪除,{rows}筆資料受影響");

            重新載入資料();
        }



        private void listView商品展示_MouseDoubleClick(object sender, MouseEventArgs e)
        {        
            FormDetails myFormDetail = new FormDetails();    
            if(listView商品展示.SelectedItems.Count > 0)
            {
                myFormDetail.selectID = (int)listView商品展示.SelectedItems[0].Tag;
            }
            myFormDetail.ShowDialog();
        }
    }
}
