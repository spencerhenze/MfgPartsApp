using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Widget_X
    {
        //declare the variables that you will be setting when you call the method. Make them private so that they can't be changed
        private int sku_ID;
        private string date_Mfg;

        //begin sku-ID property
        public int Sku_ID
        {
            get
            {
                return sku_ID;
            }
            set
            {
                sku_ID = value;
            }
        }// end of sku-ID property

        public string DateMFG
        {
            get
            {
                return date_Mfg;
            }
            set
            {
                date_Mfg = value;
            }
        } // end of dateMFG property

    }
}
