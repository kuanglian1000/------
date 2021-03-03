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
            ofdOpen.Filter = "��r�ɮ�(*.txt)|*.txt|�Ҧ��ɮ�(*.*)|*.*";
            ofdOpen.FilterIndex = 2;
            ofdOpen.RestoreDirectory = true;
            sfdSave.Filter = "��r�ɮ�(*.txt)|*.txt|�Ҧ��ɮ�(*.*)|*.*";
            sfdSave.FilterIndex = 2;
            sfdSave.RestoreDirectory = true;
        }

        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                // �إ�StreamReader�}��ofdOpen��ܤ�����o���ɮצW��
                
                StreamReader sr = new StreamReader(ofdOpen.FileName);
                // Ū����Ӥ�r�ɮ�
                
                txtInput.Text = sr.ReadToEnd();
                sr.Close(); // �����ɮ�
                txtInput.SelectionStart = txtInput.Text.Length;
                txtInput.SelectionLength = 0;
                // �b���D�C����ɮצW��
                
                this.Text = ofdOpen.FileName;
            }
        }

        private void mnuItemSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                // �ϥ�FileInfo�إ�ofdSave��ܤ�����o�ɮצW�٪��s�ɮ�
                
                FileInfo newFile = new FileInfo(sfdSave.FileName);
                // �إ�StreamWriter����
                
                StreamWriter sw = new StreamWriter(newFile.FullName);
                // �g�J�ɮפ��e
                
                sw.Write(txtInput.Text);
                sw.Flush(); // �N�w�İϸ�Ƽg�J�ɮ�
                sw.Close(); // �����ɮ�

                // �b���D�C����ɮצW��
                
                this.Text = newFile.FullName;
            }
        }
        
        private void mnuItemFont_Click(object sender, EventArgs e)
        {
            dlgSetFont.ShowColor = true;  // ����r����m
            if (dlgSetFont.ShowDialog() == DialogResult.OK)
            {
                txtInput.Font = dlgSetFont.Font;
                txtInput.ForeColor = dlgSetFont.Color;
            }
        }

        private void mnuItemForeColor_Click(object sender, EventArgs e)
        {
            dlgSetColor.AllowFullOpen = false; // �����ۭq��m
            dlgSetColor.ShowHelp = true;       // ��ܻ���
            dlgSetColor.Color = txtInput.ForeColor; // �w�]��
            dlgSetColor.ShowDialog();
            txtInput.ForeColor = dlgSetColor.Color;
        }

        private void mnuItemBackColor_Click(object sender, EventArgs e)
        {
            dlgSetColor.AllowFullOpen = true;  // �ۭq��m
            dlgSetColor.ShowHelp = false;      // ��������
            dlgSetColor.Color = txtInput.BackColor; // �w�]��
            dlgSetColor.ShowDialog();
            txtInput.BackColor = dlgSetColor.Color;
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}