using System;

namespace SlotMachineGame
{
    public class PlayerInput
    {
        public double EnterDepositAmount()
        {
            Console.WriteLine("Please deposit money you would like to play with:");
            double depositAmount = double.TryParse(Console.ReadLine(), out depositAmount) ? depositAmount : 0.0;

            if (depositAmount == 0.0)
            {
                Console.WriteLine("Enter valid deposit money:");
                depositAmount = double.TryParse(Console.ReadLine(), out depositAmount) ? depositAmount : 0.0;
            }

            return depositAmount;
        }

        public double EnterStakeAmount(double depositAmount)
        {
            Console.WriteLine("Enter stake amount: ");
            double stakeAmount = double.TryParse(Console.ReadLine(), out stakeAmount) ? stakeAmount : 0.0;
            if (stakeAmount == 0.0 || stakeAmount > depositAmount)
            {
                Console.WriteLine("Enter valid deposit money:");
                stakeAmount = double.TryParse(Console.ReadLine(), out stakeAmount) ? stakeAmount : 0.0;
            }
            return stakeAmount;
        }
    }
}
