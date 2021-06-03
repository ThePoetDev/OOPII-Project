/**
 * @File magazine.cs
 * @Date june, 21
 * @Author Servet KIRAC (servetkrac@gmail.com)
 *
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OopII_Project
{
    class ShoppingCart
    {
        private ArrayList itemsToPurchase = new ArrayList();
        private int customerId;
        private double paymentAmount;

         /***********************************
        * @brief getter setter of itemsToPurchase
        * ********************************/
        public ArrayList ItemsToPurchase{
            get { return itemsToPurchase; }
            set { itemsToPurchase = value; }
        }

        /***********************************
        * @brief getter setter of PaymentAmount
        * ********************************/
        public double PaymentAmount{
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        /***********************************
        * @brief getter setter of itemsToPurchase
        * ********************************/
        public int CustomerId{
            get { return customerId; }
            set { customerId = value; }
        }

        /***********************************
        * @brief add item to itemstopurchase
        * ********************************/
        public bool AddItem()
        {
            // TO DO
           return false; 
        }
        /***********************************
         * @brief remove item to itemstopurchase
        * ********************************/
        public bool RemoveItem()
        {
            // TO DO
            return false;
        }
        /***********************************
         * @brief order items in cart
         * ********************************/
        public string placeOrder()
        {
            // to do
            return "TO DO";
        }
    }
}
