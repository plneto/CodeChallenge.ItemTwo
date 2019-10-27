using System;

namespace CodeChallenge.ItemTwo.Suggestion
{
    public class MessageA : IBaseMessage
    {
        public void DoSomething()
        {
            MyCustomMethodOnA();
        }

        private static void MyCustomMethodOnA()
        {
            Console.WriteLine("Executed MyCustomMethodOnA");
        }
    }
}