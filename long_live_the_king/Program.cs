using System;
using long_live_the_king.classes.character;

namespace long_live_the_king
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            bool gameRunning = true;

            Character king = new Character();
            Console.WriteLine("ArrowRight move, ArrowLeft stop, q quit");
            king.pull();
            Console.Write( king.speed);

            StateMoving moving = new StateMoving();
            StateStopped stopped = new StateStopped();

            while (gameRunning)
            {
                input = Console.ReadKey();
                
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:
                        king.setState(moving);
                        break;
                    case ConsoleKey.LeftArrow:
                        king.setState(stopped);
                        break;
                    case ConsoleKey.Q:
                        king.setState(stopped);
                        gameRunning = false;
                        break;
                }
                // king.pull();
                Console.Write( king.speed);
            }

            Console.WriteLine("End game");
        }

    }
}
