using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalTry1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe";
        protected void Page_Load(object sender, EventArgs e)
        {
         }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(ConneStr);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO UnlockingPrice(Model,Rogers,Bell,Telus,Fido,Koodo,Virgin,Wind,Other) Values (@Model,@Rogers,@Bell,@Telus,@Fido,@Koodo,@Virgin,@Wind,@Other)", cn);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text);
            cmd.Parameters.AddWithValue("@Rogers", txtRogers.Text);
            cmd.Parameters.AddWithValue("@Bell", txtBell.Text);
            cmd.Parameters.AddWithValue("@Telus", txtTelus.Text);
            cmd.Parameters.AddWithValue("@Fido", txtFido.Text);
            cmd.Parameters.AddWithValue("@Koodo", txtKoodo.Text);
            cmd.Parameters.AddWithValue("@Virgin", txtVirgin.Text);
            cmd.Parameters.AddWithValue("@Wind", txtWind.Text);
            cmd.Parameters.AddWithValue("@Other", txtOther.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //ShowMessage("Registered successfully......!");
            //clear();
            //BindGridView();
            cn.Close();

        }

        
    }
}