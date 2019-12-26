namespace NCKU_Eating
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.Lbl_restaurant_name = new System.Windows.Forms.Label();
            this.Lbl_address = new System.Windows.Forms.Label();
            this.Lbl_latitude = new System.Windows.Forms.Label();
            this.Lbl_longitude = new System.Windows.Forms.Label();
            this.Lbl_distance = new System.Windows.Forms.Label();
            this.Lbl_category = new System.Windows.Forms.Label();
            this.Txt_Restaurant = new System.Windows.Forms.TextBox();
            this.Txt_address = new System.Windows.Forms.TextBox();
            this.Txt_Latitude = new System.Windows.Forms.TextBox();
            this.Txt_Longitude = new System.Windows.Forms.TextBox();
            this.Txt_distance = new System.Windows.Forms.TextBox();
            this.Txt_category = new System.Windows.Forms.TextBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增餐廳";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "移除餐廳";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(386, 183);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "更新餐廳";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // Lbl_restaurant_name
            // 
            this.Lbl_restaurant_name.AutoSize = true;
            this.Lbl_restaurant_name.Location = new System.Drawing.Point(112, 99);
            this.Lbl_restaurant_name.Name = "Lbl_restaurant_name";
            this.Lbl_restaurant_name.Size = new System.Drawing.Size(32, 12);
            this.Lbl_restaurant_name.TabIndex = 3;
            this.Lbl_restaurant_name.Text = "店名:";
            // 
            // Lbl_address
            // 
            this.Lbl_address.AutoSize = true;
            this.Lbl_address.Location = new System.Drawing.Point(112, 140);
            this.Lbl_address.Name = "Lbl_address";
            this.Lbl_address.Size = new System.Drawing.Size(32, 12);
            this.Lbl_address.TabIndex = 4;
            this.Lbl_address.Text = "地址:";
            // 
            // Lbl_latitude
            // 
            this.Lbl_latitude.AutoSize = true;
            this.Lbl_latitude.Location = new System.Drawing.Point(112, 183);
            this.Lbl_latitude.Name = "Lbl_latitude";
            this.Lbl_latitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_latitude.TabIndex = 5;
            this.Lbl_latitude.Text = "經度:";
            // 
            // Lbl_longitude
            // 
            this.Lbl_longitude.AutoSize = true;
            this.Lbl_longitude.Location = new System.Drawing.Point(112, 222);
            this.Lbl_longitude.Name = "Lbl_longitude";
            this.Lbl_longitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_longitude.TabIndex = 6;
            this.Lbl_longitude.Text = "緯度:";
            // 
            // Lbl_distance
            // 
            this.Lbl_distance.AutoSize = true;
            this.Lbl_distance.Location = new System.Drawing.Point(112, 269);
            this.Lbl_distance.Name = "Lbl_distance";
            this.Lbl_distance.Size = new System.Drawing.Size(32, 12);
            this.Lbl_distance.TabIndex = 7;
            this.Lbl_distance.Text = "距離:";
            // 
            // Lbl_category
            // 
            this.Lbl_category.AutoSize = true;
            this.Lbl_category.Location = new System.Drawing.Point(112, 314);
            this.Lbl_category.Name = "Lbl_category";
            this.Lbl_category.Size = new System.Drawing.Size(56, 12);
            this.Lbl_category.TabIndex = 8;
            this.Lbl_category.Text = "餐點類別:";
            // 
            // Txt_Restaurant
            // 
            this.Txt_Restaurant.Location = new System.Drawing.Point(218, 99);
            this.Txt_Restaurant.Name = "Txt_Restaurant";
            this.Txt_Restaurant.Size = new System.Drawing.Size(100, 22);
            this.Txt_Restaurant.TabIndex = 9;
            // 
            // Txt_address
            // 
            this.Txt_address.Location = new System.Drawing.Point(218, 137);
            this.Txt_address.Name = "Txt_address";
            this.Txt_address.Size = new System.Drawing.Size(100, 22);
            this.Txt_address.TabIndex = 10;
            // 
            // Txt_Latitude
            // 
            this.Txt_Latitude.Location = new System.Drawing.Point(218, 183);
            this.Txt_Latitude.Name = "Txt_Latitude";
            this.Txt_Latitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Latitude.TabIndex = 11;
            // 
            // Txt_Longitude
            // 
            this.Txt_Longitude.Location = new System.Drawing.Point(218, 222);
            this.Txt_Longitude.Name = "Txt_Longitude";
            this.Txt_Longitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Longitude.TabIndex = 12;
            // 
            // Txt_distance
            // 
            this.Txt_distance.Location = new System.Drawing.Point(218, 259);
            this.Txt_distance.Name = "Txt_distance";
            this.Txt_distance.Size = new System.Drawing.Size(100, 22);
            this.Txt_distance.TabIndex = 13;
            // 
            // Txt_category
            // 
            this.Txt_category.Location = new System.Drawing.Point(218, 304);
            this.Txt_category.Name = "Txt_category";
            this.Txt_category.Size = new System.Drawing.Size(100, 22);
            this.Txt_category.TabIndex = 14;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(386, 222);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(97, 23);
            this.btn_view.TabIndex = 15;
            this.btn_view.Text = "檢視餐廳清單";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 509);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.Txt_category);
            this.Controls.Add(this.Txt_distance);
            this.Controls.Add(this.Txt_Longitude);
            this.Controls.Add(this.Txt_Latitude);
            this.Controls.Add(this.Txt_address);
            this.Controls.Add(this.Txt_Restaurant);
            this.Controls.Add(this.Lbl_category);
            this.Controls.Add(this.Lbl_distance);
            this.Controls.Add(this.Lbl_longitude);
            this.Controls.Add(this.Lbl_latitude);
            this.Controls.Add(this.Lbl_address);
            this.Controls.Add(this.Lbl_restaurant_name);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label Lbl_restaurant_name;
        private System.Windows.Forms.Label Lbl_address;
        private System.Windows.Forms.Label Lbl_latitude;
        private System.Windows.Forms.Label Lbl_longitude;
        private System.Windows.Forms.Label Lbl_distance;
        private System.Windows.Forms.Label Lbl_category;
        private System.Windows.Forms.TextBox Txt_Restaurant;
        private System.Windows.Forms.TextBox Txt_address;
        private System.Windows.Forms.TextBox Txt_Latitude;
        private System.Windows.Forms.TextBox Txt_Longitude;
        private System.Windows.Forms.TextBox Txt_distance;
        private System.Windows.Forms.TextBox Txt_category;
        private System.Windows.Forms.Button btn_view;
    }
}

