using System;

namespace CodeChallenge.ItemTwo.Suggestion
{
    public class MessageC : IBaseMessage
    {
        public void DoSomething()
        {
            MyCustomMethodOnC();
        }

        private static void MyCustomMethodOnC()
        {
            Console.WriteLine("Executed MyCustomMethodOnC");
        }
    }
}