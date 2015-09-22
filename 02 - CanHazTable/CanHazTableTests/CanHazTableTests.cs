using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CanHazTable;

namespace CanHazTableTests
{
    [TestFixture]
    public class CanHazTableTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTable_Int_ReturnInt(int yourStyle, int dateStyle, int expectedResult)
        {
            int result = _class1.CanHazTable(yourStyle, dateStyle);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
