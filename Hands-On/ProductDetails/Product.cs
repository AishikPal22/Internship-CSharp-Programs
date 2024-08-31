using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    public class Product
    {
        private string _productName;
        private string _serialNumber;
        private DateTime _purchaseDate;
        private double _purchaseCost;

        public Product(string _productName, string _serialNumber, DateTime _purchaseDate, double _purchaseCost)
        {
            this._productName = _productName;
            this._serialNumber = _serialNumber;
            this._purchaseDate = _purchaseDate;
            this._purchaseCost = _purchaseCost;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", this._productName, this._serialNumber, String.Format("{0:d}", this._purchaseDate), this._purchaseCost);
        }
    }
}
