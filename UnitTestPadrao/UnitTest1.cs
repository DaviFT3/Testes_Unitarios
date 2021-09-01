using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Shared;
using System;

namespace UnitTestPadrao
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("rio de janeiro")]
        [DataRow("olinda")]
        [DataRow("curitiba")]
        [DataRow("fortaleza")]
        public void VerificarPot2(string cidade)
        {
            bool resultado = Helper.VerificarCapitalCE(cidade);
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(15)]
        public void VerificaSePar(int  n)
        {
            int resultado = Helper.VerificaSePar(n);
            Assert.AreEqual(0,resultado);
        }
    }
}
