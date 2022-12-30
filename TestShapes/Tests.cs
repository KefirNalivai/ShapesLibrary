using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassShapesLibrary;
using System;
using Xunit;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TestShapes
{
    [TestClass]
    public class CircleTests
    {
        [DataTestMethod]
        [DataRow(null)]
        [DataRow(0)]
        [DataRow(-34)]
        [DataRow(-213213)]
        [DataRow(-3424234123)]
        [DataRow(-12)]
        [ExpectedException(typeof(ArgumentException))]
        public   async Task InvalidInputs(double target)
        {
           new Circle(target);
        }



        [DataTestMethod]
        [DataRow(1, 3.14)]
        [DataRow(11, 380.13)]
        [DataRow(4.5, 63.62)]
        [DataRow(100, 31415.93)]

        public async Task TrueInputs(double target, double exp)
        {
            Circle abc = new Circle(target);
            Assert.AreEqual(exp, abc.CalcArea());
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [DataTestMethod]
        [DataRow(null, null, null)]
        [DataRow(0, 0, 0)]
        [DataRow(0, 4, -1)]
        [DataRow(-3, -4, 3)]
        [DataRow(1, 2, -4)]
        [DataRow(0, 0, 4)]
        [ExpectedException(typeof(ArgumentException))]
        public async Task InvalidInputs(double target1, double target2, double target3)
        {
            new Triangle(target1, target2, target3);
        }



        [DataTestMethod]
        [DataRow(4, 2, 3, 2.90)]
        [DataRow(11, 5, 12, 27.5)]
        [DataRow(51, 12, 41, 151.26)]
        [DataRow(3, 4, 5, 6)]

        public async Task TrueInputs(double target1, double target2, double target3, double exp)
        {
            Triangle abc = new Triangle(target1, target2, target3);
            Assert.AreEqual(exp, abc.CalcArea());
        }

        [DataTestMethod]
        [DataRow(4, 2, 3, false)]
        [DataRow(7, 24, 25, true)]
        [DataRow(51, 12, 41, false)]
        [DataRow(3, 4, 5, true)]

        public async Task isPryam(double target1, double target2, double target3, bool exp)
        {
            Triangle abc = new Triangle(target1, target2, target3);
            Assert.AreEqual(exp, abc.isPryam());
        }
    }

    [TestClass]
    public class TrapezoidTest
    {
       



        [DataTestMethod]
        [DataRow(3, 4, 11, 38.5)]
        [DataRow(5, 2, 4, 14)]
        [DataRow(152, 52, 521, 53142)]
        [DataRow(7777, 8888, 9999, 83316667.5)]

        public async Task TrueInputs(double target1, double target2, double target3, double exp)
        {
            Trapezoid abc = new Trapezoid(target1, target2, target3);
            Assert.AreEqual(exp, abc.CalcArea());
        }

       
    }

    [TestClass]
    public class WithouIniTest
    {

        [DataTestMethod]
        [DataRow(1, 3.14)]
        [DataRow(11, 380.13)]
        [DataRow(4.5, 63.62)]
        [DataRow(100, 31415.93)]

        public async Task CircleCalc(double target, double exp)
        {
            
            Assert.AreEqual(exp, new CalcWithoutIni().CalcCircleArea(target));
        }

        [DataTestMethod]
        [DataRow(3, 4, 11, 38.5)]
        [DataRow(5, 2, 4, 14)]
        [DataRow(152, 52, 521, 53142)]
        [DataRow(7777, 8888, 9999, 83316667.5)]

        public async Task TrapezoidInputs(double target1, double target2, double target3, double exp)
        {
            Assert.AreEqual(exp, new CalcWithoutIni().CalcTrapezoidArea(target1, target2, target3));
        }

        [DataTestMethod]
        [DataRow(4, 2, 3, 2.90)]
        [DataRow(11, 5, 12, 27.5)]
        [DataRow(51, 12, 41, 151.26)]
        [DataRow(3, 4, 5, 6)]

        public async Task TriangleInputs(double target1, double target2, double target3, double exp)
        {
            Assert.AreEqual(exp, new CalcWithoutIni().CalcTriangleArea(target1, target2, target3));
        }
    }


    
}
