using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InOrderEqual;

namespace InOrderEqualTests
{
    [TestFixture]
    public class InOrderEqualTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqual_Ints_ReturnBool(int a, int b, int c, bool equalOk, bool expectedResult)
        {
            bool result = _class1.InOrderEqual(a, b, c, equalOk);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
