using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COD01
{
    static class Program
    {
        /// <summary>
        public static Form1 f1;       // 靜態成員
        public static string strSearch;

        public static int searchText(string source, string str, int start)
        {
            return source.IndexOf(str, start);
        }

        public static string replaceText(string source, string replace, 
                                         int pos, int len)
        {
            string strLeft, strRight;
            // 取得搜尋字串左邊的字串
            strLeft = source.Substring(0, pos);
            // 取得搜尋字串右邊的字串
            strRight = source.Substring(pos + len);
            return (strLeft + replace + strRight);
        }

        /// </summary>
        [STAThread]       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            strSearch = "";    // 初始字串
            f1 = new Form1();  // 建立表單物件
            Application.Run(f1);
        }
    }
}