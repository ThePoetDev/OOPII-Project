/**
 * @File magazine.cs
 * @Date june, 21
 * @Author Servet KIRAC (servetkrac@gmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OopII_Project
{
    class Magazine : Product

    {
        /***********************************
      * @params param issue the issue of magazine
      * @params param type the type of magazine
      * ********************************/
        private int issue;
        private string type;

        /***********************************
        * @brief Constructor of magazine class
        * @param id name price issue type
        * ********************************/
        public Magazine(int id = 0, string name = "NAN", double price = 0,  int _issue = 1, string _type = "other") : base(id, name, price)
        {
            type = _type;
            issue = _issue;
        }

        /***********************************
        * @brief Getter and Setter of issue
        * @param type
        * @return type
        * ********************************/

        public int Issue { 
            get { return issue; }
            set { issue = value; }
        }

        /************************************
        * @brief Getter and Setter of type
        * @param type
        * @return type
        * ********************************/

        private string  Type {
            get { return type; }
            set { type = value; }
        }

    }
}
