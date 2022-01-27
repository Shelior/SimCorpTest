using ListLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    public class DoubleLinkedListTests
    {
        private DoubleLinkedList list;
        [SetUp]
        public void Setup()
        {
            list = new DoubleLinkedList();
        }

        [Test]
        public void TestSingleAdd()
        {
            list.Add("one");

            Assert.AreEqual("one", list.First.Data);
        }

        [Test]
        public void TestDoubleAdd()
        {
            list.Add("one");
            list.Add("two");

            var firstItem = list.First;
            Assert.AreEqual("one", firstItem.Data);
            Assert.AreEqual("two", firstItem.Next.Data);
        }

        [Test]
        public void TestFind()
        {
            FillList();

            var item = list.Find("three");

            Assert.IsNotNull(item);
            Assert.AreEqual("two", item.Previous.Data);
            Assert.AreEqual("three", item.Data);
            Assert.AreEqual("four", item.Next.Data);
        }


        [Test]
        public void TestToArray()
        {
            FillList();

            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 4);
            Assert.AreEqual("one", array[0].Data);
            Assert.AreEqual("two", array[1].Data);
            Assert.AreEqual("three", array[2].Data);
            Assert.AreEqual("four", array[3].Data);
        }

        [Test]
        public void TestEmptyToArray()
        {
            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 0);
        }

        [Test]
        public void TestDelete()
        {
            FillList();

            list.Delete("three");
            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 3);
            Assert.AreEqual("one", array[0].Data);
            Assert.AreEqual("two", array[1].Data);
            Assert.AreEqual("four", array[2].Data);
        }

        [Test]
        public void TestDeleteByItem()
        {
            FillList();

            var toDelete = list.Find("three");
            list.Delete(toDelete);
            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 3);
            Assert.AreEqual("one", array[0].Data);
            Assert.AreEqual("two", array[1].Data);
            Assert.AreEqual("four", array[2].Data);
        }

        [Test]
        public void TestDeleteNonexistent()
        {
            FillList();

            list.Delete("five");
            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 4);
            Assert.AreEqual("one", array[0].Data);
            Assert.AreEqual("two", array[1].Data);
            Assert.AreEqual("three", array[2].Data);
            Assert.AreEqual("four", array[3].Data);
        }

        [Test]
        public void TestDeleteFirst()
        {
            FillList();

            list.Delete("one");
            var array = list.ToArray();

            Assert.IsNotNull(array);
            Assert.True(array.Length == 3);
            Assert.AreEqual("two", list.First.Data);
            Assert.AreEqual("two", array[0].Data);
            Assert.AreEqual("three", array[1].Data);
            Assert.AreEqual("four", array[2].Data);
        }

        protected void FillList()
        {
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
        }
    }
}
