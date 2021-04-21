using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementForm
{
    class Product
    {
        private string _name;
        private int _modelNumber;
        private string _manufacturer;
        private int _quantity;
        // Array Category
        private double _height;
        private double _width;
        private double _weight;
        private double _price;

        public Product()
        {

        }

        public Product(string name, int modelnumber, string manufacturer, int quantity, double height, double width, double weight, double price)
        {
            _name = name;
            _modelNumber = modelnumber;
            _manufacturer = manufacturer;
            _quantity = quantity;
            _height = height;
            _width = width;
            _weight = weight;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
