using System;

namespace CodeChallenge.ItemTwo.Suggestion
{
    public class MessageB : IBaseMessage
    {
        public void DoSomething()
        {
            MyCustomMethodOnB();
            SomeAdditionalMethodOnB();
        }

        private static void MyCustomMethodOnB()
        {
            Console.WriteLine("Executed MyCustomMethodOnB");
        }

        private static void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("Executed SomeAdditionalMethodOnB");
        }
    }
}