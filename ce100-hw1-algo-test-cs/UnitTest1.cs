using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;
using System.Collections;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionShort_Test1()
        {
            int[] arr = { 12, 4, 17, 80, 16, 67, 1 };
            int[] keynum = { 1, 4, 12, 16, 17, 67, 80 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynum);
        }

        [TestMethod]
        public void InsertionShort_Test2()
        {
            int[] arr = { 21, 55, 10, 76, 60, 82, 42 };
            int[] keynumber = { 10, 21, 42, 55, 60, 76, 82 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynumber);
        }

        [TestMethod]
        public void InsertionShort_Test3()
        {
            int[] arr = { 10, 20, 40, 70, 50, 60, 30 };
            int[] keynumber = { 10, 20, 30, 40, 50, 60, 70 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynumber);
        }


        [TestMethod]
        public void SelectionShort_Test1()
        {
            int[] arr = { 12, 4, 17, 80, 16, 67, 1 };
            int[] keynumber = { 1, 4, 12, 16, 17, 67, 80 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynumber);
        }

        [TestMethod]
        public void SelectionShort_Test()
        {
            int[] arr = { 21, 55, 10, 76, 60, 82, 42 };
            int[] keynumber = { 10, 21, 42, 55, 60, 76, 82 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynumber);
        }

        [TestMethod]
        public void SelectionShort_Test3()
        {
            int[] arr = { 10, 20, 40, 70, 50, 60, 30 };
            int[] keynumber = { 10, 20, 30, 40, 50, 60, 70 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynumber);
        }

        [TestMethod]
        public void NaivePower_Test1()
        {
            int a = 5;
            uint b = 2;
            int result = 25;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_Test2()
        {
            int a = 3;
            uint b = 3;
            int result = 27;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_Test3()
        {
            int a = 7;
            uint b = 4;
            int result = 2401;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void IterativebinarySearch_Test3()
        {
            int[] array = { 21, 55, 10, 76, 60, 82, 42 };
            int index = 55;
            int result = 1;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void IterativebinarySearch_Test2()
        {
            int[] array = { 9, 12, 14, 26, 75, 92, 94 };
            int index = 26;
            int result = 3;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void IterativebinarySearch_Test1()
        {
            int[] array = { 21, 55, 10, 76, 82, 42 };
            int index = 82;
            int result = 4;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void RecursivebinarySearch_Test1()
        {
            int[] array = { 10, 11, 12, 13, 14, 15, 16 };
            int index = 15;
            int result = 5;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }


        [TestMethod]
        public void RecursivebinarySearch_Test2()
        {
            int[] array = { 11, 12, 13, 14, 15, 16, 17 };
            int index = 15;
            int result = 4;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }


        [TestMethod]
        public void RecursivebinarySearch_Test3()
        {
            int[] array = { 12, 13, 14, 15, 16, 17, 18 };
            int index = 15;
            int result = 3;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }

        [TestMethod]
        public void RecursivePower_Test1()
        {
            int a = 2;
            int b = 10;
            int result = 1024;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_Test2()
        {
            int a = 7;
            int b = 4;
            int result = 2401;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_Test3()
        {
            int a = 6;
            int b = 6;
            int result = 46656;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void MergeSort_Test1()
        {

            int[] Arr1 = new int[6] { 14, 28, 7, 21, 35, 42, };
            int[] Exp = new int[6] { 7, 14, 21, 28, 35, 42, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_Test2()
        {

            int[] Arr1 = new int[8] { 20, 40, 10, 30, 60, 50, 80, 70 };
            int[] Exp = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_Test3()
        {

            int[] Arr1 = new int[5] { 8, 16, 4, 12, 20, };

            int[] Exp = new int[5] { 4, 8, 12, 16, 20, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }
    }






}