using System;
using PoeOil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace PoeOil.Test
{
    [TestClass]
    public class OilCollectionTest
    {
        [TestMethod]
        public void Upconvert_Fail_Test()
        {
            var target = new OilCollection(
                new List<Oil>
                {
                    1,
                });

            Assert.AreEqual(target.TryUpconvertTo(2), false);
        }

        [TestMethod]
        public void Upconvert_Test()
        {
            var target = new OilCollection(
                new List<Oil>
                {
                    1,
                    1,
                    1
                });

            Assert.AreEqual(target.TryUpconvertTo(2), true);

            Assert.AreEqual(target.Oils.Count(), 1);
            var res = target.Oils.First();
            Assert.AreEqual(res, 2);
        }

        [TestMethod]
        public void Upconvert_2_Tiers_Test()
        {
            var target = new OilCollection(
                new List<Oil>
                {
                    1,
                    1,
                    1,
                    1,
                    1,
                    1,
                    1,
                    1,
                    1,
                });

            Assert.AreEqual(target.TryUpconvertTo(3), true);

            Assert.AreEqual(target.Oils.Count(), 1);
            var res = target.Oils.First();
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void Upconvert_4_Tiers_Test()
        {
            var target = new OilCollection(Enumerable.Range(0, (int)Math.Pow(3, 3)).Select(x => (Oil)1).ToList());

            Assert.AreEqual(target.TryUpconvertTo(4), true);

            Assert.AreEqual(target.Oils.Count(), 1);
            var res = target.Oils.First();
            Assert.AreEqual(res, 4);
        }
    }
}
