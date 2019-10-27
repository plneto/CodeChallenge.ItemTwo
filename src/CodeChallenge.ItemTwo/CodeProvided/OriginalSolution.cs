using System.Collections.Generic;

namespace CodeChallenge.ItemTwo.CodeProvided
{
    public class OriginalSolution
    {
        public void Run()
        {
            var a = new MessageA();
            var b = new MessageB();
            var c = new MessageC();

            var list = new List<BaseMessage> { a, b, c };

            foreach (var message in list)
            {
                if (message is MessageA)
                {
                    var messageA = message as MessageA;
                    messageA?.MyCustomMethodOnA();
                }
                else if (message is MessageB)
                {
                    var messageB = message as MessageB;
                    messageB?.MyCustomMethodOnB();
                    messageB?.SomeAdditionalMethodOnB();
                }
                else if (message is MessageC)
                {
                    var messageC = message as MessageC;
                    messageC?.MyCustomMethodOnC();
                }
            }
        }
    }
}