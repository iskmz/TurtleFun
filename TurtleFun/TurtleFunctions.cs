using System;
using Unit4.TurtleLib;
using System.Text;
namespace ConsoleApplication1
{
    class TurtleFunctions
    {
        public static void DrawN(double n, bool isRight, bool isUp, double stepSize)
        {
            /*
             *  n: number of lines (2adla3)
             *  isRight: Direction of drawing; true->right , false-> left
             *  stepSize: length of each line
             * 
             */

            Turtle t = new Turtle();
            t.SetDelay(30);
            t.TailDown();

            for (int i = 0; i < n; i++)
            {
                if (isUp) t.MoveForward(stepSize);
                else t.MoveBackward(stepSize);

                if (isRight) t.TurnRight(360.0 / n);
                else t.TurnLeft(360.0 / n);
            }

            


        }

        public static void DrawSpiralIO(bool isRight, bool isUp)
        {
            Turtle t = new Turtle();
            t.SetDelay(50);
            t.TailDown();

            for (int i = 11; i <= 180; i++)
            {
                if (isUp)
                {
                    t.MoveForward(10);
                    if (isRight) t.TurnRight(360.0 / i);
                    else t.TurnLeft(360.0 / i);
                }
                else
                {
                    t.MoveBackward(10);
                    if (!isRight) t.TurnRight(360.0 / i);
                    else t.TurnLeft(360.0 / i);
                }
            }
        }

        public static void DrawSpiralOI(bool isRight, bool isUp)
        {
            Turtle t = new Turtle();
            t.SetDelay(50);
            t.TailDown();

            for (int i = 180; i >= 11; i--)
            {
                if (isUp)
                {
                    t.MoveForward(10);
                    if (isRight) t.TurnRight(360.0 / i);
                    else t.TurnLeft(360.0 / i);
                }
                else
                {
                    t.MoveBackward(10);
                    if (!isRight) t.TurnRight(360.0 / i);
                    else t.TurnLeft(360.0 / i);
                }


            }
        }

        public static void DrawSpiralOI(double initialAngle)
        {
            Turtle t = new Turtle();
            t.SetDelay(25);
            t.TailDown();

            t.TurnRight(initialAngle);

            for (int i = 100; i >= 11; i--)
            {
                t.MoveForward(10);
                t.TurnRight(360.0 / i);
            }
        }

        public static void DrawCircles(int m)
        {
            // m: number of circles in each HALF 
            // Total Circles number = 2*m

            if (m <= 0) return;
            DrawN(50, false, true, m);
            DrawN(50, true, true, m);
            DrawCircles(m - 1);
        }

        public static void DrawSquares(double m)
        {
            // 2*m = number of squares in each QUARTER
            // 8*m = total number of squares

            if (m <= 0) return;
            DrawN(4, false, true, m * 10);
            DrawN(4, true, true, m * 10);
            DrawSquares(m - 0.5);
            DrawN(4, false, false, m * 10);
            DrawN(4, true, false, m * 10);
        }
     
        public static void DrawCube(double m)
        {
            Turtle t = new Turtle();
            t.SetDelay(30);
            t.TailDown();
            
            const int a = 90;
            
            t.TurnRight(90);

            // face 1 (back)
            for (int i = 1; i <= 2; i++)
            {
                t.MoveForward(m);
                t.TurnLeft(a);
                t.MoveForward(m);
                t.TurnLeft(180-a);
            }

            // line 1
            t.TurnRight(180 - a + 20);
            t.MoveForward(m * 0.7);
            t.TurnLeft(180 - a + 20);

            // face 2 (front)
            for (int i = 1; i <= 2; i++)
            {
                t.MoveForward(m);
                t.TurnLeft(a);
                t.MoveForward(m);
                t.TurnLeft(180-a);
            }

            t.MoveForward(m);
            // line 2
            t.TurnLeft(a - 20);
            t.MoveForward(m * 0.7);

            t.TurnLeft(20);
            t.MoveForward(m);
            t.TurnRight(20);

            // face 3 (up)
            for (int i = 1; i <= 2; i++)
            {
                
                t.MoveBackward(m*0.7);
                t.TurnRight(a-20);
                t.MoveBackward(m);
                t.TurnRight(180-(a-20));
            }

        }

        public static void Drawing1()
        {
            Turtle t = new Turtle();
            t.TailDown();
            t.SetDelay(30);
            t.SetVisible(false);

            for (int j = 1; j <= 19; j++)
            {
                for (int i = 1; i <= 2; i++)
                {
                    t.MoveForward(17*7);
                    t.TurnLeft(70);
                    t.MoveForward(17*7);
                    t.TurnLeft(110);
                }
                t.TurnRight(20);
                t.MoveForward(8);
            }
        }

        public static void Drawing2()
        {
            for (int i = 1; i <= 6; i++)
                TurtleFunctions.DrawSpiralOI(60 * i);
        }

        public static void Cubes(int n)
        {
            // n: number of cubes
           
            if (n <= 0) return;
            DrawCube(n*30);
            Cubes(n - 1);
        }


    }
}
