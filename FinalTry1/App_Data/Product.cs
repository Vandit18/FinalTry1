using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTry1
{
    public class Product
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
    }
    public class UnlockingPrice
    {
        public string modelName { get; set; }
        public string Rogers { get; set; }
        public string Bell { get; set; }
        public string Telus { get; set; }
        public string Fido { get; set; }
        public string Koodo { get; set; }
        public string Virgin { get; set; }
        public string Wind { get; set; }
        public string Other { get; set; }
    }
    public class OtterBoxSales
    {
            public int ID { get; set; }
        public string OtterBoxModel{get;set;}
        public string Type { get; set; }
        public string Color { get; set; }
        public int InStock { get; set; }
        public int Sold { get; set; }
        public int ModelStock { get; set; }

    }
}