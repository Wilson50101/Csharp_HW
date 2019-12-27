﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NCKU_Eat
{

    public partial class Menu : Form
    {
        //地球半徑，單位:m
        private const double EARTH_RADIUS = 6378137;
        //資工系館的經緯度
        PointF PositionCSIE = new PointF(120.221510f,22.996992f);
        //建立RetaurantEntities物件,此物件可以管理Restaurant.mdf資料庫
        RestaurantEntities resDB = new RestaurantEntities();
        public Menu()
        {
            InitializeComponent();
        }

        //計算兩點距離位置，單位：m
        //公式為google提供誤差<0.2m
        //(lat1,lng1)=第一點之經緯度
        //(lat2,lng2)=第二點之經緯度
        public static float GetDistance(float lat1, float lng1, float lat2,float lng2)
        {
            float radLat1 = Rad(lat1);
            float radLng1 = Rad(lng1);
            float radLat2 = Rad(lat2);
            float radLng2 = Rad(lng2);
            float a = radLat1 - radLat2;
            float b = radLng1 - radLng2;
            float result = (float)(2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) + Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2))) * EARTH_RADIUS);
            return result;
        }

        //經緯度轉弧度
        private static float Rad(float d)
        {
            return (float)(d * Math.PI / 180d);
        }
        private void btn_AllRestaurant_Click(object sender, EventArgs e)
        {
            AllRestaurant allRestaurant = new AllRestaurant();
            allRestaurant.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                餐廳 newres = new 餐廳();
                newres.Id = int.Parse(Txt_RestaurantID.Text);
                newres.店名 = Txt_Restaurant_Name.Text;
                newres.地址 = Txt_Address.Text;
                newres.經度 = System.Math.Round(float.Parse(Txt_Latitude.Text),6);
                newres.緯度 = System.Math.Round(float.Parse(Txt_Longitude.Text),6); 
                newres.距離 = System.Math.Round(GetDistance((float)newres.經度, (float)newres.緯度, PositionCSIE.X, PositionCSIE.Y),2);
                newres.餐廳類別 = Txt_Category.Text;
                resDB.餐廳.Add(newres);
                resDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("確定要刪除此餐廳?", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var removed = resDB.餐廳.Where(r => r.Id.ToString() == Txt_RestaurantID.Text).FirstOrDefault();
                    if (removed == null)
                        return;
                    resDB.餐廳.Remove(removed);
                    resDB.SaveChanges();
                    MessageBox.Show("餐廳:" + removed.店名 + "已被刪除", "已刪除餐廳", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                var updated = resDB.餐廳.Where(r => r.Id.ToString() == Txt_RestaurantID.Text).FirstOrDefault();
                if (updated == null)
                    return;
                updated.店名 = Txt_Restaurant_Name.Text;
                updated.地址 = Txt_Address.Text;
                updated.經度 = System.Math.Round(float.Parse(Txt_Latitude.Text), 6);
                updated.緯度 = System.Math.Round(float.Parse(Txt_Longitude.Text), 6);
                updated.距離 = System.Math.Round(GetDistance((float)updated.經度, (float)updated.緯度, PositionCSIE.X, PositionCSIE.Y), 2);
                updated.餐廳類別 = Txt_Category.Text;
                resDB.SaveChanges();
                MessageBox.Show("餐廳:" + updated.店名 + "已被更新", "已更新餐廳", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
