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
        public string rogersPrice { get; set; }
        public string bellPrice { get; set; }
        public string telusPrice { get; set; }
        public string fidoPrice { get; set; }
        public string koodoPrice { get; set; }
        public string virginPrice { get; set; }
        public string windPrice { get; set; }
        public string otherPrice { get; set; }
    }
    public class OtterBoxSales
    {
            public int ID { get; set; }
        public string OtterBoxModel{get;set;}
        public string ModelType { get; set; }
        public string modelColor { get; set; }
        public int ModelInStock { get; set; }
        public int ModelSold { get; set; }
        public int ModelStock { get; set; }

    }
}