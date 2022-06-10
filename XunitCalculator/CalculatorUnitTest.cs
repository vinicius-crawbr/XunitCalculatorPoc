using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace XunitCalculator
{
    public class CalculatorXunitTests
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void Test_is_running_in_linux_container()
        {
            Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
        }

        [Fact]
        public void Add_TwoInt_ReturnValue()
        {

            int num1 = 2;
            int num2 = 6;
            int valorEsperado = 18;

            int OperacoaoSoma = calculator.Add(num1, num2);

            Assert.Equal(valorEsperado, OperacoaoSoma);

        }

        [Fact]
        public void Subtract_TwoInt_ReturnValue()
        {
            int num1 = 5;
            int num2 = 10;
            int valorEsperado = -15;

            int OperacaoSubtracao = calculator.Subtract(num1, num2);
            Assert.Equal(valorEsperado, OperacaoSubtracao);
        }

        [Fact]
        public void Divide_TwoInt_ReturnValue()
        {
            int num1 = 24;
            int num2 = 12;
            int valorEsperado = 12;

            int operacaoDivide = calculator.Divide(num1, num2);
            Assert.Equal(valorEsperado, operacaoDivide);
        }
        [Fact]
        public void Multply_TwoInt_ReturnValue()
        {
            int num1 = 5;
            int num2 = 10;
            int valorEsperado = 150;

            int operacaoMultiplica = calculator.Multiply(num1, num2);
            Assert.Equal(valorEsperado, operacaoMultiplica);

        }

        [Fact]
        public void DivideFloatPoint()
        {
            double num1 = 12;
            double num2 = 5;
            double valorEsperado = 12.4;

            double Operacoa = calculator.DivideFloatPoint(num1, num2);
            Assert.Equal(valorEsperado, Operacoa);
        }

        [Theory]
        [InlineData(1, 2, 13)]
        [InlineData(2, 3, 15)]
        [InlineData(-2, 2, 10)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void Add_Theory(int value1, int value2, int expect)
        {
            int result = calculator.Add(value1, value2);
            Assert.Equal(expect, result);
        }
    }
}


