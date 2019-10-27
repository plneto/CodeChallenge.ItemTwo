using System;

namespace CodeChallenge.ItemTwo.CodeProvided
{
    public class MessageB : BaseMessage
    {
        public void MyCustomMethodOnB()
        {
            Console.WriteLine("Executed MyCustomMethodOnB");
        }

        public void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("Executed SomeAdditionalMethodOnB");
        }
    }
}