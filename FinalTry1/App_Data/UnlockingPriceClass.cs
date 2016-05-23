using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalTry1
{
    public class UnlockingPriceClass
    {
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe";
        public Int32 AddProduct(UnlockingPrice up)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "INSERT INTO UnlockingPrice(Model,Rogers,Bell,Telus,Fido,Koodo,Virgin,Wind,Other) Values (@Model,@Rogers,@Bell,@Telus,@Fido,@Koodo,@Virgin,@Wind,@Other) ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Model", MySqlDbType.VarChar).Value = up.modelName ;
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.rogersPrice;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.bellPrice;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.telusPrice;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.fidoPrice;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.koodoPrice;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.virginPrice;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.windPrice;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.otherPrice;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 UpdateProduct(UnlockingPrice up)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "UPDATE UnlockingPrice SET Rogers=@Rogers,Bell=@Bell,Telus=@Telus,Fido=@Fido,Koodo=@Koodo,Virgin=@Virgin,Wind=@Wind,Other=@Other WHERE Model=@Model ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Model", MySqlDbType.VarChar).Value = up.modelName;
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.rogersPrice;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.bellPrice;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.telusPrice;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.fidoPrice;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.koodoPrice;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.virginPrice;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.windPrice;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.otherPrice;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }

        public Int32 DeleteProduct(UnlockingPrice up)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "Delete from UnlockingPrice where Model=@Model ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Model", MySqlDbType.VarChar).Value = up.modelName;
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.rogersPrice;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.bellPrice;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.telusPrice;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.fidoPrice;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.koodoPrice;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.virginPrice;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.windPrice;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.otherPrice;
                cn.Open();
                return cmand.ExecuteNonQuery();

            }
        }
        public List<UnlockingPrice> getProducts()
        {
            List<UnlockingPrice> UnlockingPrice  = new List<UnlockingPrice>();
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "select Model,Rogers,Bell,Telus,Fido,Koodo,Virgin,Wind,Other from UnlockingPrice";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader reader = cmand.ExecuteReader();
                while (reader.Read())
                {
                    UnlockingPrice.Add(new UnlockingPrice { modelName = reader["Model"].ToString(), rogersPrice = reader["Rogers"].ToString(), bellPrice = reader["Bell"].ToString(), telusPrice = reader["Telus"].ToString(), fidoPrice = reader["Fido"].ToString(), koodoPrice = reader["Koodo"].ToString(), virginPrice = reader["Virgin"].ToString(), windPrice = reader["Wind"].ToString(), otherPrice = reader["Other"].ToString() });
                }

                return UnlockingPrice;
            }
        }
    }
}