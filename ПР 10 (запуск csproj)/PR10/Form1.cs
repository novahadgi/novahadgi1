﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr10
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        int RectangleX = 0, RectangleY = 0,
                   CircleX = 0, CircleY = 0,
                   SquareX = 0, SquareY = 0,
                   X, Y, dX, dY,
                   LastClicked = 0;


        bool RectangleClicked = false;
        bool CircleClicked = false;
        bool SquareClicked = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CircleClicked)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }

            if (RectangleClicked)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }

            if (SquareClicked)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }
            pictureBox1.Invalidate();

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }

            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Красный круг";
                }
            }

            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Жёлтый прямоугольник";
                }
            }

            if (LastClicked == 2)
            {
                if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
                {
                    if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }

            if (LastClicked == 3)
            {
                if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
                {
                    if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
        }

  

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (RectangleClicked) LastClicked = 1;
            else if (CircleClicked) LastClicked = 2;
            else LastClicked = 3;
            RectangleClicked = false;
            CircleClicked = false;
            SquareClicked = false;
        }
       
     

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    RectangleClicked = true;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    CircleClicked = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    SquareClicked = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (LastClicked == 1)
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
            }
            else if (LastClicked == 2)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
            }
            else
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
            }
        }
    }
}
