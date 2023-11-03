using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint4.Task3.V27.Lib;
namespace Tyuiu.DudkovIE.Sprint4.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] { { 2, 0, 0, 0, 2 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
                                        { 0, 0, 0, 0, 0 },
            };
            int result = ds.Calculate(array);
            Assert.AreEqual(25, result);
            
        }
    }
}
