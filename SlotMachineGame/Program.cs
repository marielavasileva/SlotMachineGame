using System;

namespace SlotMachineGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculation = new SpinTotalBalance();
            var userInput = new PlayerInput();
            Console.WriteLine("Welcome to the Slot Machine Game!");
            Console.WriteLine();

            var depositAmount = userInput.EnterDepositAmount();
            while (true)
            {
                var stakeAmount = userInput.EnterStakeAmount(depositAmount);

                Console.WriteLine();

                var totalPlayerBalance = calculation.CalculateTotalPlayerBalance(depositAmount, stakeAmount);

                if (totalPlayerBalance <= 0)
                {
                    Console.WriteLine("You are out of cash. Game over.");
                    break;
                }

                depositAmount = totalPlayerBalance;

                Console.WriteLine("Play Slots? y/n");

                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
        }
    }
}