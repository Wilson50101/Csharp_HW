namespace HW8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_bookid = new System.Windows.Forms.Label();
            this.Lbl_bookname = new System.Windows.Forms.Label();
            this.Lbl_price = new System.Windows.Forms.Label();
            this.Lbl_author = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // Lbl_bookid
            // 
            this.Lbl_bookid.AutoSize = true;
            this.Lbl_bookid.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_bookid.Location = new System.Drawing.Point(55, 59);
            this.Lbl_bookid.Name = "Lbl_bookid";
            this.Lbl_bookid.Size = new System.Drawing.Size(65, 21);
            this.Lbl_bookid.TabIndex = 1;
            this.Lbl_bookid.Text = "書號:";
            // 
            // Lbl_bookname
            // 
            this.Lbl_bookname.AutoSize = true;
            this.Lbl_bookname.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_bookname.Location = new System.Drawing.Point(287, 59);
            this.Lbl_bookname.Name = "Lbl_bookname";
            this.Lbl_bookname.Size = new System.Drawing.Size(65, 21);
            this.Lbl_bookname.TabIndex = 2;
            this.Lbl_bookname.Text = "書名:";
            // 
            // Lbl_price
            // 
            this.Lbl_price.AutoSize = true;
            this.Lbl_price.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_price.Location = new System.Drawing.Point(287, 147);
            this.Lbl_price.Name = "Lbl_price";
            this.Lbl_price.Size = new System.Drawing.Size(65, 21);
            this.Lbl_price.TabIndex = 3;
            this.Lbl_price.Text = "定價:";
            // 
            // Lbl_author
            // 
            this.Lbl_author.AutoSize = true;
            this.Lbl_author.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_author.Location = new System.Drawing.Point(55, 146);
            this.Lbl_author.Name = "Lbl_author";
            this.Lbl_author.Size = new System.Drawing.Size(65, 21);
            this.Lbl_author.TabIndex = 4;
            this.Lbl_author.Text = "作者:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(126, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(126, 146);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(358, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(358, 146);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(583, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 35);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_update.Location = new System.Drawing.Point(583, 105);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 35);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delete.Location = new System.Drawing.Point(583, 181);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 35);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Lbl_author);
            this.Controls.Add(this.Lbl_price);
            this.Controls.Add(this.Lbl_bookname);
            this.Controls.Add(this.Lbl_bookid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_bookid;
        private System.Windows.Forms.Label Lbl_bookname;
        private System.Windows.Forms.Label Lbl_price;
        private System.Windows.Forms.Label Lbl_author;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}

