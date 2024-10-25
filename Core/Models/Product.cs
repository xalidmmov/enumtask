using Core.Helper.Enum;
using Core.Helper.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {

        private static int _No = 0;
        public int No { get; set; }
        public string Name { get; set; }
        private double _price;
        public double Price
        {
            get { return _price; }
             set
            {
                if (value < 0)
                    throw new PriceMustBeGratherThanZeroException("Daxil etdiyiniz qiymet 0 dan boyuk olmalidir");
                _price = value;
            }
        }
        public ProductType Type { get; set; }
        public Product(string name, double price, ProductType type)
        {
           
            _No++;
            No = _No;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
