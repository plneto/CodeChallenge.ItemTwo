using System.Collections.Generic;

namespace CodeChallenge.ItemTwo.Suggestion
{
    public class SuggestedSolution
    {
        public void Run()
        {
            var a = new MessageA();
            var b = new MessageB();
            var c = new MessageC();

            var list = new List<IBaseMessage> { a, b, c };

            list.ForEach(x => x.DoSomething());
        }
    }
}