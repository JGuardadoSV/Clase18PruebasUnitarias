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
            int uno = 1, dos = 2, respuesta = 3;
            int resp = op.suma(uno, dos);
            Assert.AreEqual(respuesta, resp);

        }
    }
}
