using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            Drawing _painting = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Circle;

            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            SwinGame.ShowSwinGameSplashScreen();            
            
            while(false == SwinGame.WindowCloseRequested())
            {
                SwinGame.ProcessEvents();

                SwinGame.ClearScreen(Color.White);
                SwinGame.DrawFramerate(0, 0);


                if (SwinGame.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                   // _painting.AddShape(new Circle());
                } 

                if (SwinGame.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SwinGame.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SwinGame.MouseClicked(MouseButton.LeftButton))
               {
                    

                    if (kindToAdd == ShapeKind.Circle)
                    {
                        Shape _circ = new Circle();
                        _circ.AccessX = SwinGame.MouseX();
                        _circ.AccessY = SwinGame.MouseY();
                        _painting.AddShape(_circ);
                    }
                    else if(kindToAdd == ShapeKind.Rectangle)
                    {
                        Shape _rect = new Rectangle();
                        _rect.AccessX = SwinGame.MouseX();
                        _rect.AccessY = SwinGame.MouseY();
                        _painting.AddShape(_rect);
                    }
                    else
                    {                       
                        Line _line = new Line();
                        _line.AccessX = SwinGame.MouseX();
                        _line.AccessY = SwinGame.MouseY();
                        _line.SecX = SwinGame.MouseX() + 50;
                        _line.SecY = SwinGame.MouseY();
                        _painting.AddShape(_line);


                    }

                   
                    
               
                }

                _painting.Draw();

                if (SwinGame.KeyTyped(KeyCode.SpaceKey))
                {
                    _painting.Background = SwinGame.RandomRGBColor(255);
                }

                if (SwinGame.MouseClicked(MouseButton.RightButton))
                {

                    _painting.SelectShapesAt(SwinGame.MousePosition());
                }

                if (SwinGame.KeyTyped(KeyCode.BackspaceKey) || (SwinGame.KeyTyped(KeyCode.DeleteKey)))
                {
                    _painting.RemoveShape(_painting.SelectedShapes);
                }

                

                

                SwinGame.RefreshScreen(60);
            }
        }
    }
}