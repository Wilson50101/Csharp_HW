namespace HW7
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.readTxt = new System.Windows.Forms.ToolStripButton();
            this.keymanually = new System.Windows.Forms.ToolStripButton();
            this.clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newfontsize = new System.Windows.Forms.ToolStripTextBox();
            this.fontcolor = new System.Windows.Forms.ToolStripDropDownButton();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsizechange = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readTxt,
            this.keymanually,
            this.clear,
            this.toolStripSeparator1,
            this.fontsizechange,
            this.newfontsize,
            this.fontcolor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // readTxt
            // 
            this.readTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.readTxt.Image = ((System.Drawing.Image)(resources.GetObject("readTxt.Image")));
            this.readTxt.ImageTransparentColor = System.Drawing.Color.Linen;
            this.readTxt.Name = "readTxt";
            this.readTxt.Size = new System.Drawing.Size(69, 22);
            this.readTxt.Text = "讀取TXT檔";
            this.readTxt.Click += new System.EventHandler(this.readTxt_Click);
            // 
            // keymanually
            // 
            this.keymanually.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.keymanually.Image = ((System.Drawing.Image)(resources.GetObject("keymanually.Image")));
            this.keymanually.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.keymanually.Name = "keymanually";
            this.keymanually.Size = new System.Drawing.Size(59, 22);
            this.keymanually.Text = "自行輸入";
            this.keymanually.Click += new System.EventHandler(this.keymanually_Click);
            // 
            // clear
            // 
            this.clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 22);
            this.clear.Text = "清除文字";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // newfontsize
            // 
            this.newfontsize.Name = "newfontsize";
            this.newfontsize.Size = new System.Drawing.Size(100, 25);
            this.newfontsize.Click += new System.EventHandler(this.newfontsize_Click);
            // 
            // fontcolor
            // 
            this.fontcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontcolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑色ToolStripMenuItem,
            this.紅色ToolStripMenuItem,
            this.綠色ToolStripMenuItem,
            this.藍色ToolStripMenuItem});
            this.fontcolor.Image = ((System.Drawing.Image)(resources.GetObject("fontcolor.Image")));
            this.fontcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontcolor.Name = "fontcolor";
            this.fontcolor.Size = new System.Drawing.Size(68, 22);
            this.fontcolor.Text = "字體顏色";
            this.fontcolor.Click += new System.EventHandler(this.fontcolor_Click);
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(99, 52);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(555, 323);
            this.TxtShow.TabIndex = 1;
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.黑色ToolStripMenuItem.Text = "黑色";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 紅色ToolStripMenuItem
            // 
            this.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            this.紅色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.紅色ToolStripMenuItem.Text = "紅色";
            this.紅色ToolStripMenuItem.Click += new System.EventHandler(this.紅色ToolStripMenuItem_Click);
            // 
            // 綠色ToolStripMenuItem
            // 
            this.綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            this.綠色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.綠色ToolStripMenuItem.Text = "綠色";
            this.綠色ToolStripMenuItem.Click += new System.EventHandler(this.綠色ToolStripMenuItem_Click);
            // 
            // 藍色ToolStripMenuItem
            // 
            this.藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            this.藍色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.藍色ToolStripMenuItem.Text = "藍色";
            this.藍色ToolStripMenuItem.Click += new System.EventHandler(this.藍色ToolStripMenuItem_Click);
            // 
            // fontsizechange
            // 
            this.fontsizechange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontsizechange.Image = ((System.Drawing.Image)(resources.GetObject("fontsizechange.Image")));
            this.fontsizechange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontsizechange.Name = "fontsizechange";
            this.fontsizechange.Size = new System.Drawing.Size(86, 22);
            this.fontsizechange.Text = "字型大小調整:";
            this.fontsizechange.Click += new System.EventHandler(this.fontsizechange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton readTxt;
        private System.Windows.Forms.ToolStripButton keymanually;
        private System.Windows.Forms.ToolStripButton clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox newfontsize;
        private System.Windows.Forms.ToolStripDropDownButton fontcolor;
        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton fontsizechange;
    }
}

