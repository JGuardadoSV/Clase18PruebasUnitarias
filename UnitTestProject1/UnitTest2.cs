﻿using Clase18PruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int uno = 1, dos = 2, respuesta = 3;

            int resp=Clase18PruebasUnitarias.Program.suma(uno,dos);

            Assert.AreEqual(respuesta, resp);

        }
    }
}
