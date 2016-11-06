using NUnit.Framework;
using System;
using OsipDal.UnitsOfWork;
using OsipDal.EF;
using System.Collections.Generic;

namespace DalTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void ListCoutries()
        {
            CountryUow UoW = new CountryUow();

            List<Country> countries  = UoW.GetAll();

            Assert.IsTrue(countries.Count > 0);
        }
    }
}
