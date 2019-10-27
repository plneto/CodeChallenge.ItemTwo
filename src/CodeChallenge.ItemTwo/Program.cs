using System;
using CodeChallenge.ItemTwo.CodeProvided;
using CodeChallenge.ItemTwo.Suggestion;

namespace CodeChallenge.ItemTwo
{
    internal class Program
    {
        private static void Main()
        {
            var original = new OriginalSolution();
            var suggestion = new SuggestedSolution();

            original.Run();

            Console.WriteLine();

            suggestion.Run();
        }
    }
}