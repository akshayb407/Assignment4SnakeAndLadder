using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake And Ladder Program!");
            int player = 1;
            int position = 0;            
            Console.WriteLine($"Snake And Ladder Played With  Player :" + player+ ";   " +"Starting Position Of the Player is:" + position);  ; ;
           
            Random random = new Random();
            int number = random.Next(0, 7);
            Console.WriteLine("Die Rolled By the Player And The Number is:"+number);
        }
    }
}
