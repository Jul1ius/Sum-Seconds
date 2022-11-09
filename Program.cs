using System;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine()); 
            int thirdTime = int.Parse(Console.ReadLine());

            //calc
            int tottalTime = firstTime + secondTime + thirdTime;
            int minutes = tottalTime / 60;
            int seconds = tottalTime % 60;
            
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }    
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
