/**
 * @File Product.cs
 * @Date June, 2021
 * @Author Bülent Buğrahan DALLI (bugrahandalli@gmail.com)
 *
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace OopII_Project {
    /**
    * \brief Abstract Class of Product
    *
    */
    public abstract class Product {
        private int _id;  /*!< Def ID */
        private string _name;  /*!< Def Name */
        private double price;  /*!< Def Price */
        private string _image;


        /**
        * \brief Constructor of Product
        * \param id, name, price
        *  this method starts the process of assigning new data.
        */
        public Product(int id = 0, string name = "noname", double price = 0) {
            _id = id;
            _name = name;
            this.price = price;
        }

        /**
        * \brief Getter and setter methods of ID
        * \param ID
        * \return ID
        */
        public int ID {
            get {
                return _id;
            }

            set {
                _id = value;
            }
        }

        /**
        * \brief Getter and setter methods of Name
        * \param name
        * \return name
        */
        public string Name {
            get {
                return _name;
            }

            set {
                _name = value;
            }
        }

        /**
        * \brief Getter and setter methods of Price
        * \param price
        * \return price
        */
        public double Price {
            get {
                return price;
            }

            set {
                price = value;
            }
        }

        /**
        * \brief Getter and setter methods of Image
        * \param image
        * \return image
        */
        public string Image {
            get {
                return _image;
            }

            set {
                _image = value;
            }
        }

        /**
        * \brief virtual method of printProperties
        * method will be overridden by inherited classes
        * \return string value
        */
        public virtual string printProperties() {
            return ("Id: " + _id + "- Name : " + _name + " - Price: " + price.ToString("0.00"));
        }
    }
}