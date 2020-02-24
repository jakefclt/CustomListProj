using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;
namespace CustomListClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneValue_IncrementCount()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 2;
            int expected = 1;
            int actual;
            //Act
            list.Add(value1);
            actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_SecondValue_VerifyIndex0()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            int actual = list[0];
            list.Add(expected);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoValues_VerifyIndex1()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            int actual = list[1];
            list.Add(value1);
            list.Add(value2);

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Add_Values_ReturnCount()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int value1 = 5;
            int value2 = 15;
            int actual = list.Count;
            list.Add(value1);
            list.Add(value2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_Value_ToLastIndex()

        {
            CustomList<int> list = new CustomList<int>();
            int expected = 30;
            int value1 = 10;
            int value2 = 15;
            int value3 = 20;
            int value4 = 25;
            int value5 = 30;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            Assert.AreEqual(expected, list[4]);            
            

        }
        [TestMethod]
        public void Add_Value_ValueAt0Index()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            int value1 = 5;
            int value2 = 15;
            int value3 = 20;
            int value4 = 25;
            int value5 = 30;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            Assert.AreEqual(expected, list[0]);

        }
        [TestMethod]
        public void Remove_OneValue_DecrementCount()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int value1 = 5;
            int value2 = 10;
            int actual = list.Count;
            list.Add(value1);
            list.Add(value2);
            list.Remove(value2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_FirstValue_VerifyIndex0()
        {
            CustomList<int> list = new CustomList<int>();
            int expected= 10;
            int value1 = 5;
            int value2 = 10;

            list.Add(value1);
            list.Add(value2);

            list.Remove(value1);

            Assert.AreEqual(expected, list[0]);
                
        }
        [TestMethod]
        public void Remove_TwoValues_VerifyIndex1()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 20;
            int value1 = 10;
            int value2 = 15;
            int value3 = 20;
            int value4 = 25;
            int value5 = 30;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            list.Remove(value1);
            list.Remove(value4);

            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Remove_Value_FromFirstIndexFound() 
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int value1 = 5;
            int value2 = 2;
            int value3 = 5;
            int value4 = 5;
            int value5 = 5;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);

            list.Remove(5);

            Assert.AreEqual(expected, list[0]);

        }

        
    }

}
