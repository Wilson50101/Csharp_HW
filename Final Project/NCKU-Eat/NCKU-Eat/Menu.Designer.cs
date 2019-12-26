namespace NCKU_Eat
{
    partial class Menu
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
            this.Lbl_restaurant_name = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_Latitude = new System.Windows.Forms.Label();
            this.Lbl_Longitude = new System.Windows.Forms.Label();
            this.Lbl_Distance = new System.Windows.Forms.Label();
            this.Lbl_Category = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_AllRestaurant = new System.Windows.Forms.Button();
            this.Txt_Restaurant_Name = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Latitude = new System.Windows.Forms.TextBox();
            this.Txt_Longitude = new System.Windows.Forms.TextBox();
            this.Txt_Distance = new System.Windows.Forms.TextBox();
            this.Txt_Category = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_restaurant_name
            // 
            this.Lbl_restaurant_name.AutoSize = true;
            this.Lbl_restaurant_name.Location = new System.Drawing.Point(11, 21);
            this.Lbl_restaurant_name.Name = "Lbl_restaurant_name";
            this.Lbl_restaurant_name.Size = new System.Drawing.Size(32, 12);
            this.Lbl_restaurant_name.TabIndex = 0;
            this.Lbl_restaurant_name.Text = "店名:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(11, 56);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Address.TabIndex = 1;
            this.Lbl_Address.Text = "地址:";
            // 
            // Lbl_Latitude
            // 
            this.Lbl_Latitude.AutoSize = true;
            this.Lbl_Latitude.Location = new System.Drawing.Point(11, 101);
            this.Lbl_Latitude.Name = "Lbl_Latitude";
            this.Lbl_Latitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Latitude.TabIndex = 2;
            this.Lbl_Latitude.Text = "經度:";
            // 
            // Lbl_Longitude
            // 
            this.Lbl_Longitude.AutoSize = true;
            this.Lbl_Longitude.Location = new System.Drawing.Point(11, 141);
            this.Lbl_Longitude.Name = "Lbl_Longitude";
            this.Lbl_Longitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Longitude.TabIndex = 3;
            this.Lbl_Longitude.Text = "緯度:";
            // 
            // Lbl_Distance
            // 
            this.Lbl_Distance.AutoSize = true;
            this.Lbl_Distance.Location = new System.Drawing.Point(11, 183);
            this.Lbl_Distance.Name = "Lbl_Distance";
            this.Lbl_Distance.Size = new System.Drawing.Size(55, 12);
            this.Lbl_Distance.TabIndex = 4;
            this.Lbl_Distance.Text = "距離(km):";
            // 
            // Lbl_Category
            // 
            this.Lbl_Category.AutoSize = true;
            this.Lbl_Category.Location = new System.Drawing.Point(11, 227);
            this.Lbl_Category.Name = "Lbl_Category";
            this.Lbl_Category.Size = new System.Drawing.Size(56, 12);
            this.Lbl_Category.TabIndex = 5;
            this.Lbl_Category.Text = "餐廳類別:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(200, 17);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "新增餐廳";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(200, 56);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(96, 23);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "移除餐廳";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(200, 101);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更新餐廳";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_AllRestaurant
            // 
            this.btn_AllRestaurant.Location = new System.Drawing.Point(200, 141);
            this.btn_AllRestaurant.Name = "btn_AllRestaurant";
            this.btn_AllRestaurant.Size = new System.Drawing.Size(96, 23);
            this.btn_AllRestaurant.TabIndex = 9;
            this.btn_AllRestaurant.Text = "顯示所有餐廳";
            this.btn_AllRestaurant.UseVisualStyleBackColor = true;
            // 
            // Txt_Restaurant_Name
            // 
            this.Txt_Restaurant_Name.Location = new System.Drawing.Point(73, 18);
            this.Txt_Restaurant_Name.Name = "Txt_Restaurant_Name";
            this.Txt_Restaurant_Name.Size = new System.Drawing.Size(100, 22);
            this.Txt_Restaurant_Name.TabIndex = 11;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(73, 53);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(100, 22);
            this.Txt_Address.TabIndex = 12;
            // 
            // Txt_Latitude
            // 
            this.Txt_Latitude.Location = new System.Drawing.Point(73, 98);
            this.Txt_Latitude.Name = "Txt_Latitude";
            this.Txt_Latitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Latitude.TabIndex = 13;
            // 
            // Txt_Longitude
            // 
            this.Txt_Longitude.Location = new System.Drawing.Point(73, 138);
            this.Txt_Longitude.Name = "Txt_Longitude";
            this.Txt_Longitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Longitude.TabIndex = 14;
            // 
            // Txt_Distance
            // 
            this.Txt_Distance.Location = new System.Drawing.Point(73, 180);
            this.Txt_Distance.Name = "Txt_Distance";
            this.Txt_Distance.Size = new System.Drawing.Size(100, 22);
            this.Txt_Distance.TabIndex = 15;
            // 
            // Txt_Category
            // 
            this.Txt_Category.Location = new System.Drawing.Point(73, 224);
            this.Txt_Category.Name = "Txt_Category";
            this.Txt_Category.Size = new System.Drawing.Size(100, 22);
            this.Txt_Category.TabIndex = 16;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Category);
            this.Controls.Add(this.Txt_Distance);
            this.Controls.Add(this.Txt_Longitude);
            this.Controls.Add(this.Txt_Latitude);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Txt_Restaurant_Name);
            this.Controls.Add(this.btn_AllRestaurant);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Lbl_Category);
            this.Controls.Add(this.Lbl_Distance);
            this.Controls.Add(this.Lbl_Longitude);
            this.Controls.Add(this.Lbl_Latitude);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.Lbl_restaurant_name);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_restaurant_name;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_Latitude;
        private System.Windows.Forms.Label Lbl_Longitude;
        private System.Windows.Forms.Label Lbl_Distance;
        private System.Windows.Forms.Label Lbl_Category;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_AllRestaurant;
        private System.Windows.Forms.TextBox Txt_Restaurant_Name;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Latitude;
        private System.Windows.Forms.TextBox Txt_Longitude;
        private System.Windows.Forms.TextBox Txt_Distance;
        private System.Windows.Forms.TextBox Txt_Category;
    }
}

