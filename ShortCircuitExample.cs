using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outside.BasicDotNet
{
    public class ShortCircuitExample
    {
        public void Execute()
        {
            bool alwaysTrue = "test".Contains("test");
            if (alwaysTrue || ThrowException())
            {
                Console.WriteLine("Why no exception?");
            }

            bool alwaysFalse = !alwaysTrue;
            if (alwaysFalse && ThrowException())
            {
                
            }
            else
            {
                Console.WriteLine("Why no exception again?");
            }
        }

        private bool ThrowException()
        {
            throw new NotImplementedException();
        }
    }
}
