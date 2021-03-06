﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerService.DB
{
    public struct Item
    {
        public int ItemID;
        public string ItemName;
        public string ItemType;
        public int ItemPrice;
        public string ItemCare;
    }
    public class ItemDB : IDisposable
    {
        MySqlConnection conn;
        public ItemDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Flower"].ConnectionString;

            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 등록된 제품목록을 조회
        /// </summary>
        /// <returns></returns>
        public DataTable GetProductList()
        {
            string sql = @"select item_id, item_prcie, item_name, item_care, item_type
                           from flwitem";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public DataTable GetProductListImage()
        {
            string sql = @"";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public DataTable GetProductImageList(int pid)
        {
            string sql = @"select  item_id, item_prcie, item_care, item_type, item_name
                        from flwitem where item_id = @item_id";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.Add("@item_id", MySqlDbType.Int32);
            da.SelectCommand.Parameters["@item_id"].Value = pid;

            da.Fill(dt);
            return dt;
        }

        public bool AddProductImage(int pid, string path)
        {
            string sql = @"insert into flwitem_detail (item_ID, itemD_ImgName)
                            value (@item_ID, @itemD_ImgName)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@item_ID", MySqlDbType.Int32);
            cmd.Parameters["@item_ID"].Value = pid;

            cmd.Parameters.Add("@itemD_ImgName", MySqlDbType.VarChar);
            cmd.Parameters["@itemD_ImgName"].Value = path;

            int iResult = cmd.ExecuteNonQuery();
            if (iResult > 0)
                return true;
            else
                return false;
        }


        public bool DelProductImage(int pid, string path)
        {
            string sql = @"delete from flwitem_detail
                        where item_ID = @item_ID and itemD_ImgName = @itemD_ImgName";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@item_ID", MySqlDbType.Int32);
            cmd.Parameters["@item_ID"].Value = pid;
            cmd.Parameters.Add("@itemD_ImgName", MySqlDbType.VarChar);
            cmd.Parameters["@itemD_ImgName"].Value = path;

            int iRowAffect = cmd.ExecuteNonQuery();
            if (iRowAffect > 0)
                return true;
            else
                return false;
        }

        public void Insert(Item item)
        {
            string sql = $@"INSERT INTO flwitem( item_id, item_name,item_prcie, item_care, item_type) 
                            VALUES (@item_id, @item_name, @item_prcie, @item_care , @item_type )";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@item_id", MySqlDbType.Int32);
            cmd.Parameters["@item_id"].Value = item.ItemID;
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar);
            cmd.Parameters["@item_name"].Value = item.ItemName;
            cmd.Parameters.Add("@item_prcie", MySqlDbType.Int32);
            cmd.Parameters["@item_prcie"].Value = item.ItemPrice;
            cmd.Parameters.Add("@item_care", MySqlDbType.VarChar);
            cmd.Parameters["@item_care"].Value = item.ItemCare;
            cmd.Parameters.Add("@item_type", MySqlDbType.VarChar);
            cmd.Parameters["@item_type"].Value = item.ItemType;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public bool Delete(int itemID)
        {
            try
            {
                string sql = $@"update flwitem 
                                   set deleted = 1 
                                 where item_id = {itemID}";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

    }
}