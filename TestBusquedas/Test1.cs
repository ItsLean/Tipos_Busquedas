using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasBusqueda
{
    [TestClass]
    public class BusquedaTests
    {
        [TestMethod]
        public void BusquedaLineal_ElementoEncontrado()
        {
            int[] arreglo = { 3, 5, 7, 9 };
            int resultado = BusquedaLineal.Buscar(arreglo, 7);
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void BusquedaLineal_ElementoNoEncontrado()
        {
            int[] arreglo = { 1, 2, 3 };
            int resultado = BusquedaLineal.Buscar(arreglo, 10);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoEncontrado()
        {
            int[] arreglo = { 2, 4, 6, 8, 10 };
            int resultado = BusquedaBinaria.Buscar(arreglo, 8);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void BusquedaBinaria_ElementoNoEncontrado()
        {
            int[] arreglo = { 1, 3, 5, 7 };
            int resultado = BusquedaBinaria.Buscar(arreglo, 2);
            Assert.AreEqual(-1, resultado);
        }
    }
}
