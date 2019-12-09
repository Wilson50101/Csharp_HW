namespace HW5
{
    partial class form_compound_sum
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblPrincipal = new System.Windows.Forms.Label();
            this.LblInterest = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.TxtPrincipal = new System.Windows.Forms.TextBox();
            this.TxtInterest = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(363, 134);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "計算";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblPrincipal
            // 
            this.LblPrincipal.AutoSize = true;
            this.LblPrincipal.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblPrincipal.Location = new System.Drawing.Point(12, 83);
            this.LblPrincipal.Name = "LblPrincipal";
            this.LblPrincipal.Size = new System.Drawing.Size(109, 21);
            this.LblPrincipal.TabIndex = 1;
            this.LblPrincipal.Text = "本金(元):";
            // 
            // LblInterest
            // 
            this.LblInterest.AutoSize = true;
            this.LblInterest.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblInterest.Location = new System.Drawing.Point(247, 83);
            this.LblInterest.Name = "LblInterest";
            this.LblInterest.Size = new System.Drawing.Size(98, 21);
            this.LblInterest.TabIndex = 2;
            this.LblInterest.Text = "利率(%):";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblYear.Location = new System.Drawing.Point(12, 137);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(153, 21);
            this.LblYear.TabIndex = 3;
            this.LblYear.Text = "存款年數(年):";
            this.LblYear.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtPrincipal
            // 
            this.TxtPrincipal.Location = new System.Drawing.Point(127, 83);
            this.TxtPrincipal.Name = "TxtPrincipal";
            this.TxtPrincipal.Size = new System.Drawing.Size(100, 22);
            this.TxtPrincipal.TabIndex = 4;
            // 
            // TxtInterest
            // 
            this.TxtInterest.Location = new System.Drawing.Point(363, 83);
            this.TxtInterest.Name = "TxtInterest";
            this.TxtInterest.Size = new System.Drawing.Size(100, 22);
            this.TxtInterest.TabIndex = 5;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(171, 136);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(100, 22);
            this.TxtYear.TabIndex = 6;
            // 
            // form_compound_sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 248);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtInterest);
            this.Controls.Add(this.TxtPrincipal);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblInterest);
            this.Controls.Add(this.LblPrincipal);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "form_compound_sum";
            this.Text = "視窗複利計算程式";
            this.Load += new System.EventHandler(this.form_compound_sum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblPrincipal;
        private System.Windows.Forms.Label LblInterest;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.TextBox TxtPrincipal;
        private System.Windows.Forms.TextBox TxtInterest;
        private System.Windows.Forms.TextBox TxtYear;
    }
}

