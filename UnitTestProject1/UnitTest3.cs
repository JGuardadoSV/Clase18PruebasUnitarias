using Clase18PruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Operaciones op = new Operaciones();
            int respuesta = 3;
            int resp = op.suma(1, 2, 3.0M);
            Assert.AreEqual(respuesta, resp);

        }
    }
}
