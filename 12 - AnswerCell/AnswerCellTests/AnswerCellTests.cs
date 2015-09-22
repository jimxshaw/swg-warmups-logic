using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AnswerCell;

namespace AnswerCellTests
{
    [TestFixture]
    public class AnswerCellTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell_Bools_ReturnBool(bool isMorning, bool isMom, bool isAsleep, bool expectedResult)
        {
            bool result = _class1.AnswerCell(isMorning, isMom, isAsleep);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
