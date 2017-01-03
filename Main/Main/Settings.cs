using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
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
        public static Direction Direction
        {
            get; set;
        }
        public static int Height
        {
            get; set;
        }
        public static int Width
        {
            get; set;
        }
        public static int Speed
        {
            get; set;
        }
        public static bool GameStoped
        {
            get; set;
        }
        public static int Score
        {
            get; set;
        }

        public Settings()
        {
            Direction = Direction.Down;
            Height = 15;
            Width = 15;
            Speed = 15;
            Score = 0;
            GameStoped = false;
        }

    }
}