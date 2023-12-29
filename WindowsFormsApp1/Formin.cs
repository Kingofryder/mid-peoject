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
    public partial class Formin : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Formin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "cptjcoffee";
            scsb.IntegratedSecurity = true;
            globalvar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            int intID = 0;
            if ((txtID.Text != "") && (txtIDNumber.Text != "") && (Int32.TryParse(txtID.Text, out intID)))
            {
                SqlConnection con = new SqlConnection(globalvar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from coffeestaff_1 where id = @SearchID and sidnumber = @SearchIDNumber";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", txtID.Text);
                cmd.Parameters.AddWithValue("@SearchIDNumber", txtIDNumber.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    globalvar.is登入成功 = true;
                    
                    MessageBox.Show($"登入成功!，歡迎使用本程式。");
                    Close();//關閉表單
                }
                reader.Close();
                con.Close();
                if (globalvar.is登入成功 == false)
                {
                    lbl回應訊息.Text = "登入失敗, 登入資料錯誤!";
                }
                else
                {
                    lbl回應訊息.Text = "請輸入登入資料。";
                }
            }

        }
       

        private void btn重設表單_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "請輸入登入資訊";
            txtID.Text = "";
            txtIDNumber.Text = "";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (globalvar.is登入成功 == true)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
