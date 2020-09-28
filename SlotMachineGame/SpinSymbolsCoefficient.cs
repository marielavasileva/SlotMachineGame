using System;
using System.Collections.Generic;
using System.Linq;

namespace SlotMachineGame
{
    public class SpinSymbolsCoefficient
    {
        public const string Apple = "A";
        public const string Banana = "B";
        public const string Pineapple = "P";
        public const string Wildcard = "*";
        public double CurrentCoefficient;

        public double CalculateCurrentCoefficient()
        {
            var randomNumberGenerator = new Random();

            var positionsList = new List<string>();
            positionsList.AddRange(new List<string>
            {
                DefinePositionSymbolLetter(randomNumberGenerator.Next(1, 100)),
                DefinePositionSymbolLetter(randomNumberGenerator.Next(1, 100)),
                DefinePositionSymbolLetter(randomNumberGenerator.Next(1, 100))
            });

            //print table with the results of the game for each row
            SlotGameVisualizer.PrintPositions(positionsList);

            double currentCoefficient = 0;

            if (positionsList[0] == positionsList[1] && positionsList[1] == positionsList[2])
            {
                switch (positionsList[0])
                {
                    case (Apple):
                        currentCoefficient = 0.4 * 3;
                        break;
                    case (Banana):
                        currentCoefficient = 0.6 * 3;
                        break;
                    case (Pineapple):
                        currentCoefficient = 0.8 * 3;
                        break;
                }
                CurrentCoefficient = currentCoefficient;
            }

            if (positionsList.GroupBy(n => n).Any(n => n.Count() == 2) &&
                positionsList.Contains(Wildcard))
            {
                CurrentCoefficient = CalculateWildCardTotalCoefficient(positionsList[0]);
                CurrentCoefficient = CalculateWildCardTotalCoefficient(positionsList[1]);
                CurrentCoefficient = CalculateWildCardTotalCoefficient(positionsList[2]);
            }

            return currentCoefficient;
        }

        private double CalculateWildCardTotalCoefficient(string positionSymbol)
        {
            var currentCoefficient = (positionSymbol == Apple) ? 0.4 :
                positionSymbol == Banana ? 0.6 :
                positionSymbol == Pineapple ? 0.8 : 0.0;

            CurrentCoefficient = +currentCoefficient;
            return CurrentCoefficient;
        }

        private string DefinePositionSymbolLetter(int number)
        {
            string position = null;
            if (IsBetween(number, 1, 5))
            {
                position = Wildcard;
            }

            if (IsBetween(number, 6, 20))
            {
                position = Pineapple;
            }

            if (IsBetween(number, 21, 55))
            {
                position = Banana;
            }

            if (IsBetween(number, 56, 100))
            {
                position = Apple;
            }

            return position;
        }

        private bool IsBetween(int num, int lower, int upper)
        {
            return lower <= num && num <= upper;
        }
    }
}
