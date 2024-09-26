using System;
using Xunit;
using NewTalents;

namespace Tests
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "20/02/2020";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 9)]
        public void TesteDeSoma(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 20)]
        public void TesteDeMultiplicacao(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(2, 2, 1)]
        [InlineData(8, 2, 4)]
        public void TesteDeDividir(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);
        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(2, 2, 0)]
        [InlineData(8, 2, 6)]
        public void TesteDeSubtrair(int num1, int num2, int resultadoEsperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestarDivisãoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(1, 5);
            calc.Somar(1, 8);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }

    }
}
