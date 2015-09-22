using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CaughtSpeeding;

namespace CaughtSpeedingTests
{
    [TestFixture]
    public class CaughtSpeedingTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding_Bool_ReturnInt(int speed, bool isBirthday, int expectedResult)
        {
            int result = _class1.CaughtSpeeding(speed, isBirthday);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
