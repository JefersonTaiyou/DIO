using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeiroProjeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Tests
{
    [TestClass()]
    public class CalculadoraBasicaTests
    {
        [TestMethod()]
        public void SomarTest()
        {
            var a = 10;
            var b = 20;
            var esperado = 30;
            var calcular = new CalculadoraBasica();

            var resultado = calcular.Somar(a, b);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod()]
        public void SubtrairTest()
        {
            var a = 10;
            var b = 5;
            var esperado = 5;
            var calcular = new CalculadoraBasica();

            var resultado = calcular.Subtrair(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            var a = 10;
            var b = 20;
            var esperado = 200;
            var calcular = new CalculadoraBasica();

            var resultado = calcular.Multiplicar(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DividirTest()
        {
            var a = 10;
            var b = 5;
            var esperado = 2;
            var calcular = new CalculadoraBasica();

            var resultado = calcular.Dividir(a, b);

            Assert.AreEqual(esperado, resultado);
        }
    }
}