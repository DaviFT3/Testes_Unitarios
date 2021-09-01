using NUnit.Framework;
using Projeto.Shared;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("rio de janeiro")]
        [TestCase("olinda")]
        [TestCase("curitiba")]
        [TestCase("salvador")]
        [TestCase("fortaleza")]
        public void VerificarCapital(string cidade)
        {
            bool resultado = Helper.VerificarCapitalCE(cidade);
            Assert.IsTrue(resultado);
        }
    }
}