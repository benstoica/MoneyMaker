using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("One Gold Coin = 10, One Silver Coin = 5, One Bronze Coin = 1");
            Console.Write("Enter an amount to convert to coins:");
            string amount = Console.ReadLine();
            double amountAsDouble = Convert.ToDouble(amount);

            Console.WriteLine($"{amount} is equal to...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(amountAsDouble / 10);
            double leftOver = amountAsDouble % 10;

            double silverCoins = Math.Floor(leftOver / silverValue);
            leftOver = leftOver % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins} Silver coins: {silverCoins} Bronze coins: {leftOver}");
        }
    }
}
