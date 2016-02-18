using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitTest
{
    public class Access
    {
        public int ID;

        public int GetID()
        {
            ID = 9;

            ID++;
            ID = ID + 2;

            return ID;
        }
    }
}
