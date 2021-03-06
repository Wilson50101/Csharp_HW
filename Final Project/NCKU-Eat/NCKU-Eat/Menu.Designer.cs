﻿namespace NCKU_Eat
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
            this.Lbl_Lng = new System.Windows.Forms.Label();
            this.Lbl_Lat = new System.Windows.Forms.Label();
            this.Lbl_Distance = new System.Windows.Forms.Label();
            this.Lbl_Category = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_AllRestaurant = new System.Windows.Forms.Button();
            this.Txt_Restaurant_Name = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Lng = new System.Windows.Forms.TextBox();
            this.Txt_Lat = new System.Windows.Forms.TextBox();
            this.Txt_Distance = new System.Windows.Forms.TextBox();
            this.Txt_Category = new System.Windows.Forms.TextBox();
            this.Lbl_RestaurantID = new System.Windows.Forms.Label();
            this.Txt_RestaurantID = new System.Windows.Forms.TextBox();
            this.pnl_operation = new System.Windows.Forms.Panel();
            this.btn_show_on_map = new System.Windows.Forms.Button();
            this.Lbl_select_distance_lessthan = new System.Windows.Forms.Label();
            this.Txt_condition_distance = new System.Windows.Forms.TextBox();
            this.DGV_selected_restaurant = new System.Windows.Forms.DataGridView();
            this.rdb_showall = new System.Windows.Forms.RadioButton();
            this.rdb_select_random = new System.Windows.Forms.RadioButton();
            this.groupBox_selection = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.web_map = new System.Windows.Forms.WebBrowser();
            this.pnl_operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_selected_restaurant)).BeginInit();
            this.groupBox_selection.SuspendLayout();
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
            // Lbl_Lng
            // 
            this.Lbl_Lng.AutoSize = true;
            this.Lbl_Lng.Location = new System.Drawing.Point(6, 133);
            this.Lbl_Lng.Name = "Lbl_Lng";
            this.Lbl_Lng.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Lng.TabIndex = 2;
            this.Lbl_Lng.Text = "經度:";
            // 
            // Lbl_Lat
            // 
            this.Lbl_Lat.AutoSize = true;
            this.Lbl_Lat.Location = new System.Drawing.Point(6, 173);
            this.Lbl_Lat.Name = "Lbl_Lat";
            this.Lbl_Lat.Size = new System.Drawing.Size(32, 12);
            this.Lbl_Lat.TabIndex = 3;
            this.Lbl_Lat.Text = "緯度:";
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
            this.btn_Remove.Location = new System.Drawing.Point(193, 48);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(96, 23);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "移除餐廳";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(193, 83);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更新餐廳";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AllRestaurant
            // 
            this.btn_AllRestaurant.Location = new System.Drawing.Point(193, 128);
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
            // Txt_Lng
            // 
            this.Txt_Lng.Location = new System.Drawing.Point(68, 130);
            this.Txt_Lng.Name = "Txt_Lng";
            this.Txt_Lng.Size = new System.Drawing.Size(100, 22);
            this.Txt_Lng.TabIndex = 13;
            // 
            // Txt_Lat
            // 
            this.Txt_Lat.Location = new System.Drawing.Point(68, 170);
            this.Txt_Lat.Name = "Txt_Lat";
            this.Txt_Lat.Size = new System.Drawing.Size(100, 22);
            this.Txt_Lat.TabIndex = 14;
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
            this.pnl_operation.Controls.Add(this.btn_show_on_map);
            this.pnl_operation.Controls.Add(this.btn_AllRestaurant);
            this.pnl_operation.Controls.Add(this.Txt_RestaurantID);
            this.pnl_operation.Controls.Add(this.Lbl_restaurant_name);
            this.pnl_operation.Controls.Add(this.Lbl_RestaurantID);
            this.pnl_operation.Controls.Add(this.Lbl_Address);
            this.pnl_operation.Controls.Add(this.Txt_Category);
            this.pnl_operation.Controls.Add(this.Lbl_Lng);
            this.pnl_operation.Controls.Add(this.Txt_Distance);
            this.pnl_operation.Controls.Add(this.Lbl_Lat);
            this.pnl_operation.Controls.Add(this.Txt_Lat);
            this.pnl_operation.Controls.Add(this.Lbl_Distance);
            this.pnl_operation.Controls.Add(this.Txt_Lng);
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
            // btn_show_on_map
            // 
            this.btn_show_on_map.Location = new System.Drawing.Point(193, 168);
            this.btn_show_on_map.Name = "btn_show_on_map";
            this.btn_show_on_map.Size = new System.Drawing.Size(96, 23);
            this.btn_show_on_map.TabIndex = 19;
            this.btn_show_on_map.Text = "在地圖中顯示";
            this.btn_show_on_map.UseVisualStyleBackColor = true;
            this.btn_show_on_map.Click += new System.EventHandler(this.btn_show_on_map_Click);
            // 
            // Lbl_select_distance_lessthan
            // 
            this.Lbl_select_distance_lessthan.AutoSize = true;
            this.Lbl_select_distance_lessthan.Location = new System.Drawing.Point(534, 25);
            this.Lbl_select_distance_lessthan.Name = "Lbl_select_distance_lessthan";
            this.Lbl_select_distance_lessthan.Size = new System.Drawing.Size(221, 12);
            this.Lbl_select_distance_lessthan.TabIndex = 20;
            this.Lbl_select_distance_lessthan.Text = "條件:距離<=                                m內的餐廳";
            // 
            // Txt_condition_distance
            // 
            this.Txt_condition_distance.Location = new System.Drawing.Point(605, 20);
            this.Txt_condition_distance.Name = "Txt_condition_distance";
            this.Txt_condition_distance.Size = new System.Drawing.Size(78, 22);
            this.Txt_condition_distance.TabIndex = 19;
            // 
            // DGV_selected_restaurant
            // 
            this.DGV_selected_restaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_selected_restaurant.Location = new System.Drawing.Point(341, 96);
            this.DGV_selected_restaurant.Name = "DGV_selected_restaurant";
            this.DGV_selected_restaurant.RowTemplate.Height = 24;
            this.DGV_selected_restaurant.Size = new System.Drawing.Size(432, 119);
            this.DGV_selected_restaurant.TabIndex = 21;
            // 
            // rdb_showall
            // 
            this.rdb_showall.AutoSize = true;
            this.rdb_showall.Location = new System.Drawing.Point(6, 24);
            this.rdb_showall.Name = "rdb_showall";
            this.rdb_showall.Size = new System.Drawing.Size(155, 16);
            this.rdb_showall.TabIndex = 22;
            this.rdb_showall.TabStop = true;
            this.rdb_showall.Text = "顯示全部符合條件的餐廳";
            this.rdb_showall.UseVisualStyleBackColor = true;
            // 
            // rdb_select_random
            // 
            this.rdb_select_random.AutoSize = true;
            this.rdb_select_random.Location = new System.Drawing.Point(6, 50);
            this.rdb_select_random.Name = "rdb_select_random";
            this.rdb_select_random.Size = new System.Drawing.Size(179, 16);
            this.rdb_select_random.TabIndex = 23;
            this.rdb_select_random.TabStop = true;
            this.rdb_select_random.Text = "從符合條件的餐廳隨機挑一個";
            this.rdb_select_random.UseVisualStyleBackColor = true;
            // 
            // groupBox_selection
            // 
            this.groupBox_selection.Controls.Add(this.rdb_showall);
            this.groupBox_selection.Controls.Add(this.rdb_select_random);
            this.groupBox_selection.Location = new System.Drawing.Point(341, 12);
            this.groupBox_selection.Name = "groupBox_selection";
            this.groupBox_selection.Size = new System.Drawing.Size(187, 78);
            this.groupBox_selection.TabIndex = 24;
            this.groupBox_selection.TabStop = false;
            this.groupBox_selection.Text = "挑選餐廳模式";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(587, 59);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(96, 23);
            this.btn_select.TabIndex = 25;
            this.btn_select.Text = "挑選餐廳";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // web_map
            // 
            this.web_map.Location = new System.Drawing.Point(341, 225);
            this.web_map.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_map.Name = "web_map";
            this.web_map.ScriptErrorsSuppressed = true;
            this.web_map.Size = new System.Drawing.Size(757, 311);
            this.web_map.TabIndex = 26;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 557);
            this.Controls.Add(this.web_map);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.groupBox_selection);
            this.Controls.Add(this.DGV_selected_restaurant);
            this.Controls.Add(this.Txt_condition_distance);
            this.Controls.Add(this.Lbl_select_distance_lessthan);
            this.Controls.Add(this.pnl_operation);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnl_operation.ResumeLayout(false);
            this.pnl_operation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_selected_restaurant)).EndInit();
            this.groupBox_selection.ResumeLayout(false);
            this.groupBox_selection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_restaurant_name;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_Lng;
        private System.Windows.Forms.Label Lbl_Lat;
        private System.Windows.Forms.Label Lbl_Distance;
        private System.Windows.Forms.Label Lbl_Category;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_AllRestaurant;
        private System.Windows.Forms.TextBox Txt_Restaurant_Name;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Lng;
        private System.Windows.Forms.TextBox Txt_Lat;
        private System.Windows.Forms.TextBox Txt_Distance;
        private System.Windows.Forms.TextBox Txt_Category;
        private System.Windows.Forms.Label Lbl_RestaurantID;
        private System.Windows.Forms.TextBox Txt_RestaurantID;
        private System.Windows.Forms.Panel pnl_operation;
        private System.Windows.Forms.Label Lbl_select_distance_lessthan;
        private System.Windows.Forms.TextBox Txt_condition_distance;
        private System.Windows.Forms.DataGridView DGV_selected_restaurant;
        private System.Windows.Forms.RadioButton rdb_showall;
        private System.Windows.Forms.RadioButton rdb_select_random;
        private System.Windows.Forms.GroupBox groupBox_selection;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_show_on_map;
        private System.Windows.Forms.WebBrowser web_map;
    }
}

