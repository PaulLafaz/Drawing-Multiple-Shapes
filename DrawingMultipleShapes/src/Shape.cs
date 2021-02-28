using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected = false;

        public Shape(Color color)
        {
            _color = color;
        }

        public Shape() : this(Color.Yellow)
        {

        }
        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public float AccessX
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public float AccessY
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public abstract void Draw();

        public abstract bool IsAt(Point2D pt);
        
        public abstract void DrawOutline();
        
            //SwinGame.DrawRectangle(Color.Black, _x - 2, _y -2, _width + 4, _height + 4 );
        


    }
}