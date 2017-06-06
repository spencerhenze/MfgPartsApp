using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Part_L
    {
        private int batch_ID;
        private string inspector_ID;

        public int BatchID
        {
            get
            {
                return batch_ID;
            }
            set
            {
                batch_ID = value;
            }
        } // end BatchID property

        public string InspectorID
        {
            get
            {
                return inspector_ID;
            }
            set
            {
                inspector_ID = value;
            }
        }
    }
}
