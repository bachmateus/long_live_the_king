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

            CharacterFactory factory = new CharacterFactory();

            AbstractCharacter king = factory.CreateCharacter(CharactersList.KingChar);

            Console.WriteLine("ArrowRight move, ArrowLeft stop, q quit");
            king.pull();
            Console.Write( king.speed);

            StateMoving moving = new StateMoving();
            StateStopped stopped = new StateStopped();
            StateDead dead = new StateDead();

            while (gameRunning)
            {
                input = Console.ReadKey();

                if (king.isDead == false)
                {

                    switch (input.Key)
                    {
                        case ConsoleKey.RightArrow:
                            king.setState(moving);
                            break;
                        case ConsoleKey.LeftArrow:
                            king.setState(stopped);
                            break;
                        case ConsoleKey.DownArrow:
                            king.setState(dead);
                            gameRunning = false;

                            Console.Write("You are Dead!");
                            break;
                        case ConsoleKey.Q:
                            king.setState(stopped);
                            gameRunning = false;
                            
                            Console.Write("You quited!");
                            break;
                    }
                    
                    Console.Write( king.speed);
                } 
            }

            Console.WriteLine("End game");
        }

    }
}
