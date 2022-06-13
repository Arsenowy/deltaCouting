using System;
using Xunit;
using DeltaCouting;

namespace DeltaCouting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void two_delta_roots()
        {
            DeltaCouting delta_couting = new DeltaCouting(1, 8, 12);
            double[] root = new double[2];
            double[] expected = new double[2];

            root = delta_couting.countRoot();
            expected[0] = -6;
            expected[1] = -2;

            Assert.Equal(expected, root);
        }
        [Fact]
        public void one_delta_root()
        {
            DeltaCouting delta_couting = new DeltaCouting(1, 8, 16);
            double[] root = new double[2];
            double[] expected = new double[2];

            root = delta_couting.countRoot();
            expected[0] = -4;

            Assert.Equal(expected, root);
        }
        [Fact]
        public void delta_less_than_zero()
        {
            DeltaCouting delta_couting = new DeltaCouting(1, 4, 16);
            double[] root = new double[2];
            double[] expected = new double[2];

            root = delta_couting.countRoot();
            expected = null;

            Assert.Equal(expected, root);
        }
    }
}
