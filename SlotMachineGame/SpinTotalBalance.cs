namespace SlotMachineGame
{
   public class SpinTotalBalance
   {
       public double TotalCoefficient ;
       public double TotalPlayerBalance ;
       public SpinSymbolsCoefficient SpinSymbolsCoefficient;

        public double CalculateTotalPlayerBalance(double depositAmount, double stakeAmount)
        {
            SpinSymbolsCoefficient = new SpinSymbolsCoefficient();
            TotalCoefficient = 0;

            for (int i = 0; i < 4; i++)
            {
                var currentCoefficient = SpinSymbolsCoefficient.CalculateCurrentCoefficient();
                TotalCoefficient += currentCoefficient;
            }

            TotalPlayerBalance = (depositAmount-stakeAmount) + (TotalCoefficient * stakeAmount);

            SlotGameVisualizer.PrintPlayerWinAmount(TotalCoefficient, stakeAmount);
            SlotGameVisualizer.PrintPlayerTotalBalance(TotalPlayerBalance);

            return TotalPlayerBalance;
        }
   }
}
