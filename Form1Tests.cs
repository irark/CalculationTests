using System;
using Xunit;
using Test;

namespace Calc.Test
{
    public class Form1Tests
    {
        [Fact(DisplayName ="Throw exception if n < 1")]
        public void ViewModel_ThrowExceptionIfNIsLowThenOne()
        {
                       
            Assert.Throws<Exception>(delegate{ var calc = new Calculation(-1, 3, new long[] { 1, 2 }); });
        }
        [Fact(DisplayName = "Throw exception if m < 1")]
        public void ViewModel_ThrowExceptionIfMIsLowThenOne()
        {
            Assert.Throws<Exception>(delegate { var calc = new Calculation(2, 0, new long[] { 1, 2 }); });
        }
        [Fact(DisplayName = "Throw exception if v[i] < 1")]
        public void ViewModel_ThrowExceptionIfVIsLowThenOne()
        {
            Assert.Throws<Exception>(delegate { var calc = new Calculation(2, 3, new long[] { 1, 0 }); });
        }
        [Fact(DisplayName = "Throw exception if v.Length != n")]
        public void ViewModel_ThrowExceptionIfLengthNotEqualN()
        {
            Assert.Throws<Exception>(delegate { var calc = new Calculation(3, 3, new long[] { 1, 2 }); });
        }
        [Fact(DisplayName = "Calculate time correctly")]
        public void ViewModel_GetResult()
        {
            var calc = new Calculation(3, 1000, new long[] { 2, 3, 4 });
            Assert.Equal(924, calc.GetResult(out long[] count));
        }
        [Fact(DisplayName = "Counts the number of photos correctly")]
        public void ViewModel_GetResultForAllMembers()
        {
            var calc = new Calculation(3, 2, new long[] { 2, 3, 4 });
            long[] count;
            calc.GetResult(out count);
            Assert.Equal(new long[] { 1, 1, 0}, count);
        }
    }
}
