using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    class Drawing
    {
        private List<Shape> _shapes;
        private Color _background;

        public Drawing() : this (Color.White)
        {
            
        }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();

                foreach(Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }

                return result;
            }
        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public void Draw()
        {
            SwinGame.ClearScreen(_background);
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
            
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach( Shape s in _shapes)
            {
                if (s.IsAt(SwinGame.MousePosition()))
                {
                    s.Selected = true;
                }
     
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(List<Shape> ls)
        {
            foreach (Shape sh in ls)
            {
                if (sh.Selected == true)
                {
                    _shapes.Remove(sh);
                }
            }
        }
    }
}
