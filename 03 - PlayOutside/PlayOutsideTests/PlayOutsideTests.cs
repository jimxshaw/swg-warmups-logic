using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PlayOutside;

namespace PlayOutsideTests
{
    [TestFixture]
    public class PlayOutsideTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(95, false, false)]
        [TestCase(70, false, true)]
        [TestCase(95, true, true)]
        public void PlayOutside_Bool_ReturnBool(int temp, bool isSummer, bool expectedResult)
        {
            bool result = _class1.PlayOutside(temp, isSummer);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
