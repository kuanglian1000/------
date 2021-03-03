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
            // �ϥ�FileStream����}�ҩΫإߤG�i���ɮ�
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // �q�}�Ҫ��G�i���ɮרϥ�BinaryReader����Ū���r���txtOutput
            
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
            if (fs.CanRead)
            {
                txtOutput.Text = br.ReadString();
            }
            else {
                txtOutput.Text = "�L�kŪ��";
            }

           br.Close(); // ����BinaryReader
           fs.Close(); // ����FileStream
           // ����txtOutput������ϥ����
           
           txtOutput.Select(0,0);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // �ϥ�FileStream����}�ҩΫإߤG�i���ɮ�
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            // �ϥ�BinaryWriter����N�r���Ƽg�J�G�i����
            
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8, false);
            bw.Write(txtOutput.Text);

            bw.Flush();
            bw.Close(); // ����BinaryWriter
            fs.Close(); // ����FileStream 
            
        }
    }
}