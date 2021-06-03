/**
 * @File Book.cs
 * @Date June, 2021
 * @Author Bülent Buğrahan DALLI (bugrahandalli@gmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OopII_Project {
    /**
    * \brief Book class inherited by Product class
    *
    */
    class Book : Product {
        private string author; /*!< Def Author */
        private string publisher; /*!< Def Publisher */
        private int page; /*!< Def Page */

        /**
        * \brief Getter and Setter medhod of author 
        * \param author
        * \return author
        */
        public string Author {
            get {
                return author;
            }

            set {
                author = value;
            }
        }

        /**
        * \brief Getter and Setter medhod of publisher 
        * \param publisher
        * \return publisher
        */
        public string Publisher {
            get {
                return publisher;
            }

            set {
                publisher = value;
            }
        }

        /**
        * \brief Getter and Setter medhod of page 
        * \param page
        * \return page
        */
        public int Page {
            get {
                return page;
            }

            set {
                page = value;
            }
        }

        /**
        * \brief Constructor method of Book
        * \param ID, name, price, author, publisher, page
        *  this method starts the process of assigning new data.
        */
        public Book(int ID = 0, string name = "non", double price = 0, string _author = "n/a", string _publisher = "n/a", int _page = 0) : base(ID, name, price) {
            author = _author;
            publisher = _publisher;
            page = _page;
        }

        /**
        * \brief overrided method of printProperties
        * \return string values
    */
        public override string PrintProperties() {
            string[] basePrint = base.PrintProperties().Split(';');
            return (basePrint[0] + Environment.NewLine + "---------------" + Environment.NewLine + author + Environment.NewLine + Environment.NewLine + publisher + Environment.NewLine + Environment.NewLine + basePrint[1] + " TL");
        }

    }
}
