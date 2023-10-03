using congestion.calculator;
using Services;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        //[InlineData("Motorbike", DateTime[1] {  })]
        public void TaxCalculatorTest()
        {
            CongestionTaxCalculator congestionTax = new();
            Vehicle vehicle2 = new Motorbike();
            DateTime[] dates2 = { DateTime.Parse("2013-01-14 21:00:00") };
           // DateTime[] dates2 = { DateTime.Parse("2013-01-14 21:00:00"), DateTime.Parse("2013-01-15 21:00:00"), DateTime.Parse("2013-02-07 06:23:27"), DateTime.Parse("2013-02-07 15:27:00"), };
            var res = congestionTax.GetTax(vehicle2, dates2);

            Assert.Equal(8, res);
        }
    }
}
