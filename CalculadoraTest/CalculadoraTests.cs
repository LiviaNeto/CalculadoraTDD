using CalculadoraSimples;

namespace CalculadoraTest
{
    public class CalculadoraTests
    {
        public Calculadora construirClasse()
        {
            Calculadora calc = new Calculadora("31/03/2025");

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void SomarNum1MaisNum2DeveRetornarRes(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(9, 5, 4)]
        [InlineData(4, 6, -2)]
        public void SubtrairNum1MenosNum2DeveRetornarRes(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(9, 5, 45)]
        public void MultiplicarNum1VezesNum2DeveRetornarRes(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void DividirNum1PorNum2DeveRetornarRes(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void DividirPor02DeveRetornarExcecao()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void HistoricoNaoPodeSerVazioEDeveRetornar3Elementos()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Subtrair(15, 5);
            calc.Multiplicar(5, 6);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}