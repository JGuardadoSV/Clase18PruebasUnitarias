using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string mensajeEsperado = "Hola Mundo";
        [TestMethod]
        public void TestMethod1()
        {
            
            using (var sw = new StringWriter())
            {
                
                Clase18PruebasUnitarias.Program.Main();

                var resultado = sw.ToString().Trim();

                Assert.AreEqual(mensajeEsperado, resultado);
                
                

            }

        }
    }
}
