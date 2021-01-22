namespace COD01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSetFont = new System.Windows.Forms.FontDialog();
            this.dlgSetColor = new System.Windows.Forms.ColorDialog();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile,
            this.mnuItemFormat});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(292, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemOpen,
            this.mnuItemSave,
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(57, 20);
            this.mnuItemFile.Text = "檔案(&F)";
            // 
            // mnuItemOpen
            // 
            this.mnuItemOpen.Name = "mnuItemOpen";
            this.mnuItemOpen.Size = new System.Drawing.Size(116, 22);
            this.mnuItemOpen.Text = "開啟(&O)";
            this.mnuItemOpen.Click += new System.EventHandler(this.mnuItemOpen_Click);
            // 
            // mnuItemSave
            // 
            this.mnuItemSave.Name = "mnuItemSave";
            this.mnuItemSave.Size = new System.Drawing.Size(116, 22);
            this.mnuItemSave.Text = "儲存(&S)";
            this.mnuItemSave.Click += new System.EventHandler(this.mnuItemSave_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(116, 22);
            this.mnuItemExit.Text = "結束(&X)";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuItemFormat
            // 
            this.mnuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFont,
            this.toolStripMenuItem1,
            this.mnuItemForeColor,
            this.mnuItemBackColor});
            this.mnuItemFormat.Name = "mnuItemFormat";
            this.mnuItemFormat.Size = new System.Drawing.Size(61, 20);
            this.mnuItemFormat.Text = "格式(&O)";
            // 
            // mnuItemFont
            // 
            this.mnuItemFont.Name = "mnuItemFont";
            this.mnuItemFont.Size = new System.Drawing.Size(152, 22);
            this.mnuItemFont.Text = "字型(&F)";
            this.mnuItemFont.Click += new System.EventHandler(this.mnuItemFont_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuItemForeColor
            // 
            this.mnuItemForeColor.Name = "mnuItemForeColor";
            this.mnuItemForeColor.Size = new System.Drawing.Size(152, 22);
            this.mnuItemForeColor.Text = "文字色彩(&T)";
            this.mnuItemForeColor.Click += new System.EventHandler(this.mnuItemForeColor_Click);
            // 
            // mnuItemBackColor
            // 
            this.mnuItemBackColor.Name = "mnuItemBackColor";
            this.mnuItemBackColor.Size = new System.Drawing.Size(152, 22);
            this.mnuItemBackColor.Text = "背景色彩(&B)";
            this.mnuItemBackColor.Click += new System.EventHandler(this.mnuItemBackColor_Click);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.HideSelection = false;
            this.txtInput.Location = new System.Drawing.Point(0, 24);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(292, 142);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "Visual C#為了方便Windows應用程式開發，除了\r\n訊息方塊外，還提供預設功能的多種對話方塊，例如：檔案、字型和色彩等對話方塊，我們只需在表單新增這些控" +
    "制項，就可以選取檔案、設定字型和指定色彩。";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 166);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.mnuMain);
            this.Name = "Form1";
            this.Text = "記事本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemForeColor;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBackColor;
        private System.Windows.Forms.FontDialog dlgSetFont;
        private System.Windows.Forms.ColorDialog dlgSetColor;
        public System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSave;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
    }
}

