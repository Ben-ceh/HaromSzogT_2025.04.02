using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HaromSzogekkree;

namespace HaromSzogTest
{
    [TestClass]
    public class HaromSzogTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ell = new HaromSzogekre();
            int a = 5;
            int b = 5;
            int c = 5;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("szabályos háromszög", eredmeny);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ell = new HaromSzogekre();
            int a = 3;
            int b = 5;
            int c = 5;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("egyenlő szárú háromszög", eredmeny);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ell = new HaromSzogekre();
            int a = 2;
            int b = 3;
            int c = 4;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("általános háromszög", eredmeny);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var ell = new HaromSzogekre();
            int a = 2;
            int b = 3;
            int c = 10;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("nem háromszög, ha nem felel meg a hárömszög-egyenlőség tételének", eredmeny);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var ell = new HaromSzogekre();
            int a = 0;
            int b = 2;
            int c = 5;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("nem háromszög, mert az egyik oldal nulla", eredmeny);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var ell = new HaromSzogekre();
            int a = 2;
            int b = -5;
            int c = 1;

            string eredmeny = ell.HaromSzogek(a, b, c);

            Assert.AreEqual("nem háromszög, mert az egyik oldal negatív", eredmeny);
        }
    }
}
