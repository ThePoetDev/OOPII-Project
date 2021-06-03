/**
 * @File customer.cs
 * @Date June, 2021
 * @Author Omer SENTURK (omersenturk95@gmail.com)
 *
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopII_Project
{

    /**
    * \brief Class for customers who is using this app
    *
    */
    class Customer
    {
        private int customer_ID;
        private string name;
        private string address;
        private string email;
        private string username;
        private string pass;

        /**
        * \brief Getter and Setter methods for Customer class attributes 
        * \param all attributes
        * \return all attributes
        */
        public int CustomerID
        {
            get
            {
                return customer_ID;
            }

            set
            {
                customer_ID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public void print_customer_details()
        {
            
        }
        public void save_customer()
        {
            
        }
        public void print_customer_purchases()
        {
            
        }

    }
}
