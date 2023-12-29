using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp1
{
    public partial class FormDetails : Form
    {
        public int selectID = 0;
        string image_修改後的檔名 = "";
        bool is修改圖檔 = false;


        public FormDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            txtID.Text = selectID.ToString();

            if (selectID == 0)
            {
                groupBox商品新增.Visible = true;
                groupBox商品修改.Visible = false;
            }
            else
            {
                groupBox商品新增.Visible = false;
                groupBox商品修改.Visible = true;
            }
            顯示商品詳細資訊();
        }
        void 顯示商品詳細資訊()
        {
            if (selectID > 0)
            {

                SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from coffeeproducts_1 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txt商品名稱.Text = reader["pname"].ToString();
                    txt商品價格.Text = reader["price"].ToString();
                    image_修改後的檔名 = reader["pimage"].ToString();
                    string 完整圖檔路徑 = globalvar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image = Image.FromFile(完整圖檔路徑);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            選擇商品圖片();

        }
        void 選擇商品圖片()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型(*.jpg, *.jpeg,*.png)|*.jpeg;*.jpg;*.png";//自由發揮|接受的附檔名
            DialogResult R = f.ShowDialog();
            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);//f.FileName完整檔案路徑
                string 圖片副檔名 = System.IO.Path.GetExtension(f.SafeFileName).ToLower();
                Console.WriteLine(圖片副檔名);
                Random myRnd = new Random();
                image_修改後的檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 圖片副檔名;
                is修改圖檔 = true;
                Console.WriteLine(image_修改後的檔名);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {

            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
                con.Open();
                string strSQL = "update coffeeproducts_1 set pname=@NewName, price=@NewPrice, pimage=@NewImage where id=@SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewImage", image_修改後的檔名);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                {
                    string 完整圖檔路徑 = globalvar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void btn選取照片2_Click(object sender, EventArgs e)
        {
            選擇商品圖片();
        }

        private void btn儲存修改2_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into coffeeproducts_1 values(@NewName, @NewPrice, @NewImage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);               
                cmd.Parameters.AddWithValue("@NewImage", image_修改後的檔名);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                {
                    string 完整圖檔路徑 = globalvar.image_dir + @"\" + image_修改後的檔名;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txt商品名稱.Clear();
            txt商品價格.Clear();
            
            pictureBox商品圖檔.Image = null;
        }
    }
}
