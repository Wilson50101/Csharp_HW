namespace HW05_02
{
    partial class FormLogin
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
            this.LblUser_Name = new System.Windows.Forms.Label();
            this.TxtUser_Name = new System.Windows.Forms.TextBox();
            this.LblUserPW = new System.Windows.Forms.Label();
            this.TxtUserPW = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtAllUserData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblUser_Name
            // 
            this.LblUser_Name.AutoSize = true;
            this.LblUser_Name.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblUser_Name.Location = new System.Drawing.Point(12, 9);
            this.LblUser_Name.Name = "LblUser_Name";
            this.LblUser_Name.Size = new System.Drawing.Size(144, 16);
            this.LblUser_Name.TabIndex = 0;
            this.LblUser_Name.Text = "請輸入使用者姓名:";
            // 
            // TxtUser_Name
            // 
            this.TxtUser_Name.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtUser_Name.Location = new System.Drawing.Point(162, 6);
            this.TxtUser_Name.Name = "TxtUser_Name";
            this.TxtUser_Name.Size = new System.Drawing.Size(140, 27);
            this.TxtUser_Name.TabIndex = 1;
            // 
            // LblUserPW
            // 
            this.LblUserPW.AutoSize = true;
            this.LblUserPW.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblUserPW.Location = new System.Drawing.Point(12, 42);
            this.LblUserPW.Name = "LblUserPW";
            this.LblUserPW.Size = new System.Drawing.Size(144, 16);
            this.LblUserPW.TabIndex = 2;
            this.LblUserPW.Text = "請輸入使用者密碼:";
            this.LblUserPW.Click += new System.EventHandler(this.LblUserPW_Click);
            // 
            // TxtUserPW
            // 
            this.TxtUserPW.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtUserPW.Location = new System.Drawing.Point(162, 39);
            this.TxtUserPW.Name = "TxtUserPW";
            this.TxtUserPW.Size = new System.Drawing.Size(140, 27);
            this.TxtUserPW.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLogin.Location = new System.Drawing.Point(308, 14);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(79, 40);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "登入";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtAllUserData
            // 
            this.TxtAllUserData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtAllUserData.Location = new System.Drawing.Point(15, 72);
            this.TxtAllUserData.Multiline = true;
            this.TxtAllUserData.Name = "TxtAllUserData";
            this.TxtAllUserData.Size = new System.Drawing.Size(363, 243);
            this.TxtAllUserData.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 347);
            this.Controls.Add(this.TxtAllUserData);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtUserPW);
            this.Controls.Add(this.LblUserPW);
            this.Controls.Add(this.TxtUser_Name);
            this.Controls.Add(this.LblUser_Name);
            this.Name = "FormLogin";
            this.Text = "使用者登錄";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser_Name;
        private System.Windows.Forms.TextBox TxtUser_Name;
        private System.Windows.Forms.Label LblUserPW;
        private System.Windows.Forms.TextBox TxtUserPW;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtAllUserData;
    }
}

