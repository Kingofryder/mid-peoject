using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class globalvar
    {
        public static string 訂購人資訊 = "";
        public static List<ArrayList> list訂購品項資料集合 = new List<ArrayList>();
        public static bool is外帶 = false;
        public static bool is購物袋 = false;
        public static bool is內用 = false;

        public static string image_dir = @"C:\Users\User\Desktop\其中\coffeeimage";
        public static string strDBConnectionString = "";
        public static bool is登入成功 = false;
        public static string 使用者名稱 = "";
        public static int 使用者id = 0;
        public static int 使用者權限 = 0;
    }
}
