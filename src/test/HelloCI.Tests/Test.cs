using NUnit.Framework;

namespace HelloCI.Tests
{
    
    public class Test : AssertionHelper
    {
        [Test]
        public void Test1()
        { 
            Expect(true); 
        }   
    }
}