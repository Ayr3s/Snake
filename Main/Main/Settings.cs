using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    class Settings
    {
        public static Direction Direction { get; set; }


        public Settings()
        {

        }

    }
}