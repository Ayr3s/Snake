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
        private List<Square> Snake2 = new List<Square>();
        private List<Square> Cancer = new List<Square>();
        private List<Square> Cancer2 = new List<Square>();
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
            Snake2.Clear();
            Cancer.Clear();

            Square head = new Square { X = 500 / Settings.Width, Y = 263 / Settings.Height };
            Snake.Add(head);

            if (Settings.Player2)
            {
                Square head2 = new Square { X = 460 / Settings.Width, Y = 263 / Settings.Height };
                Snake2.Add(head2);
            }

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

                if (Input.KeyPressed(Keys.D) && Settings.Direction2 != Direction.Left)
                {
                    Settings.Direction2 = Direction.Right;
                    Settings.Offsety2 = -1;
                    Settings.Offsetx2 = 0;
                }
                else if (Input.KeyPressed(Keys.A) && Settings.Direction2 != Direction.Right)
                {
                    Settings.Direction2 = Direction.Left;
                    Settings.Offsety2 = 1;
                    Settings.Offsetx2 = 0;
                }
                else if (Input.KeyPressed(Keys.W) && Settings.Direction2 != Direction.Down)
                {
                    Settings.Direction2 = Direction.Up;
                    Settings.Offsetx2 = -1;
                    Settings.Offsety2 = 0;
                }
                else if (Input.KeyPressed(Keys.S) && Settings.Direction2 != Direction.Up)
                {
                    Settings.Direction2 = Direction.Down;
                    Settings.Offsetx2 = -1;
                    Settings.Offsety2 = 0;
                }

                if (Snake.Count == 10 && Settings.Cancer == false)
                {
                    Square bihead = new Square { X = Snake[0].X + Settings.Offsetx, Y = Snake[0].Y + Settings.Offsety };
                    Cancer.Add(bihead);

                    Settings.Cancer = true;
                }

                if (Snake2.Count == 10 && Settings.Cancer2 == false)
                {
                    Square bihead2 = new Square { X = Snake2[0].X + Settings.Offsetx, Y = Snake2[0].Y + Settings.Offsety };
                    Cancer.Add(bihead2);

                    Settings.Cancer2 = true;
                }

                MovePlayer();

                Settings.Score = Settings.Score + Snake.Count*0.1;
            }

            pb_Game.Invalidate();

            label1.Text = Settings.Player2.ToString();
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

                    if (Settings.Cancer)
                    {
                        Cancer[0].X = Snake[Settings.Pos].X + Settings.Offsetx;
                        Cancer[0].Y = Snake[Settings.Pos].Y + Settings.Offsety;
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

                    //snake collision
                    for (int b = 0; b < Snake2.Count; b++)
                    {
                        if (Snake[i].X == Snake2[b].X && Snake[i].Y == Snake2[b].Y)
                        {
                            Stop();
                        }
                    }

                    if (Settings.Cancer)
                    {
                        for (int o = 0; o < Cancer.Count; o++)
                        {
                            if (Snake[i].X == Cancer[o].X && Snake[i].Y == Cancer[o].Y)
                            {
                                Stop();
                            }
                        }
                        if (Cancer[0].X == food.X && Cancer[0].Y == food.Y)
                        {
                            Eat();
                        }
                        if (Cancer[0].X < 0 || Cancer[0].Y < 0 || Cancer[0].X >= maxX || Cancer[0].Y >= maxY)
                        {
                            Stop();
                        }
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Cancer[0].X == Snake[j].X && Cancer[0].Y == Snake[j].Y)
                            {
                                Stop();
                            }
                        }
                    }

                    

                    //Food Collision
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
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
            }

            if(Settings.Player2)
            {
                for (int j = Snake2.Count - 1; j >= 0; j--)
                {
                    //Move head
                    if (j == 0)
                    {
                        switch (Settings.Direction2)
                        {
                            case Direction.Right:
                                Snake2[j].X++;
                                break;
                            case Direction.Left:
                                Snake2[j].X--;
                                break;
                            case Direction.Up:
                                Snake2[j].Y--;
                                break;
                            case Direction.Down:
                                Snake2[j].Y++;
                                break;
                        }

                        if (Settings.Cancer2)
                        {
                            Cancer2[0].X = Snake2[Settings.Pos].X + Settings.Offsetx;
                            Cancer2[0].Y = Snake2[Settings.Pos].Y + Settings.Offsety;
                        }


                        //Border Collision
                        if (Snake2[j].X < 0 || Snake2[j].Y < 0 || Snake2[j].X >= maxX || Snake2[j].Y >= maxY)
                        {
                            Stop();
                        }


                        //Body Collision
                        for (int o = 1; o < Snake2.Count; o++)
                        {
                            if (Snake2[j].X == Snake2[o].X && Snake2[j].Y == Snake2[o].Y)
                            {
                                Stop();
                            }
                        }

                        //snake collision
                        for (int b = 0; b < Snake.Count; b++)
                        {
                            if (Snake2[j].X == Snake[b].X && Snake2[j].Y == Snake[b].Y)
                            {
                                Stop();
                            }
                        }

                        if (Settings.Cancer2)
                        {
                            for (int k = 0; k < Cancer2.Count; k++)
                            {
                                if (Snake[j].X == Cancer2[0].X && Snake[j].Y == Cancer2[0].Y)
                                {
                                    Stop();
                                }
                            }
                            if (Cancer2[0].X == food.X && Cancer2[0].Y == food.Y)
                            {
                                Eat2();
                            }
                            if (Cancer2[0].X < 0 || Cancer2[0].Y < 0 || Cancer2[0].X >= maxX || Cancer2[0].Y >= maxY)
                            {
                                Stop();
                            }
                            for (int a = 1; a < Snake2.Count; j++)
                            {
                                if (Cancer2[0].X == Snake2[a].X && Cancer2[0].Y == Snake[a].Y)
                                {
                                    Stop();
                                }
                            }
                        }



                        //Food Collision
                        if (Snake2[0].X == food.X && Snake2[0].Y == food.Y)
                        {
                            Eat2();
                        }
                    }
                    else
                    {
                        //Move body
                        Snake2[j].X = Snake2[j - 1].X;
                        Snake2[j].Y = Snake2[j - 1].Y;
                    }
                }
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

        private void Eat2()
        {
            Square sq2 = new Square { X = Snake2[Snake.Count - 1].X, Y = Snake2[Snake.Count - 1].Y };

            Snake2.Add(sq2);

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

                for (int o = 0; o < Snake2.Count; o++)
                {
                    Brush snakeColour2;
                    if (o == 0)
                        snakeColour2 = Brushes.Black;
                    else
                        snakeColour2 = Brushes.Green;

                    //Draw snake
                    canvas.FillRectangle(snakeColour2, new Rectangle(Snake2[o].X * Settings.Width, Snake2[o].Y * Settings.Height, Settings.Width, Settings.Height));
                }

                for (int k = 0; k < Cancer2.Count; k++)
                {
                    Brush cancerColour2;
                    if (Settings.Pos2 == 0)
                        cancerColour2 = Brushes.BlueViolet;
                    else
                        cancerColour2 = Brushes.Green;
                    //Draw Cancerpart
                    canvas.FillRectangle(cancerColour2, new Rectangle(Cancer2[k].X * Settings.Width, Cancer2[k].Y * Settings.Height, Settings.Width, Settings.Height));
                }

                lb_Score.Text = Settings.Score.ToString();
            }
            else
            {
                string end = "Game Over";
                lb_Info.Text = end;
            }
        }

        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scoreboard score = new Scoreboard();
            score.Show();
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            Settings.Player2 =! Settings.Player2;
        }
    }
}
