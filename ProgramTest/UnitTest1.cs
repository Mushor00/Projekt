using System;
using Xunit;
using projekt123;

namespace projekt123Test
{
    public class ProgramTest
    {
        [Fact]
        public void TestAddition()
        {
            // Dodawanie: 5 + 3 = 8
            double result = Program.Calculate(1, 5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            // Odejmowanie: 10 - 4 = 6
            double result = Program.Calculate(2, 10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            // Mnożenie: 4 * 5 = 20
            double result = Program.Calculate(3, 4, 5);
            Assert.Equal(20, result);
        }

        [Fact]
        public void TestDivision()
        {
            // Dzielenie: 20 / 5 = 4
            double result = Program.Calculate(4, 20, 5);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            // Dzielenie przez zero
            var exception = Assert.Throws<ArgumentException>(() => Program.Calculate(4, 10, 0));
            Assert.Equal("Nie można dzielić przez zero!", exception.Message);
        }

        [Fact]
        public void TestExponentiation()
        {
            // Potęgowanie: 2^3 = 8
            double result = Program.Calculate(5, 2, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestSquareRoot()
        {
            // Pierwiastek kwadratowy z 9 = 3
            double result = Program.Calculate(6, 9, 0);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestSquareRootOfNegativeNumber()
        {
            // Pierwiastek kwadratowy z liczby ujemnej
            var exception = Assert.Throws<ArgumentException>(() => Program.Calculate(6, -4, 0));
            Assert.Equal("Nie można pierwiastkować liczby ujemnej!", exception.Message);
        }

        [Fact]
        public void TestInvalidChoice()
        {
            // Nieprawidłowa operacja
            var exception = Assert.Throws<ArgumentException>(() => Program.Calculate(99, 5, 3));
            Assert.Equal("Nieprawidłowy wybór!", exception.Message);
        }
    }
}
