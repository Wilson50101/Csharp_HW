namespace HW6_P76081108
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnStart = new System.Windows.Forms.Button();
            this.ImgCycle = new System.Windows.Forms.ImageList(this.components);
            this.ImgIcon = new System.Windows.Forms.ImageList(this.components);
            this.BtnStop = new System.Windows.Forms.Button();
            this.picCycle = new System.Windows.Forms.PictureBox();
            this.TmrRun = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.ImageIndex = 0;
            this.BtnStart.ImageList = this.ImgIcon;
            this.BtnStart.Location = new System.Drawing.Point(2, 411);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(50, 50);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ImgCycle
            // 
            this.ImgCycle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgCycle.ImageStream")));
            this.ImgCycle.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgCycle.Images.SetKeyName(0, "cycle.png");
            this.ImgCycle.Images.SetKeyName(1, "cycle1.png");
            this.ImgCycle.Images.SetKeyName(2, "cycle2.png");
            this.ImgCycle.Images.SetKeyName(3, "cycle3.png");
            // 
            // ImgIcon
            // 
            this.ImgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgIcon.ImageStream")));
            this.ImgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgIcon.Images.SetKeyName(0, "start.bmp");
            this.ImgIcon.Images.SetKeyName(1, "stop.bmp");
            // 
            // BtnStop
            // 
            this.BtnStop.ImageIndex = 1;
            this.BtnStop.ImageList = this.ImgIcon;
            this.BtnStop.Location = new System.Drawing.Point(58, 411);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(50, 50);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // picCycle
            // 
            this.picCycle.Location = new System.Drawing.Point(2, 355);
            this.picCycle.Name = "picCycle";
            this.picCycle.Size = new System.Drawing.Size(50, 50);
            this.picCycle.TabIndex = 2;
            this.picCycle.TabStop = false;
            // 
            // TmrRun
            // 
            this.TmrRun.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.picCycle);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCycle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ImageList ImgIcon;
        private System.Windows.Forms.ImageList ImgCycle;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.PictureBox picCycle;
        private System.Windows.Forms.Timer TmrRun;
    }
}

