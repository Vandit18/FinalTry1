using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalTry1
{
    public class OtterBoxSalesHistory
    {
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe";
        public Int32 AddProduct(OtterBoxSales sale)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "INSERT INTO OtterBoxSalesHistory(id,ModelName,ModelType,ModelColor,ModelInStock,ModelSold,ModelCurrentStock) Values (@Id,@ModelName,@ModelType,@ModelColor,@ModelInStock,@ModelSold,@ModelCurrentStock) ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Id", MySqlDbType.Decimal).Value = sale.ID;
                cmand.Parameters.Add("@ModelName", MySqlDbType.VarChar).Value = sale.OtterBoxModel;
                cmand.Parameters.Add("@ModelType", MySqlDbType.VarChar).Value = sale.Type;
                cmand.Parameters.Add("@ModelColor", MySqlDbType.VarChar).Value = sale.Color;
                cmand.Parameters.Add("@ModelInStock", MySqlDbType.Decimal).Value = sale.InStock;
                cmand.Parameters.Add("@ModelSold", MySqlDbType.Decimal).Value = sale.Sold;
                cmand.Parameters.Add("@ModelCurrentStock", MySqlDbType.Decimal).Value = sale.ModelStock;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 UpdateProduct(OtterBoxSales sale)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "UPDATE OtterBoxSalesHistory SET ModelName=@ModelName,ModelType=@ModelType,ModelColor=@ModelColor,ModelInStock=@ModelInStock,ModelSold=@ModelSold,ModelCurrentStock=@ModelCurrentStock WHERE Id=@Id";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Id", MySqlDbType.Decimal).Value = sale.ID;
                cmand.Parameters.Add("@ModelName", MySqlDbType.VarChar).Value = sale.OtterBoxModel;
                cmand.Parameters.Add("@ModelType", MySqlDbType.VarChar).Value = sale.Type;
                cmand.Parameters.Add("@ModelColor", MySqlDbType.VarChar).Value = sale.Color;
                cmand.Parameters.Add("@ModelInStock", MySqlDbType.Decimal).Value = sale.InStock;
                cmand.Parameters.Add("@ModelSold", MySqlDbType.Decimal).Value = sale.Sold;
                cmand.Parameters.Add("@ModelCurrentStock", MySqlDbType.Decimal).Value = sale.ModelStock;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 DeleteProduct(OtterBoxSales sale)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "Delete from OtterBoxSalesHistory where Id=@Id ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Id", MySqlDbType.Decimal).Value = sale.ID;
                cmand.Parameters.Add("@ModelName", MySqlDbType.VarChar).Value = sale.OtterBoxModel;
                cmand.Parameters.Add("@ModelType", MySqlDbType.VarChar).Value = sale.Type;
                cmand.Parameters.Add("@ModelColor", MySqlDbType.VarChar).Value = sale.Color;
                cmand.Parameters.Add("@ModelInStock", MySqlDbType.Decimal).Value = sale.InStock;
                cmand.Parameters.Add("@ModelSold", MySqlDbType.Decimal).Value = sale.Sold;
                cmand.Parameters.Add("@ModelCurrentStock", MySqlDbType.Decimal).Value = sale.ModelStock;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }
        public List<OtterBoxSales> getProducts()
        {
            List<OtterBoxSales> OtterBoxSalesHistory = new List<OtterBoxSales>();
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "select Id,ModelName,ModelType,ModelColor,ModelInStock,ModelSold,ModelCurrentStock from OtterBoxSalesHistory";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader reader = cmand.ExecuteReader();
                while (reader.Read())
                {
                    OtterBoxSalesHistory.Add(new OtterBoxSales { ID = int.Parse(reader["Id"].ToString()), OtterBoxModel = reader["ModelName"].ToString(), Type = reader["ModelType"].ToString(), Color = reader["ModelColor"].ToString(), InStock =int.Parse(reader["ModelInStock"].ToString()), Sold=int.Parse(reader["ModelSold"].ToString()),ModelStock=int.Parse( reader["ModelCurrentStock"].ToString()) });
                }

                return OtterBoxSalesHistory;
            }
        }
    }
}