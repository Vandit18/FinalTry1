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
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe;Port=3307";
        public Int32 AddProduct(UnlockingPrice up)
        {
            using (MySqlConnection cn = new MySqlConnection(ConneStr))
            {
                String query = "INSERT INTO UnlockingPrice(Model,Rogers,Bell,Telus,Fido,Koodo,Virgin,Wind,Other) Values (@Model,@Rogers,@Bell,@Telus,@Fido,@Koodo,@Virgin,@Wind,@Other) ";
                MySqlCommand cmand = new MySqlCommand(query, cn);
                cmand.Parameters.Add("@Model", MySqlDbType.VarChar).Value = up.modelName ;
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.Rogers;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.Bell;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.Telus;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.Fido;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.Koodo;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.Virgin;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.Wind;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.Other;
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
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.Rogers;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.Bell;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.Telus;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.Fido;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.Koodo;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.Virgin;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.Wind;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.Other;
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
                cmand.Parameters.Add("@Rogers", MySqlDbType.VarChar).Value = up.Rogers;
                cmand.Parameters.Add("@Bell", MySqlDbType.VarChar).Value = up.Bell;
                cmand.Parameters.Add("@Telus", MySqlDbType.VarChar).Value = up.Telus;
                cmand.Parameters.Add("@Fido", MySqlDbType.VarChar).Value = up.Fido;
                cmand.Parameters.Add("@Koodo", MySqlDbType.VarChar).Value = up.Koodo;
                cmand.Parameters.Add("@Virgin", MySqlDbType.VarChar).Value = up.Virgin;
                cmand.Parameters.Add("@Wind", MySqlDbType.VarChar).Value = up.Wind;
                cmand.Parameters.Add("@Other", MySqlDbType.VarChar).Value = up.Other;
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
                    UnlockingPrice.Add(new UnlockingPrice { modelName = reader["Model"].ToString(), Rogers = reader["Rogers"].ToString(), Bell = reader["Bell"].ToString(), Telus = reader["Telus"].ToString(), Fido = reader["Fido"].ToString(), Koodo = reader["Koodo"].ToString(), Virgin = reader["Virgin"].ToString(), Wind = reader["Wind"].ToString(), Other = reader["Other"].ToString() });
                }

                return UnlockingPrice;
            }
        }
    }
}