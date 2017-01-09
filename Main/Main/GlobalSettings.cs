using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class GlobalSettings
    {
        public static bool Player2
        {
            get; set;
        }
        public static bool Mutation
        {
            get; set;
        }

        public GlobalSettings()
        {
            Player2 = false;
            Mutation = false;
        }
    }
}
