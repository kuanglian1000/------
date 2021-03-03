using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace COD01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "NotePad.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            // 使用FileStream物件開啟或建立二進位檔案
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // 從開啟的二進位檔案使用BinaryReader物件讀取字串至txtOutput
            
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
            if (fs.CanRead)
            {
                txtOutput.Text = br.ReadString();
            }
            else {
                txtOutput.Text = "無法讀取";
            }

           br.Close(); // 關閉BinaryReader
           fs.Close(); // 關閉FileStream
           // 取消txtOutput控制項的反白顯示
           
           txtOutput.Select(0,0);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 使用FileStream物件開啟或建立二進位檔案
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // 使用BinaryWriter物件將字串資料寫入二進位檔
            
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, false);
            bw.Write(txtOutput.Text);

            bw.Flush();
            bw.Close(); // 關閉BinaryWriter
            fs.Close(); // 關閉FileStream 
            
        }
    }
}