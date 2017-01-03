using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        Random rnd = new Random();

        private List<Square> Snake = new List<Square>();
        private List<Square> Cancer = new List<Square>();
        private Square food = new Square();

        public Main()
        {
            InitializeComponent();

            new Settings();

            gameTime.Interval = 1000 / Settings.Speed;
            gameTime.Tick += UpdateScreen;
            gameTime.Start();

            StartGame();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void StartGame()
        {
            new Settings();

            Snake.Clear();

            Square head = new Square { X = 480 / Settings.Width, Y = 263 / Settings.Height };
            Snake.Add(head);

            Square bihead = new Square { X = Snake[0].X + Settings.Offsetx, Y = Snake[0].Y + Settings.Offsety };
            Cancer.Add(bihead);

            lb_Info.Text = "Running";

            GenerateFood();
        }

        private void GenerateFood()
        {
            int maxX = pb_Game.Size.Width / Settings.Width;
            int maxY = pb_Game.Size.Height / Settings.Height;

            food = new Square { X = rnd.Next(0, maxX - 2) + 1, Y = rnd.Next(0, maxY - 2) + 1 };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameStoped == true)
            {
                if (Input.KeyPressed(Keys.Space))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.Direction != Direction.Left)
                {
                    Settings.Direction = Direction.Right;
                    Settings.Offsety = -1;
                    Settings.Offsetx = 0;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.Direction != Direction.Right)
                {
                    Settings.Direction = Direction.Left;
                    Settings.Offsety = 1;
                    Settings.Offsetx = 0;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.Direction != Direction.Down)
                {
                    Settings.Direction = Direction.Up;
                    Settings.Offsetx = -1;
                    Settings.Offsety = 0;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.Direction != Direction.Up)
                {
                    Settings.Direction = Direction.Down;
                    Settings.Offsetx = -1;
                    Settings.Offsety = 0;
                }

                MovePlayer();

                Settings.Score = Settings.Score + Snake.Count*0.1;
            }

            pb_Game.Invalidate();
        }

        private void MovePlayer()
        {
            int maxX = pb_Game.Size.Width / Settings.Width;
            int maxY = pb_Game.Size.Height / Settings.Height;

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //Border Collision
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxX || Snake[i].Y >= maxY)
                    {
                        Stop();
                    }


                    //Body Collision
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Stop();
                        }
                    }

                    //Cancer Collision
                    /*for (int o = 0; o < Cancer.Count; o++)
                    {
                        if (Snake[i].X == Cancer[o].X && Snake[i].Y == Cancer[o].Y)
                        {
                            Stop();
                        }
                    }
                    */

                    //Food Collision
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y || Cancer[0].X == food.X && Cancer[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
                Cancer[0].X = Snake[Settings.Pos].X + Settings.Offsetx;
                Cancer[0].Y = Snake[Settings.Pos].Y + Settings.Offsety;
            }
        }

        private void Eat()
        {
            Square sq = new Square{ X = Snake[Snake.Count - 1].X , Y = Snake[Snake.Count - 1].Y };

            Snake.Add(sq);

            //Settings.Pos++;

            Settings.Score = Settings.Score + 100;

            GenerateFood();
        }

        private void Stop()
        {
            Settings.GameStoped = true;
        }

        private void pb_game_Draw(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameStoped)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.Green;

                    //Draw snake
                    canvas.FillRectangle(snakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }

                for (int j = 0; j < Cancer.Count; j++)
                {
                    Brush cancerColour;
                    if (Settings.Pos == 0)
                        cancerColour = Brushes.BlueViolet;
                    else
                        cancerColour = Brushes.Green;
                    //Draw Cancerpart
                    canvas.FillRectangle(cancerColour, new Rectangle(Cancer[j].X * Settings.Width, Cancer[j].Y * Settings.Height, Settings.Width, Settings.Height));
                }

                lb_Score.Text = Settings.Score.ToString();
            }
            else
            {
                string end = "Game Over";
                lb_Info.Text = end;
            }
        }
    }
}
