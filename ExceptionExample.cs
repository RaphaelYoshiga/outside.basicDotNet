using System;
using System.Data.Common;

namespace Outside.BasicDotNet
{
    public class ExceptionExample
    {
        public void Execute()
        {
            try
            {
                FakeSqlDependency.Save("key", "value");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

    public class FakeSqlDependency
    {
        public static void Save(string key, string value)
        {
            throw new FakeDbException();
        }
    }

    public class FakeDbException : DbException
    {

    }
}
