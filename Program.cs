using System;

namespace variablesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string store = "Target";
            int pairsBought;
            char amp = '&';
            bool doAgain;
            double moneyLeft = 11.23;
            decimal owedDamages = 974.3M;

            pairsBought = 12;
            doAgain = true;

            Console.WriteLine("I just went to " + store + "," + " I got " + pairsBought + " pairs of shoes! I just got paid but there's only $" + moneyLeft + " left in my account " + amp + " I paid $" + owedDamages + " ! Would I go again? " + doAgain);
        }
    }
}
