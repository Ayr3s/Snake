using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    internal class Input
    {
        //Neue Hashtable mit den KeyInputs
        private static Hashtable keyTable = new Hashtable();

        //Kontroll -> gedrückte Taste
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
