using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Model;
using System.Collections.Generic;

namespace ObjectComparer.Tests
{
    [TestClass]
    public class ComparerFixture
    {
        [TestMethod]
        public void Null_values_are_similar_test()
        {
            string first = null, second = null;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Integer_values_are_similar_test()
        {
            int second;
            int first = second = 2;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_values_are_similar_test()
        {
            string second;
            string first = second = "test value";
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Student_values_are_similar_test()
        {
            Assert.IsTrue(
                Comparer.AreSimilar(
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 80, 90, 100 }
                    },
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 80, 90, 100 }
                    }
            ));
        }

        [TestMethod]
        public void Student_values_are_not_similar_test()
        {
            Assert.IsFalse(
                Comparer.AreSimilar(
                    new Student()
                    {
                        Id = 100,
                        Name = "John"
                    },
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 80, 90, 100 }
                    }
            ));
        }

        [TestMethod]
        public void Student_with_different_values_are_not_similar_test()
        {
            Assert.IsFalse(
                Comparer.AreSimilar(
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 70, 90, 100 }
                    },
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 80, 90, 100 }
                    }
            ));
        }

        [TestMethod]
        public void Student_values_with_different_order_are_similar_test()
        {
            Assert.IsTrue(
                Comparer.AreSimilar(
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 90, 80, 100 }
                    },
                    new Student()
                    {
                        Id = 100,
                        Name = "John",
                        Marks = new[] { 80, 90, 100 }
                    }
            ));
        }

        [TestMethod]
        public void Student_list_of_values_are_similar_test()
        {
            Assert.IsTrue(
                Comparer.AreSimilar(
                    new List<Student>()
                    {
                        new Student()
                        {
                            Id = 100,
                            Name = "John",
                            Marks = new[] { 90, 80, 100 }
                        }
                    }, 
                    new List<Student>()
                    {
                        new Student()
                        {
                            Id = 100,
                            Name = "John",
                            Marks = new[] { 80, 90, 100 }
                        }
                    }

            ));
        }

        [TestMethod]
        public void Student_list_of_null_values_are_similar_test()
        {
            Assert.IsTrue(
                Comparer.AreSimilar<List<Student>>(
                    null,
                    null

            ));
        }
    }
}
