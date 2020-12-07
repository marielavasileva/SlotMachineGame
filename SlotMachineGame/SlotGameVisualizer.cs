using System;
using System.Collections.Generic;

namespace SlotMachineGame
{
    public static class SlotGameVisualizer
    {
        public static void PrintPositions(List<string> positionsList)
        {
            Console.WriteLine("{0} - {1} - {2}", positionsList[0], positionsList[1], positionsList[2]);
        }

        public static void PrintPlayerWinAmount(double totalCoefficient, double stakeAmount)
        {
            Console.WriteLine();
            Console.WriteLine($"You have won: {(totalCoefficient * stakeAmount):F0}");
        }

        public static void CreateSlots()
        {
            Console.WriteLine("Testingggg mergwdding");
            Console.WriteLine("boo");

        }

        public static string CreateSlotsString()
        {
            Console.WriteLine("Test merging");
            Console.WriteLine("testt");
            return "test";

        }

        public static void PrintPlayerTotalBalance(double totalPlayerBalance)
        {
            Console.WriteLine($"Current balance is: {totalPlayerBalance:F0}");
        }       
    }
}
