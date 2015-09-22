using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GreatParty;

namespace GreatPartyTests
{
    [TestFixture]
    public class GreatPartyTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatParty_Bool_ReturnBool(int cigars, bool isWeekend, bool expectedResult)
        {
            bool result = _class1.GreatParty(cigars, isWeekend);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
