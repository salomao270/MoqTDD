using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Domain.Test
{
    [TestClass]
    public class ClubOperationTest
    {
        [TestMethod]
        public void ShippingCalculateTest()
        {
            //arrange
            Member _member = new Member()
            {
                MemberID = 1,
                Name = "Salomao",
                Lastname = "Ferreira",
                Age = 28,
                Limit = 5
            };

            //act
            var _mock = new Mock<IMember>();
            var _target = new Club(_mock.Object);
            _mock.Setup(m => m.GetMember(It.IsAny<int>())).Returns(_member);

            int memberID = 1;
            double expected = 14;
            double actual = _target.ShippingCalculate(memberID);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
