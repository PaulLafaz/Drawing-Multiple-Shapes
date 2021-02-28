using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    public class Line : Shape
    {
        private float _secX, _secY; 

        public Line() : this(Color.Red) 
        {

        } 

        public Line(Color color) : base(color)
        {
            _secX = AccessX + 50;
            _secY = AccessY;
        }
        
        public float SecX
        {
            get
            {
               return _secX;
            }

            set
            {
              _secX = value;
            }
        }

        public float SecY
        {
            get
            {
                return _secY;
            }

            set
            {
                _secY = value;
            }
        }

        public override void Draw()
        {
            SwinGame.DrawLine(Color, AccessX, AccessY, _secX , _secY);
            if (Selected)
            {
                DrawOutline();

            }
        }

        public override void DrawOutline()
        {
            SwinGame.DrawCircle(Color.Black, AccessX, AccessY, 5);
            SwinGame.DrawCircle(Color.Black, _secX, _secY, 5);
        }

        public override bool IsAt(Point2D pt)
        {
            if (SwinGame.PointOnLine(pt, AccessX, AccessY, _secX, _secY) == true)
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
