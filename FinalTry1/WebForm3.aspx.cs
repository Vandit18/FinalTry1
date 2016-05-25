using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalTry1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        String ConneStr = "Data source=sql.computerstudi.es;Database=gc200299657;User Id=gc200299657;Password=p4^AJCpe";
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(ConneStr);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO OtterBoxSalesHistory(ModelName,ModelType,ModelColor,ModelInStock,ModelSold,ModelCurrentStock) Values (@ModelName,@ModelType,@ModelColor,@ModelInStock,@ModelSold,@ModelCurrentStock)", cn);
            cmd.Parameters.AddWithValue("@ModelName", txtOtterBox.Text);
            cmd.Parameters.AddWithValue("@ModelType", txtType.Text);
            cmd.Parameters.AddWithValue("@ModelColor", txtColor.Text);
            cmd.Parameters.AddWithValue("@ModelInStock", txtInStock.Text);
            cmd.Parameters.AddWithValue("@ModelSold", txtSold.Text);
            cmd.Parameters.AddWithValue("@ModelCurrentStock", txtModelInStock.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            //ShowMessage("Registered successfully......!");
            //clear();
            //BindGridView();
            cn.Close();

        }


    }
}