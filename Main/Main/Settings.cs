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
        public static Direction Direction2
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
        public static double Score
        {
            get; set;
        }
        public static int Offsetx
        {
            get; set;
        }
        public static int Offsety
        {
            get; set;
        }
        public static int Offsetx2
        {
            get; set;
        }
        public static int Offsety2
        {
            get; set;
        }
        public static int Pos
        {
            get; set;
        }
        public static int Pos2
        {
            get; set;
        }
        public static bool Cancer
        {
            get; set;
        }
        public static bool Cancer2
        {
            get; set;
        }

        public Settings()
        {
            Direction = Direction.Down;
            Direction2 = Direction.Down;
            Height = 15;
            Width = 15;
            Speed = 15;
            Score = 0;
            GameStoped = false;
            Offsetx = 1;
            Offsety = 0;
            Offsetx2 = 1;
            Offsety2 = 0;
            Pos = 0;
            Pos2 = 0;
            Cancer = false;
            Cancer2 = false;
        }

    }
}