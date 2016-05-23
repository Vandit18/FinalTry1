using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalTry1
{
    public class ProductProvider
    {
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe;Port=3307";
        public Int32 AddProduct(Product product)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "INSERT INTO prodcuts(bookname,description,price) Values (@Name,@Description,@Price) ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = product.BookName;
                cmand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = product.Description;
                cmand.Parameters.Add("@Price", MySqlDbType.Decimal).Value = product.price;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 UpdateProduct(Product product)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "UPDATE products SET bookname=@Name,description=@Description,price=@Price WHERE id=@Id ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = product.BookName;
                cmand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = product.Description;
                cmand.Parameters.Add("@Price", MySqlDbType.Decimal).Value = product.price;
                cmand.Parameters.Add("@Id", MySqlDbType.Decimal).Value = product.ID;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 DeleteProduct(Product product)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "Delete from products where id=@Id ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = product.BookName;
                cmand.Parameters.Add("@Description", MySqlDbType.VarChar).Value = product.Description;
                cmand.Parameters.Add("@Price", MySqlDbType.Decimal).Value = product.price;
                cmand.Parameters.Add("@Id", MySqlDbType.Decimal).Value = product.ID;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }
        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "select id,bookname,description,price from products";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader reader = cmand.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product { ID = int.Parse(reader["id"].ToString()), BookName = reader["bookname"].ToString(), Description = reader["description"].ToString(), price = decimal.Parse(reader["price"].ToString()) });
                }

                return products;
            }
        }

    }
}