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

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.SelectionStart = 0;
            txtInput.SelectionLength = 0;
            txtInput.Focus();
            // ofdOpen.InitialDirectory = "c:\\";
            ofdOpen.Filter = "文字檔案(*.txt)|*.txt|所有檔案(*.*)|*.*";
            ofdOpen.FilterIndex = 2;
            ofdOpen.RestoreDirectory = true;
            sfdSave.Filter = "文字檔案(*.txt)|*.txt|所有檔案(*.*)|*.*";
            sfdSave.FilterIndex = 2;
            sfdSave.RestoreDirectory = true;
        }

        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                // 建立StreamReader開啟ofdOpen對話方塊取得的檔案名稱
                // TODO
                StreamReader sr = new StreamReader(ofdOpen.FileName);
                // 讀取整個文字檔案
                // TODO
                txtInput.Text = sr.ReadToEnd();
                sr.Close(); // 關閉檔案
                txtInput.SelectionStart = txtInput.Text.Length;
                txtInput.SelectionLength = 0;
                // 在標題列顯示檔案名稱
                // TODO
                this.Text = ofdOpen.FileName;
            }
        }

        private void mnuItemSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                // 使用FileInfo建立ofdSave對話方塊取得檔案名稱的新檔案
                // TODO
                FileInfo newFile = new FileInfo(sfdSave.FileName);
                // 建立StreamWriter物件
                // TODO
                StreamWriter sw = new StreamWriter(newFile.FullName);
                // 寫入檔案內容
                // TODO
                sw.Write(txtInput.Text);
                sw.Flush(); // 將緩衝區資料寫入檔案
                sw.Close(); // 關閉檔案

                // 在標題列顯示檔案名稱
                // TODO
                this.Text = newFile.FullName;
            }
        }
        
        private void mnuItemFont_Click(object sender, EventArgs e)
        {
            dlgSetFont.ShowColor = true;  // 選取字型色彩
            if (dlgSetFont.ShowDialog() == DialogResult.OK)
            {
                txtInput.Font = dlgSetFont.Font;
                txtInput.ForeColor = dlgSetFont.Color;
            }
        }

        private void mnuItemForeColor_Click(object sender, EventArgs e)
        {
            dlgSetColor.AllowFullOpen = false; // 取消自訂色彩
            dlgSetColor.ShowHelp = true;       // 顯示說明
            dlgSetColor.Color = txtInput.ForeColor; // 預設值
            dlgSetColor.ShowDialog();
            txtInput.ForeColor = dlgSetColor.Color;
        }

        private void mnuItemBackColor_Click(object sender, EventArgs e)
        {
            dlgSetColor.AllowFullOpen = true;  // 自訂色彩
            dlgSetColor.ShowHelp = false;      // 取消說明
            dlgSetColor.Color = txtInput.BackColor; // 預設值
            dlgSetColor.ShowDialog();
            txtInput.BackColor = dlgSetColor.Color;
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}