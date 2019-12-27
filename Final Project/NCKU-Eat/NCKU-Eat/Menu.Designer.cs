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
            this.Lbl_RestaurantID = new System.Windows.Forms.Label();
            this.Txt_RestaurantID = new System.Windows.Forms.TextBox();
            this.pnl_operation = new System.Windows.Forms.Panel();
            this.pnl_operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_restaurant_name
            // 
            this.Lbl_restaurant_name.AutoSize = true;
            this.Lbl_restaurant_name.Location = new System.Drawing.Point(6, 53);
            this.Lbl_restaurant_name.Name = "Lbl_restaurant_name";
            this.Lbl_restaurant_name.Size = new System.Drawing.Size(32, 12);
            this.Lbl_restaurant_name.TabIndex = 0;
            this.Lbl_restaurant_name.Text = "店名:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(6, 88);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Address.TabIndex = 1;
            this.Lbl_Address.Text = "地址:";
            // 
            // Lbl_Latitude
            // 
            this.Lbl_Latitude.AutoSize = true;
            this.Lbl_Latitude.Location = new System.Drawing.Point(6, 133);
            this.Lbl_Latitude.Name = "Lbl_Latitude";
            this.Lbl_Latitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Latitude.TabIndex = 2;
            this.Lbl_Latitude.Text = "經度:";
            // 
            // Lbl_Longitude
            // 
            this.Lbl_Longitude.AutoSize = true;
            this.Lbl_Longitude.Location = new System.Drawing.Point(6, 173);
            this.Lbl_Longitude.Name = "Lbl_Longitude";
            this.Lbl_Longitude.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Longitude.TabIndex = 3;
            this.Lbl_Longitude.Text = "緯度:";
            // 
            // Lbl_Distance
            // 
            this.Lbl_Distance.AutoSize = true;
            this.Lbl_Distance.Location = new System.Drawing.Point(6, 215);
            this.Lbl_Distance.Name = "Lbl_Distance";
            this.Lbl_Distance.Size = new System.Drawing.Size(55, 12);
            this.Lbl_Distance.TabIndex = 4;
            this.Lbl_Distance.Text = "距離(km):";
            // 
            // Lbl_Category
            // 
            this.Lbl_Category.AutoSize = true;
            this.Lbl_Category.Location = new System.Drawing.Point(6, 259);
            this.Lbl_Category.Name = "Lbl_Category";
            this.Lbl_Category.Size = new System.Drawing.Size(56, 12);
            this.Lbl_Category.TabIndex = 5;
            this.Lbl_Category.Text = "餐廳類別:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(193, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "新增餐廳";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(193, 51);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(96, 23);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "移除餐廳";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(193, 96);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更新餐廳";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AllRestaurant
            // 
            this.btn_AllRestaurant.Location = new System.Drawing.Point(193, 136);
            this.btn_AllRestaurant.Name = "btn_AllRestaurant";
            this.btn_AllRestaurant.Size = new System.Drawing.Size(96, 23);
            this.btn_AllRestaurant.TabIndex = 9;
            this.btn_AllRestaurant.Text = "顯示所有餐廳";
            this.btn_AllRestaurant.UseVisualStyleBackColor = true;
            this.btn_AllRestaurant.Click += new System.EventHandler(this.btn_AllRestaurant_Click);
            // 
            // Txt_Restaurant_Name
            // 
            this.Txt_Restaurant_Name.Location = new System.Drawing.Point(68, 50);
            this.Txt_Restaurant_Name.Name = "Txt_Restaurant_Name";
            this.Txt_Restaurant_Name.Size = new System.Drawing.Size(100, 22);
            this.Txt_Restaurant_Name.TabIndex = 11;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(68, 85);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(100, 22);
            this.Txt_Address.TabIndex = 12;
            // 
            // Txt_Latitude
            // 
            this.Txt_Latitude.Location = new System.Drawing.Point(68, 130);
            this.Txt_Latitude.Name = "Txt_Latitude";
            this.Txt_Latitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Latitude.TabIndex = 13;
            // 
            // Txt_Longitude
            // 
            this.Txt_Longitude.Location = new System.Drawing.Point(68, 170);
            this.Txt_Longitude.Name = "Txt_Longitude";
            this.Txt_Longitude.Size = new System.Drawing.Size(100, 22);
            this.Txt_Longitude.TabIndex = 14;
            // 
            // Txt_Distance
            // 
            this.Txt_Distance.Location = new System.Drawing.Point(68, 212);
            this.Txt_Distance.Name = "Txt_Distance";
            this.Txt_Distance.Size = new System.Drawing.Size(100, 22);
            this.Txt_Distance.TabIndex = 15;
            // 
            // Txt_Category
            // 
            this.Txt_Category.Location = new System.Drawing.Point(68, 256);
            this.Txt_Category.Name = "Txt_Category";
            this.Txt_Category.Size = new System.Drawing.Size(100, 22);
            this.Txt_Category.TabIndex = 16;
            // 
            // Lbl_RestaurantID
            // 
            this.Lbl_RestaurantID.AutoSize = true;
            this.Lbl_RestaurantID.Location = new System.Drawing.Point(6, 17);
            this.Lbl_RestaurantID.Name = "Lbl_RestaurantID";
            this.Lbl_RestaurantID.Size = new System.Drawing.Size(32, 12);
            this.Lbl_RestaurantID.TabIndex = 17;
            this.Lbl_RestaurantID.Text = "編號:";
            // 
            // Txt_RestaurantID
            // 
            this.Txt_RestaurantID.Location = new System.Drawing.Point(68, 14);
            this.Txt_RestaurantID.Name = "Txt_RestaurantID";
            this.Txt_RestaurantID.Size = new System.Drawing.Size(100, 22);
            this.Txt_RestaurantID.TabIndex = 18;
            // 
            // pnl_operation
            // 
            this.pnl_operation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_operation.Controls.Add(this.btn_AllRestaurant);
            this.pnl_operation.Controls.Add(this.Txt_RestaurantID);
            this.pnl_operation.Controls.Add(this.Lbl_restaurant_name);
            this.pnl_operation.Controls.Add(this.Lbl_RestaurantID);
            this.pnl_operation.Controls.Add(this.Lbl_Address);
            this.pnl_operation.Controls.Add(this.Txt_Category);
            this.pnl_operation.Controls.Add(this.Lbl_Latitude);
            this.pnl_operation.Controls.Add(this.Txt_Distance);
            this.pnl_operation.Controls.Add(this.Lbl_Longitude);
            this.pnl_operation.Controls.Add(this.Txt_Longitude);
            this.pnl_operation.Controls.Add(this.Lbl_Distance);
            this.pnl_operation.Controls.Add(this.Txt_Latitude);
            this.pnl_operation.Controls.Add(this.Lbl_Category);
            this.pnl_operation.Controls.Add(this.Txt_Address);
            this.pnl_operation.Controls.Add(this.btn_Add);
            this.pnl_operation.Controls.Add(this.Txt_Restaurant_Name);
            this.pnl_operation.Controls.Add(this.btn_Remove);
            this.pnl_operation.Controls.Add(this.btn_Update);
            this.pnl_operation.Location = new System.Drawing.Point(12, 12);
            this.pnl_operation.Name = "pnl_operation";
            this.pnl_operation.Size = new System.Drawing.Size(300, 303);
            this.pnl_operation.TabIndex = 19;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_operation);
            this.Name = "Menu";
            this.Text = "Menu";
            this.pnl_operation.ResumeLayout(false);
            this.pnl_operation.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label Lbl_RestaurantID;
        private System.Windows.Forms.TextBox Txt_RestaurantID;
        private System.Windows.Forms.Panel pnl_operation;
    }
}

