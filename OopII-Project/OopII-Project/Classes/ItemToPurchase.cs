using System;
using System.Collections.Generic;
using System.Text;

namespace OopII_Project.Classes
{
    class ItemToPurchase
    {
        private Product product;
        private int quantity;
        
        public ItemToPurchase(Product _product,int _qunatity = 0)
        {
            product = _product;
            quantity = _qunatity;
        }

        public int Quantity
        {
            get { return quantity; }
            set{if (value >0){quantity = value;}}
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }



    }
}
