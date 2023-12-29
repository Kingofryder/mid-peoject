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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Formpersons : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> SearchIDs = new List<int>();//存 id 資料
        int DGV筆數 = 0;//DataGridView的資料筆數
        public Formpersons()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";//伺服器名稱
            scsb.InitialCatalog = "cptjcoffee";//資料庫名稱
            scsb.IntegratedSecurity = true;//true -> windows驗證 , false -> SQL Server 驗證

            strDBConnectionString = scsb.ConnectionString;

            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("電話");
            cbox搜尋欄位.Items.Add("地址");
            cbox搜尋欄位.Items.Add("email");
            cbox搜尋欄位.SelectedIndex = 0;
            


            產生會員資料表DataGridView();

        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select TOP(100) * from coffeepersons_1;";
            SqlCommand cmd = new SqlCommand(strSQL, con);//建立執行命令
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;
            //Read -> 讀到資料會跳下一筆
            while (reader.Read()) // 讀取到資料 -> true , 沒有讀到資料 -> false 
            {
                int id = (int)reader["id"]; //reader為物件 -> 須轉型
                string 姓名 = (string)reader["姓名"];
                string 電話 = (string)reader["電話"];
                string email = (string)reader["email"];
                string 地址 = (string)reader["地址"];
                DateTime 生日 = (DateTime)reader["生日"];
         
                int 點數 = (int)reader["點數"];

                strMsg += $"{id}{姓名}{電話}{email}{地址}{生日}{點數}\n";
                count++;

            }
            strMsg += $"資料筆數:{count}";
            reader.Close();//關閉資料讀取器
            con.Close();//關閉資料庫連線
            MessageBox.Show(strMsg);
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from coffeepersons_1 where 姓名 like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);//建立執行命令
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt姓名.Text}%");//參數名稱,參數的值
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = (DateTime)reader["生日"];

                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
        void 清空欄位()
        {
            txtID.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txt點數.Clear();
            dtp生日.Value = DateTime.Now;

        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {

            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if ((intID > 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update coffeepersons_1 set 姓名 = @NewName,電話 = @NewPhone,地址 = @NewAddress,email = @NewEmail,生日 = @NewBirth,點數 = @NEwPoints where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                
                int intPoints = 0;
                Int32.TryParse(txt點數.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int rows = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                con.Close();
                MessageBox.Show($"({rows}個資料列受影響)");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
            產生會員資料表DataGridView();
        }

        private void btn資料新增_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into coffeepersons_1 (姓名,電話,地址,email,生日,點數) values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);

                int intPoints = 0;
                Int32.TryParse(txt點數.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int row = cmd.ExecuteNonQuery();//回傳受影響的資料筆數
                con.Close();
                MessageBox.Show($"({row}個資料列受影響)");
                產生會員資料表DataGridView();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全!");
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from coffeepersons_1 where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"資料已刪除,{rows}筆資料受影響");
                產生會員資料表DataGridView();
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋關鍵字.Text != "")
            {
                listBox進階搜尋結果.Items.Clear();
                SearchIDs.Clear();
                string str欄位名稱 = cbox搜尋欄位.SelectedItem.ToString();
                
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from coffeepersons_1 where 生日 >= @StartBirth and 生日 <= @EndBirth and {str欄位名稱} like @SearchKeyWord;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@StartBirth", dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@EndBirth", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyWord", $"%{txt搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchIDs.Add((int)reader["id"]);
                    listBox進階搜尋結果.Items.Add($"{reader["id"]} {reader["姓名"]} {reader["電話"]}");
                    count++;
                }
                if (count == 0)
                    MessageBox.Show("查無此人");

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入查詢關鍵字");
            }

        }

        private void listBox進階搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox進階搜尋結果.SelectedIndex >= 0)
            {
                int selectID = SearchIDs[listBox進階搜尋結果.SelectedIndex];
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from coffeepersons where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = (DateTime)reader["生日"];
                    
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }

        }
        void 產生會員資料表DataGridView()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from coffeepersons_1";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                Console.WriteLine($"DGV筆數：{dt.Rows.Count}");
                DGV筆數 = dt.Rows.Count;
                dgv會員資料列表.DataSource = dt;
            }
            else
            {

            }
            reader.Close();
            con.Close();
        }

        private void dgv會員資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strSelectID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from coffeepersons_1 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txt點數.Text = reader["點數"].ToString();
                    dtp生日.Value = (DateTime)reader["生日"];
                    
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();

            }
        }
    }
}
