using System;
using Xunit;
using Moq;

namespace Vaques.Model
{
    public class CamioTests
    {
        [Theory]
        [InlineData("0.0")]
        [InlineData("-5.0")]
        [InlineData("")]
        public void Test_PesMaxim(double pesMax)
        {
            // ARRANGE
            var c = new Camio(pesMax);

            // ACT
            var resultat = c.PesMaxim;

            // ASSERT
            Assert.Equal(0, resultat);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(10.0)]
        public void Test_EntraVaca(double pes)
        {
            // ARRANGE
            var r = new Raca("Florida",12.0);
            var v = new Vaca("Margarita",pes,r);
            var c = new Camio(500.0);
            c.EntraVaca(v);

            // ACT
            var resultat = c.PesActual;

            // ASSERT
            Assert.Equal(pes, resultat);
        }
    }
}
