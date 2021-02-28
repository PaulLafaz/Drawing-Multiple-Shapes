using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle() : this(Color.Blue, 50)
        {
          
        }

        public Circle(Color myColor, int radius) : base(myColor)
        {
            _radius = radius;
        }

        public int Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }

        public override void Draw()
        {
           
            if (Selected)
            {
                DrawOutline();
            }

            SwinGame.FillCircle(Color, AccessX, AccessY, _radius);
        }

        public override void DrawOutline()
        {
            SwinGame.DrawCircle(Color.Black, AccessX, AccessY, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            if (SwinGame.PointInCircle(pt, AccessX, AccessY, _radius) == true)
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
