﻿using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake And Ladder Program!");
            const int player = 1;
            const int player2 =2 ;
            int position = 0;            
            Console.WriteLine($"Snake And Ladder Played With  Player :" + player+ ", "+player2+ ";   " +"Starting Position Of the Player is:" + position);  ; ;
            int NoOfDieroll = 0;
            Random random = new Random();
            int number = random.Next(0, 7);
            Console.WriteLine("Die Rolled By the Player And The Number is:"+number);
            NoOfDieroll++;
            Console.WriteLine("Number of die rolls " + NoOfDieroll);
            Console.WriteLine(number);

            int option = random.Next(0, 3);

            while (position <= 100)
            {
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position = position + number;
                        if (position > 100)
                        {
                            position = position - number;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position = position - number;
                        break;


                }
                if (position < 0)
                {
                    position = 0;
                }
            }
        }
        
    }
}
