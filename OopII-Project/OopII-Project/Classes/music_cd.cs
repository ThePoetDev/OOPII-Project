/**
 * @File music_cd.cs
 * @Date June, 2021
 * @Author Omer SENTURK (omersenturk95@gmail.com)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopII_Project
{
    /**
    * \brief Class for MusicCD types product inherited by Product
    *
    */
    class MusicCD : Product
    {

        private string _singer; /*!< Def of singer */
        private string _type; /*!< Def of type */

        /**
        * \brief Constructor function of the MusicCD class
        * \param ID, name, price, singer, type
        *  this function assigns to parameters to new instance 
        */
        public MusicCD(int ID = 0, string name = "noname", double price = 0, string singer = "N/A", string type = "N/A") : base(ID, name, price)
        {
            _singer = singer;
            _type = type;
        }

        /**
        * \brief Getter and Setter medhod for singer 
        * \param singer
        * \return singer
        */
        public string Singer
        {
            get
            {
                return _singer;
            }

            set
            {
                _singer = value;
            }
        }

        /**
        * \brief Getter and Setter medhod for type 
        * \param type
        * \return type
        */
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        /**
        * \brief overrided function of printProperties
        * \return string type values
        */
        public override string printProperties()
        {
            string[] basePrint = base.printProperties().Split(';');
            return (basePrint[0] + Environment.NewLine + "---------------" + Environment.NewLine + _singer + Environment.NewLine + Environment.NewLine + _type + Environment.NewLine + Environment.NewLine + basePrint[1].ToString() + " TL");
        }
    }
}
