using System;
using System.IO;

namespace CSharpLambdaFunction
{
    public class LambdaHandler
    {
        public static void Main()
        {
            //we will use this for debugging later
        }

        public Stream LogHandler(Stream inputStream)
        {
            Console.WriteLine("Test");
            //this is where lambda funcdotnet restoretion logic will go later.
            //throw new NotImplementedException();
            return inputStream;
        }
    }
}