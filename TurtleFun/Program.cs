using System;
using Unit4.TurtleLib;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        private static void Greeting()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t* * * * * * * * * * * * * *\n");
            Console.WriteLine("\t\t\t*      W E L C O M E      *\n");
            Console.WriteLine("\t\t\t*           T O           *\n");
            Console.WriteLine("\t\t\t*       T U R T L E       *\n");
            Console.WriteLine("\t\t\t*          F U N          *\n");
            Console.WriteLine("\t\t\t* * * * * * * * * * * * * *\n");

            Console.WriteLine("\n\n\t press any key to continue !!!");
            Console.ReadKey();
        }

        private static void Goodbye()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n\n\t\t\tGoodbye,\n");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\thave a nice day.\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\n\npress any key to continue...");
            Console.ReadKey();
        }

        private static char PrintMainMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\tMENU");
            Console.WriteLine("\t\t====\n\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tpress the number of the choice that you desire,");
            Console.WriteLine("\t\tthen press ENTER !!!\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t1. pyramid \n");
            Console.WriteLine("\t\t\t2. two symmetric cones \n");
            Console.WriteLine("\t\t\t3. two symmetric spirals (view1)\n");
            Console.WriteLine("\t\t\t4. two symmetric spirals (view2)\n");
            Console.WriteLine("\t\t\t5. cubes inside cubes \n");
            Console.WriteLine("\t\t\t6. cool drawing 1 \n");
            Console.WriteLine("\t\t\t7. cool drawing 2 \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t8. QUIT !!!\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\tChoice: ");
            Console.ForegroundColor = ConsoleColor.White;

            return char.Parse(Console.ReadLine());
        }

        public static void DoIt(char quitChar)
        {
            Greeting();

            char c = PrintMainMenu();

            do
            {
                while (c < '1' || c > quitChar) // input filter
                    c = PrintMainMenu();

                switch (c)
                {
                    case '1': TurtleFunctions.DrawSquares(27); break;

                    case '2': TurtleFunctions.DrawCircles(18); break;

                    case '3': TurtleFunctions.DrawSpiralOI(true, true);
                        TurtleFunctions.DrawSpiralOI(false, false);
                        break;

                    case '4': TurtleFunctions.DrawSpiralIO(true, true);
                        TurtleFunctions.DrawSpiralIO(false, false);
                        break;

                    case '5': TurtleFunctions.Cubes(7);
                        break;

                    case '6': TurtleFunctions.Drawing1();
                        break;

                    case '7': TurtleFunctions.Drawing2();
                        break;

                        // if (c == quitChar) //
                    default: Goodbye(); break;
                }
                if(c!=quitChar) c = PrintMainMenu();

            }
            while (c != quitChar);
        }


        
        static void Main(string[] args)
        {
            DoIt('8');


        }
    }
}
