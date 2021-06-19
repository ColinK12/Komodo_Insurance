using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoLibrary3
{
    public class KomodoDevPoco3
    {  
        // Properties
        public string DevName { get; set; }

        public int DevIdNum { get; set; }

        public bool PluralSightYN { get; set; }

        // Empty Constructor 

        public KomodoDevPoco3() { }

        // Overloaded Constructor

        public KomodoDevPoco3(string devName, int devIdNum, bool pluralSightYN)
        {
            DevName = devName;
            DevIdNum = devIdNum;
            PluralSightYN = pluralSightYN;
        }

    }
}

