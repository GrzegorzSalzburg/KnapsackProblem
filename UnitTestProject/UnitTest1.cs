using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KnapsackProblem;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /*Test  sprawdzajacy zgodnosc rozmiaru stworzonej tabeli na indeksy elementow*/
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            Problem problem = new Problem(i, 5);
            int[] array = problem.Solver(10, i);
            Assert.AreEqual(i + 2, array.Length); //1 element, 2 sumy końcowe
        }

        /*Test sprawdzajacy dla przypadku, gdy capacity jest 0, to w plecaku nie ma zadnych elementow*/
        [TestMethod]
        public void TestMethod2()
        {
            Problem problem = new Problem(1, 5);
            int[] array = problem.Solver(0, 1);
            for (int i = 0; i < array.Length - 2; i++)
            {
                Assert.AreEqual(array[i], -1); //taki index dostaje przedmiot nie mieszczacy sie w plecaku
            }
        }

        /*Test sprawdzający konkretne rozwiazanie*/
        [TestMethod]
        public void TestMethod3()
        {
            Problem problem = new Problem(5, 1);
            int[] array = problem.Solver(10, 5);
            Assert.AreEqual(array[0],0);
            Assert.AreEqual(array[1],-1);
            Assert.AreEqual(array[2],2);
            Assert.AreEqual(array[3],-1);
            Assert.AreEqual(array[4],-1);

        }
    }
}
