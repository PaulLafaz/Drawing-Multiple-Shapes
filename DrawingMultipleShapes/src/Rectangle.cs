using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(): this (Color.Green, 0, 0, 100, 100)
        {

        }

        public Rectangle(Color myColor, float x, float y, int width, int height): base(myColor)
        {
            AccessX = x;
            AccessY = y;
            _width = width;
            _height = height;            
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public override void Draw()
        {
            SwinGame.FillRectangle(Color, AccessX, AccessY, _width, _height);
            if ( Selected)
            {
                DrawOutline();

            }
        }

        public override void DrawOutline()
        {
            SwinGame.DrawRectangle(Color.Black, AccessX - 2, AccessY - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            if (SwinGame.PointInRect(pt, AccessX, AccessY, _width, _height) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
