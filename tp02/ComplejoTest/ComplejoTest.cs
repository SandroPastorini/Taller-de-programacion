﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ej04;


namespace ComplejoTest
{
    /// <summary>
    /// La clase <c>ComplejoTest</c> prueba todos los métodos de la clase <c>Complejo</c>
    /// </summary>
    [TestClass]
    public class ComplejoTest
    {
        /// <summary>
        /// El TestMethod <remarks>Radianes</remarks> analiza el resultado del ARGUMENTO EN RADIANES de un número complejo        
        /// </summary>       
        [TestMethod]
        public void Radianes()
        {
            Complejo unComplejo = new Complejo(4,-3);
            double ResultadoEsperado = 0.0873;
            double Resultado;
            Resultado = Math.Round(unComplejo.ArgumentoEnRadianes,4);

            Assert.AreEqual(ResultadoEsperado,Resultado);
        }
        /// <summary>
        /// El TestMethod <remarks>Grados</remarks> analiza el resultado del ARGUMENTO EN GRADOS de un número complejo        
        /// </summary>       
        [TestMethod]
        public void Grados()
        {
            Complejo unComplejo = new Complejo(4, -3);
            double ResultadoEsperado =286.48;
            double Resultado;
            Resultado = Math.Round(unComplejo.ArgumentoEnGrados, 2);

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }

        /// <summary>
        /// El TestMethod <remarks>Magnitud</remarks> analiza el resultado de la MAGNITUD de un número complejo        
        /// </summary>       
        [TestMethod]
        public void Magnitud()
        {
            Complejo unComplejo = new Complejo(4, -3);
            double ResultadoEsperado = 5;
            double Resultado;
            Resultado = unComplejo.Magnitud;

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }

        /// <summary>
        /// El TestMethod <remarks>Real</remarks> analiza la parte real de un número complejo        
        /// </summary>       
        [TestMethod]
        public void Real()
        {
            Complejo unComplejo = new Complejo(4, -3);
            bool ResultadoEsperado = false;
            bool Resultado;
            Resultado = unComplejo.EsReal;

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }

        /// <summary>
        /// El TestMethod <remarks>Imaginario</remarks> analiza la parte imaginaria de un número complejo        
        /// </summary>       
        [TestMethod]
        public void Imaginario()
        {
            Complejo unComplejo = new Complejo(4, -3);
            bool ResultadoEsperado = false;
            bool Resultado;
            Resultado = unComplejo.EsImaginario;

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }

        /// <summary>
        /// El TestMethod <remarks>Igual</remarks> compara la igualdad de dos números complejos.       
        /// </summary>       
        [TestMethod]
        public void Igual()
        {
            Complejo unComplejo = new Complejo(4, -3);
            Complejo otroComplejo = new Complejo(2, 1);
            bool ResultadoEsperado = false;
            bool Resultado;
            Resultado = unComplejo.EsIgual(otroComplejo);

            Assert.AreEqual(ResultadoEsperado, Resultado);
        }

        /// <summary>
        /// El TestMethod <remarks>UnConjugado</remarks> analiza si el resultado es el conjugado de un número complejo ingresado
        /// usando el método <remarks> Conjugado</remarks> de la clase <c>Complejo</c>        
        /// </summary>       
        [TestMethod]
        public void UnConjugado()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo ResultadoEsperado = new Complejo(2, -3);
            Complejo Resultado;
            Resultado = unComplejo.Conjugado;
            
            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        /// <summary>
        /// El TestMethod <remarks> SumarComplejos</remarks> analiza el resultado de la suma entre dos complejos usando 
        /// el método <remarks>Sumar</remarks> de la clase <c>Complejo</c>.
        /// </summary>
        [TestMethod]
        public void SumarComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(5, 4);
            Complejo Resultado;
            Resultado = unComplejo.Sumar(otroComplejo);
            
            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        /// <summary>
        /// El TestMethod <remarks>RestarComplejos</remarks> analiza el resultado de la resta entre dos complejos usando 
        /// el método <remarks>Restar</remarks> de la clase <c>Complejo</c>.
        /// </summary>
        [TestMethod]
        public void RestarComplejos()
        {
            Complejo unComplejo = new Complejo(5, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(2, 2);
            Complejo Resultado;
            Resultado = unComplejo.Restar(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        /// <summary>
        /// El TestMethod <remarks>MultiplicarComplejos</remarks> analiza el resultado de la multiplicación entre dos complejos usando 
        /// el método <remarks>MultiplicarPor</remarks> de la clase <c>Complejo</c>.
        /// </summary>
        [TestMethod]
        public void MultiplicarComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(2, 1);
            Complejo ResultadoEsperado = new Complejo(1, 8);
            Complejo Resultado;
            Resultado = unComplejo.MultiplicarPor(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }

        /// <summary>
        /// El TestMethod <remarks> DividirComplejos</remarks> analiza el resultado de la división entre dos complejos usando 
        /// el método <remarks>DividirPor</remarks> de la clase <c>Complejo</c>.
        /// </summary>
        [TestMethod]
        public void DividirComplejos()
        {
            Complejo unComplejo = new Complejo(2, 3);
            Complejo otroComplejo = new Complejo(3, 1);
            Complejo ResultadoEsperado = new Complejo(0.9,0.7);
            Complejo Resultado;
            Resultado = unComplejo.DividirPor(otroComplejo);

            Assert.AreEqual(ResultadoEsperado.Real, Resultado.Real);
            Assert.AreEqual(ResultadoEsperado.Imaginario, Resultado.Imaginario);
        }
    }
}
