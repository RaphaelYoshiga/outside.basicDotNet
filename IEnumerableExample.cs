using System;
using System.Collections.Generic;
using System.Linq;

namespace Outside.BasicDotNet
{
    public class IEnumerableExample
    {
        public void Execute()
        {
            var intEnumerable = new IEnumerableProvider().GetInts();
            foreach (var i in intEnumerable.Select(p => p++))
            {
                
            }

            Console.WriteLine("Well why didn't throw the error");
        }

    }

    public class IEnumerableProvider
    {
        public IEnumerable<int> GetInts()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            throw new NotImplementedException();
        }
    }
}
