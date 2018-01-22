using System;

namespace Outside.BasicDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello de*r!");
            //RunExceptionExample();
            //RunShortCircuitExample();
            //RunLinqDangersExample();
            RunIEnumerableExample();
            Console.WriteLine("End..");
            Console.Read();
        }

        private static void RunIEnumerableExample()
        {
            new IEnumerableExample().Execute();
        }

        private static void RunLinqDangersExample()
        {
            new LinqDangersExample().Execute();
        }

        private static void RunShortCircuitExample()
        {
            new ShortCircuitExample().Execute();
        }

        private static void RunExceptionExample()
        {
            try
            {
                new ExceptionExample().Execute();
            }
            catch (Exception e)
            {
                //TODO: LOG
            }
        }
    }
}
